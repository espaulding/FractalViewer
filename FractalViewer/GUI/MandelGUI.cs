using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FractalViewer
{
    public partial class MandelGUI : GUI
    {
        //graphical globals
        protected bool mouseDown = false;
        protected System.Drawing.Point zoomPoint1;

        //background data globals
        protected int[] colorChoice = new int[] { 0, 5, 2};
        protected int zoomIndex = 0;
        protected Window zoomBox = new Window(new Point(0, 0), new Point(1, 1));
        protected List<int[,]> history = new List<int[,]>();
            
        //constructor
        public MandelGUI(FractalPortal p) : base(p)
        {
            InitializeComponent();
        }

        #region FormAndControlEvents

        protected void MandelGUI_Load(object sender, EventArgs e)
        {
            fractalViewerPanel.MouseDown += new MouseEventHandler(fractalViewerPanel_MouseDown);
            fractalViewerPanel.MouseUp += new MouseEventHandler(fractalViewerPanel_MouseUp);
            fractalViewerPanel.MouseMove += new MouseEventHandler(fractalViewerPanel_MouseMove);

            maxDetailLevel = 10000;
            previousZoom.Visible = false;
            zoomIndexLabel.Visible = false;
            xResolution = fractalViewerPanel.Width;
            yResolution = fractalViewerPanel.Height;
            buffer = new Bitmap(xResolution, yResolution);
            minimap = new Bitmap(zoomDisplayBox.Width, zoomDisplayBox.Height);
            view = new Rectangle(0, 0, xResolution, yResolution);
            resXBox.Text = xResolution.ToString();
            resYBox.Text = yResolution.ToString();
            txtColorR.Text = colorChoice[0].ToString();
            txtColorG.Text = colorChoice[1].ToString();
            txtColorB.Text = colorChoice[2].ToString();

            FractalEngine.setColorMod(colorCalc(colorChoice));
            fco = new FormControlObserver(fractalStatus, btnStop, btnPortal);
            fractalStatus.Visible = false;
            f = FractalFactory.create(FractalFactory.fractalType.Mandelbrot, xResolution, yResolution, fco, true);
            f.Completed += new Fractal.CompletedEventHandler(render);
            txtDetailLevel.Text = f.getDetailLevel().ToString();
            
            cbMandelTypes.SelectedIndex = 0; //changing the selected index raises an event which does call doFractal
                                             //and does all the stuff commented out below
            //doFractal();  
            //miniFrac = FractalFactory.create(FractalFactory.fractalType.Mandelbrot, zoomDisplayBox.Width, zoomDisplayBox.Height, fco, false);
            //miniFrac.calculate();
            //minimatrix = miniFrac.getMatrix();
            //FractalEngine.render(minimap, minimatrix);
        }

        protected void fractalViewerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (!f.isFinished()) { return; }
            if (e.X > fractalViewerPanel.Width - sbVertWidth) { return; }
            if (e.Y > fractalViewerPanel.Height - sbHorizWidth) { return; }
            if (zoomIndex == 10)
            {
                string messageText = "Maximum Zooms Reached";
                string messageCaption = "Error";
                MessageBox.Show(messageText, messageCaption);
                return;
            }
            mouseDown = true;
            zoomPoint1 = new System.Drawing.Point(e.X, e.Y);
        }

        protected void fractalViewerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseDown || !f.isFinished()) { return; } //less assembly instructions this way

            System.Drawing.Point p2 = new System.Drawing.Point(e.X, e.Y);
            System.Drawing.Point p1 = new System.Drawing.Point(zoomPoint1.X, zoomPoint1.Y);
            if (p1.X > p2.X)
            {
                int temp = p1.X;
                p1.X = p2.X;
                p2.X = temp;
            }
            if (p1.Y > p2.Y)
            {
                int temp = p1.Y;
                p1.Y = p2.Y;
                p2.Y = temp;
            }

            Pen pen = new Pen(Color.White, 1);
            Graphics g = fractalViewerPanel.CreateGraphics();
            repaint();
            g.DrawRectangle(pen, p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
            pen.Dispose();
        }

        protected void fractalViewerPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            if (!f.isFinished()) { return; }
            if (zoomPoint1 == null || view == null) { return; }

            //conditions that may indicate a misclick zoom so don't zoom
            Point p1 = new Point(zoomPoint1.X, zoomPoint1.Y);
            Point p2 = new Point(e.X, e.Y);
            Window zoomWindow = new Window(p1, p2);
            if (zoomWindow.findDist() < 10) { return; } //too small a box
            if (Math.Abs(zoomWindow.BR.X - zoomWindow.TL.X) < 6) { return; } //long wide box
            if (Math.Abs(zoomWindow.BR.Y - zoomWindow.TL.Y) < 6) { return; } //tall narrow box
            //end of misclick conditions

            System.Drawing.Point currentPos = new System.Drawing.Point(e.X, e.Y);

            //adjust for the scrollbar positions so that the user zooms where they think they are zooming
            double xr = 1, yr = 1; //also adjust for a possibly streched image
            if (fractalViewerPanel.Width > xResolution) { xr = (double)xResolution / fractalViewerPanel.Width; }
            if (fractalViewerPanel.Height > yResolution) { yr = (double)yResolution / fractalViewerPanel.Height; }
            p1.X = (int)((zoomPoint1.X + view.X) * xr);
            p1.Y = (int)((zoomPoint1.Y + view.Y) * yr);
            p2.X = (int)((e.X + view.X) * xr);
            p2.Y = (int)((e.Y + view.Y) * yr);
            zoomWindow = new Window(p1, p2);

            //make a copy of the picture for the history
            int[,] temp = new int[picture.GetLength(0), picture.GetLength(1)];
            for (int x = 0; x < picture.GetLength(0) - 1; x++)
            { for (int y = 0; y < picture.GetLength(1) - 1; y++)
                { temp[x, y] = picture[x, y]; } }

            if (history.Count - 1 < zoomIndex) { history.Add(temp); }
            else { history[zoomIndex] = temp; }
            f.zoom(zoomWindow);
            doFractal();
            zoomIndex++;
            zoomIndexLabel.Text = "Zoom Level: " + zoomIndex;
            zoomIndexLabel.Visible = true;
            previousZoom.Visible = true;
        }

        protected void colorApply_Click(object sender, EventArgs e)
        {
            TextBox[] txtRGB = { txtColorR, txtColorG, txtColorB };
            for (int c = 0; c < 3; c++)
            {
                if (txtRGB[c].Text.Length > 0) { int.TryParse(txtRGB[c].Text, out colorChoice[c]); }
                else { colorChoice[c] = 0; } //a blank textbox is treated as zero
                if (colorChoice[c] <= 0) { colorChoice[c] = 0; txtRGB[c].Text = "0"; }
                if (colorChoice[c] > 100) { colorChoice[c] = 100; txtRGB[c].Text = "100"; }
            }

            if (colorChoice[0] == 0 && colorChoice[1] == 0 && colorChoice[2] == 0)
            {
                string messageText = "All three colors can't be zero";
                string messageCaption = "Error";
                MessageBox.Show(messageText, messageCaption);
                return;
            }

            FractalEngine.setColorMod(colorCalc(colorChoice));
            FractalEngine.render(minimap, minimatrix);
            render();
            repaintMinimap();
        }

        protected void previousZoom_Click(object sender, EventArgs e)
        {
            zoomIndex--;
            f.unzoom(zoomIndex);
            picture = history[zoomIndex];
            xResolution = picture.GetLength(0); //getlength returns the number of elements
            yResolution = picture.GetLength(1);
            resXBox.Text = xResolution.ToString();
            resYBox.Text = yResolution.ToString();
            f.setResolution(xResolution, yResolution);
            txtDetailLevel.Text = f.getDetailLevel().ToString();
            fractalViewerPanel.AutoScrollPosition = new System.Drawing.Point(0, 0);
            view.X = 0; view.Y = 0;

            zoomIndexLabel.Text = "Zoom Level: " + zoomIndex;

            if (zoomIndex < 1)
            {
                previousZoom.Visible = false;
                zoomIndexLabel.Visible = false;
            }
            else if (zoomIndex >= 1)
            {
                zoomIndexLabel.Visible = true;
                previousZoom.Visible = true;
            }
            adjustScrollBars();
            render();
        }

        protected void cbMandelTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            zoomIndex = 0;
            previousZoom.Visible = false;
            zoomIndexLabel.Visible = false;
            zoomIndexLabel.Text = "Zoom Level: " + zoomIndex;
            //the indices of the combo box must exactly match the indices of the fractalType enumerations declared in the factory
            FractalFactory.fractalType type = (FractalFactory.fractalType)cbMandelTypes.SelectedIndex;
            f = FractalFactory.create(type, xResolution, yResolution, fco, true);
            f.Completed += new Fractal.CompletedEventHandler(render);
            txtDetailLevel.Text = f.getDetailLevel().ToString();
            doFractal();
            miniFrac = FractalFactory.create(type, zoomDisplayBox.Width, zoomDisplayBox.Height, fco, false);
            miniFrac.calculate();
            minimatrix = miniFrac.getMatrix();
            FractalEngine.render(minimap, minimatrix);
            repaintMinimap();
        }

        private void zoomDisplayBox_Paint(object sender, PaintEventArgs e)
        {
            repaintMinimap();
        }

        #endregion //FormAndControlEvents

        #region VirtualEvents

        protected override void btnPortal_Click(object sender, EventArgs e)
        {
            base.btnPortal_Click(sender, e);
        }

        protected override void btnQuit_Click(object sender, EventArgs e)
        {
            base.btnQuit_Click(sender, e);
        }

        protected override void desktopImageButton_Click(object sender, EventArgs e)
        {
            base.desktopImageButton_Click(sender, e);
        }

        protected override void stopButton_Click(object sender, EventArgs e)
        {
            base.stopButton_Click(sender, e);
            miniFrac.cancel();
        }

        protected override void saveButton_Click(object sender, EventArgs e)
        {
            base.saveButton_Click(sender, e);
        }

        protected void applyDetail_Click(object sender, EventArgs e)
        {
            base.applyDetail_Click(sender,e,txtDetailLevel);
        }

        protected void resolutionButton_Click(object sender, EventArgs e)
        {
            base.resolutionButton_Click(sender, e, resXBox, resYBox);
        }

        #endregion VirtualEvents

        #region HelperFunctions

        protected override void repaintMinimap()
        {
            Graphics g = zoomDisplayBox.CreateGraphics();
            g.DrawImage(minimap, 0, 0);
            if (zoomIndex > 0)
            {
                f.getZoomWindow(zoomDisplayBox.Width, zoomDisplayBox.Height,ref zoomBox);
                Pen pen = new Pen(Color.White, 1);

                if (zoomBox.findDist() > 10)
                {
                    int w = zoomBox.BR.X - zoomBox.TL.X;
                    int h = zoomBox.BR.Y - zoomBox.TL.Y;
                    g.DrawRectangle(pen, zoomBox.TL.X, zoomBox.TL.Y, w, h);
                }
                else
                {
                    pen.Width = 2;
                    int x = (zoomBox.TL.X + zoomBox.BR.X) / 2;
                    int y = (zoomBox.TL.Y + zoomBox.BR.Y) / 2;
                    g.DrawLine(pen, x - 3, y - 3, x + 3, y + 3);
                    g.DrawLine(pen, x - 3, y + 3, x + 3, y - 3);
                }
                pen.Dispose();
            }
        }

        protected override void formToggle(bool state)
        {
            applyDetail.Enabled = state;
            //colorApply.Enabled = state;
            previousZoom.Enabled = state;
            //desktopImageButton.Enabled = state;
            resolutionButton.Enabled = state;
            cbMandelTypes.Enabled = state;
            //menuStrip1.Enabled = state;
            //btnPortal.Enabled = state;
            //btnQuit.Enabled = state;
        }

        #endregion //HelperFunctions
    }// end Class MandelGUI
}// end namespace FractalViewer
