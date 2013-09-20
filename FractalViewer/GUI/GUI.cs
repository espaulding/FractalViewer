using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using FractalViewer.FractalSpace;
using System.Threading;

namespace FractalViewer
{
    public partial class GUI : Form
    {
        //Access to wallpaper
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        protected static extern Int32 SystemParametersInfo(UInt32 uiAction, UInt32 uiParam, String pvParam, UInt32 fWinIni);
        //
        protected const int CP_NOCLOSE_BUTTON = 0x200;
        private static UInt32 SPI_SETDESKWALLPAPER = 20;
        private static UInt32 SPIF_UPDATEINIFILE = 0x1;

        protected Fractal f = null;
        protected Fractal miniFrac = null;
        protected Rectangle view;
        protected FormControlObserver fco;
        protected IAsyncResult ar;
        protected delegate void calcDelegate();
        protected calcDelegate cd;
        protected delegate void scrollDel();
        protected delegate void resizeEndDel(object sender, EventArgs e);

        //GUI globals
        protected Bitmap buffer;
        protected Bitmap minimap;
        protected int sbHorizWidth = 0; //this variable is here to allow the user to zoom at the edges when scrollbar is absent
        protected int sbVertWidth = 0;
        protected const int MINIMUM_RESOLUTION = 200;
        protected const int MAXIMUM_RESOLUTION = 3000;
        protected const int SCROLLBAR_WIDTH = 17;

        //background data globals
        protected int[,] picture = null, minimatrix = null;
        protected int xResolution, yResolution;
        protected bool calledCalc = false;
        protected bool rendering = false;
        protected int maxDetailLevel = int.MaxValue;

        protected FractalPortal portal; // for callback

        public GUI()
        {
            //Forms MUST have a blank constructor for the designer tool
        }

        public GUI(FractalPortal p)
        {
            portal = p;
            InitializeComponent();
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            cd = new calcDelegate(calcWrapper);
        }

        //disable the form's close button
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        #region FormAndControlEvents

        protected void fractalViewerPanel_Paint(object sender, PaintEventArgs e)
        {
            GUI_ResizeEnd(sender, e);
        }

        //because resize needs to be checked before every paint and after every resize you must always paint 
        //paint just calls resize because the 2 operations are basically married
        //resize checks the panel size, the scrollbars, the viewport, and does a paint operation
        protected virtual void GUI_ResizeEnd(object sender, EventArgs e)
        {
            if (fractalViewerPanel.InvokeRequired == false)
            {
                int w = fractalViewerPanel.Width - sbVertWidth, h = fractalViewerPanel.Height - sbHorizWidth;
                view.Width = w; view.Height = h;

                //am I stretching a dimension? make sure to view all of that dimension
                if (w > xResolution) { view.X = 0; }
                if (h > yResolution) { view.Y = 0; }

                //am I expanding a form with scrollbars? keep the view consistant
                if (w < xResolution && view.X + view.Width > xResolution) { view.X = xResolution - w; }
                if (h < yResolution && view.Y + view.Height > yResolution) { view.Y = yResolution - h; }

                //if the buffer is bigger than the panel dimension don't rescale that dimension
                if (xResolution > fractalViewerPanel.Width) { w = xResolution; }
                if (yResolution > fractalViewerPanel.Height) { h = yResolution; }

                //only rescale the image if one of the dimensions actually needs to be stretched
                if (w != buffer.Width || h != buffer.Height)
                {
                    buffer = Common.HF.reScaleImage((Image)buffer, w, h, "noscale");
                }

                adjustScrollBars();
                repaint();
            }
            else
            {
                resizeEndDel d = new resizeEndDel(GUI_ResizeEnd);
                fractalViewerPanel.Invoke(d, new object[] { sender, e });
            }
        }

        protected void fractalViewerPanel_Scroll(object sender, ScrollEventArgs e)
        {
            if (rendering) { return; } //stop scrolling while we render please
            int pos = e.NewValue;
            if (pos < 0) { pos = 0; }
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                if (pos > xResolution - fractalViewerPanel.Width - 1) { pos = xResolution - fractalViewerPanel.Width - 1; }
                view.X = pos;
            }

            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                if (pos > yResolution - fractalViewerPanel.Height - 1) { pos = yResolution - fractalViewerPanel.Height - 1; }
                view.Y = pos;
            }
        }

        protected virtual void btnPortal_Click(object sender, EventArgs e)
        {
            portal.makeVisible();
            this.Close();
        }

        protected virtual void btnQuit_Click(object sender, EventArgs e)
        {
            f.cancel();
            this.Close();
            portal.quitCallback();
        }

        protected virtual void stopButton_Click(object sender, EventArgs e)
        {
            f.cancel();
        }

        protected virtual void saveButton_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        buffer.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        buffer.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        buffer.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }
                fs.Close();
            }
            saveFileDialog1.Dispose();
        }

        protected virtual void desktopImageButton_Click(object sender, EventArgs e)
        {
            buffer.Save("desktopImage.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            //SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, "desktopImage.bmp", 0x01 | 0x02);
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, "desktopImage.bmp", SPIF_UPDATEINIFILE);
        }

        protected void applyDetail_Click(object sender, EventArgs e, TextBox txtDetailLevel)
        {
            int detailLevel = 0;
            int.TryParse(txtDetailLevel.Text, out detailLevel);

            //what if the detailLevel didn't change... well then do nothing
            if (detailLevel == f.getDetailLevel()) { return; }

            if (detailLevel < 1 || detailLevel > maxDetailLevel)
            {
                string messageText = "Invalid detail level";
                string messageCaption = "Error";
                MessageBox.Show(messageText, messageCaption);
                txtDetailLevel.Text = f.getDetailLevel().ToString();
                return;
            }
            f.setDetailLevel(detailLevel);
            doFractal();
        }

        protected void resolutionButton_Click(object sender, EventArgs e, TextBox resXBox, TextBox resYBox)
        {
            int tx = xResolution, ty = yResolution;
            if (resXBox.Text.Length > 0) { int.TryParse(resXBox.Text, out xResolution); }
            else { xResolution = 0; }
            if (resYBox.Text.Length > 0) { int.TryParse(resYBox.Text, out yResolution); }
            else { yResolution = 0; }

            //what if the resolution didn't change... well then do nothing
            if (tx == xResolution && ty == yResolution) { return; }

            if (xResolution < MINIMUM_RESOLUTION)
            {
                xResolution = MINIMUM_RESOLUTION;
                resXBox.Text = MINIMUM_RESOLUTION.ToString();
            }
            if (yResolution < MINIMUM_RESOLUTION)
            {
                yResolution = MINIMUM_RESOLUTION;
                resYBox.Text = MINIMUM_RESOLUTION.ToString();
            }

            if (xResolution > MAXIMUM_RESOLUTION)
            {
                xResolution = MAXIMUM_RESOLUTION;
                resXBox.Text = MAXIMUM_RESOLUTION.ToString();
            }
            if (yResolution > MAXIMUM_RESOLUTION)
            {
                yResolution = MAXIMUM_RESOLUTION;
                resYBox.Text = MAXIMUM_RESOLUTION.ToString();
            }

            f.setResolution(xResolution, yResolution);
            adjustScrollBars();
            doFractal();
        }

        #endregion FormAndControlEvents

        #region HelperFunctions

        protected virtual void render()
        {
            if (!f.isFinished()) { return; }
            if (calledCalc) { picture = f.getMatrix(); }

            if (fractalViewerPanel.InvokeRequired == false) // get back to the GUI thread
            {
                rendering = true;
                //fractalViewerPanel.Enabled = false;
                //at large resolutions this still takes a long time
                buffer = new Bitmap(xResolution, yResolution);
                FractalEngine.render(buffer, picture);
                GUI_ResizeEnd(this, EventArgs.Empty);
                //fractalViewerPanel.Enabled = true;
                rendering = false;
                formToggle(true);
            }
            else
            {
                scrollDel d = new scrollDel(render);
                //Invoke = sychronous while BeginInvoke = asychronous 
                //true for delegate.BeginInvoke or delegate.Invoke
                //BeginInvoke seems to work while Invoke ends in a deadlock for the form
                //control.BeginInvoke executes without waiting for the UI thread to be ready
                //control.Invoke executes on the UI thread but waits for completetion
                //
                //This can cause the UI display to be out of synch or incorrect. HOWEVER ...
                //Note that the Windows Forms team has guaranteed that you can use Control.BeginInvoke 
                //in a "fire and forget" manner - i.e. without ever calling EndInvoke. 
                //This is not true of async calls in general: normally every BeginXXX 
                //should have a corresponding EndXXX call, usually in the callback.
                fractalViewerPanel.BeginInvoke(d, new object[] { });
            }

            if (calledCalc) { calledCalc = false; cd.EndInvoke(ar); }
        }

        //only call this when you're certain the form size doesn't need to be checked
        protected void repaint()
        {
            fractalViewerPanel.CreateGraphics().DrawImage(buffer, 0, 0, view, GraphicsUnit.Pixel);
            repaintMinimap();
        }

        protected virtual void repaintMinimap()
        {
            //a stub for mandel to override. otherwise, the minimap won't get painted when the background thread finishes
        }

        protected void adjustScrollBars()
        {
            if (fractalViewerPanel.InvokeRequired == false)
            {
                fractalViewerPanel.AutoScroll = true;
                if (xResolution > fractalViewerPanel.Width) { sbHorizWidth = SCROLLBAR_WIDTH; }
                else { sbHorizWidth = 0; } //this variable is here to allow the user to zoom at the edges when scrollbar is absent
                if (yResolution > fractalViewerPanel.Height) { sbVertWidth = SCROLLBAR_WIDTH; }
                else { sbVertWidth = 0; }
                fractalViewerPanel.AutoScrollMinSize = new Size(xResolution - sbVertWidth, yResolution - sbHorizWidth);
                //fractalViewerPanel.AutoScrollMinSize = new Size(xResolution, yResolution);
            }
            else
            {
                scrollDel d = new scrollDel(adjustScrollBars);
                fractalViewerPanel.Invoke(d, new object[] { });
            }
        }

        protected virtual void formToggle(bool state)
        {
            //will be overridden in the child form
        }

        private void calcWrapper()
        {
            f.calculate();
        }

        protected void doFractal()
        {
            f.beginCalc();
            calledCalc = true;
            formToggle(false);
            ar = cd.BeginInvoke(null, null);
        }

        protected int colorCalc(int[] rgb)
        {
            return (rgb[0] * 256 * 256) + (rgb[1] * 256) + rgb[2];
        }

        protected int colorToInt(Color c)
        {
            return (c.R * 256 * 256) + (c.G * 256) + (c.B);
        }

        #endregion HelperFunctions
    }
}
