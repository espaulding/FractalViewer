using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FractalViewer
{
    public partial class SierpinskiGUI : GUI
    {
        //background data globals
        protected Color[] colorChoice = new Color[] { Color.Green, Color.Blue, Color.Red };
        protected bool newPoints = false;
        protected int pointCount = 3;
        protected Point[] npoints;

        public SierpinskiGUI(FractalPortal p) : base(p)
        {
            InitializeComponent();
        }

        #region FormAndControlEvents

        protected void SierpinskiGUI_Load(object sender, EventArgs e)
        {
            fractalViewerPanel.MouseDown += new MouseEventHandler(fractalViewerPanel_MouseDown);
            fractalViewerPanel.Width = 600;
            maxDetailLevel = 1000000;

            color1Box.BackColor = colorChoice[0];
            color2Box.BackColor = colorChoice[1];
            color3Box.BackColor = colorChoice[2];
            xResolution = fractalViewerPanel.Width;
            yResolution = fractalViewerPanel.Height;
            buffer = new Bitmap(xResolution, yResolution);
            view = new Rectangle(0, 0, xResolution, yResolution);
            resXBox.Text = xResolution.ToString();
            resYBox.Text = yResolution.ToString();

            //map the colorChoice array into an into array for the engine
            List<int> temp = new List<int>();
            for (int c = 0; c < colorChoice.Length; c++)
            { temp.Add(colorToInt(colorChoice[c])); }
            FractalEngine.setColorMod(temp.ToArray());

            fco = new FormControlObserver(fractalStatus, btnStop, btnPortal);
            fractalStatus.Visible = false;

            f = FractalFactory.create(FractalFactory.fractalType.Sierpinski, xResolution, yResolution, fco);
            f.Completed += new Fractal.CompletedEventHandler(render);
            f.setDetailLevel(100000);
            txtDetailLevel.Text = f.getDetailLevel().ToString();
            doFractal();
        }

        protected void fractalViewerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            //check for point entry mode
            //if there are less than 3 points so far add this point to the array
            if (newPoints)
            {
                Graphics g = fractalViewerPanel.CreateGraphics();
                Pen pen = new Pen(Color.White, 2);
                int x = e.X + view.X; //adjust for the scrollbar positions
                int y = e.Y + view.Y;
                g.DrawLine(pen, e.X - 3, e.Y - 3, e.X + 3, e.Y + 3);
                g.DrawLine(pen, e.X - 3, e.Y + 3, e.X + 3, e.Y - 3);
                pen.Dispose();
                double xr = 1, yr = 1; //adjust for a possibly streched image
                if (fractalViewerPanel.Width > xResolution) { xr = (double)xResolution / fractalViewerPanel.Width; }
                if (fractalViewerPanel.Height > yResolution) { yr = (double)yResolution / fractalViewerPanel.Height; }
                npoints[pointCount] = new Point((int)(x * xr), (int)(y * yr));
                pointCount++;
                if (pointCount == 3)
                {
                    btnChoosePoints.Enabled = true;
                    newPoints = false;
                    f.setPoints(npoints);
                    doFractal();
                    render();
                }
            }
        }

        protected void btnChoosePoints_Click(object sender, EventArgs e)
        {
            newPoints = true;
            pointCount = 0;
            btnChoosePoints.Enabled = false;
            //set the picture to a black background
            for (int x = 0; x < picture.GetLength(0); x++)
            {
                for (int y = 0; y < picture.GetLength(1); y++)
                {
                    picture[x, y] = 0;
                }
            }
            npoints = new Point[3] {new Point(0,0),
                                           new Point(0,0),
                                           new Point(0,0)};
            render();
        }

        protected void colorBox_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            ColorDialog colorChooser = new ColorDialog();
            if (colorChooser.ShowDialog() == DialogResult.OK)
            {
                p.BackColor = colorChooser.Color;
                //naming scheme is color#box
                //ascii for '1' == 49, so '1' - 49 sets 1 to the zero index of the array
                colorChoice[p.Name[5] - 49] = colorChooser.Color;
            }
            colorChooser.Dispose();
        }

        protected void colorApply_Click(object sender, EventArgs e)
        {
            List<int> temp = new List<int>();
            for (int c = 0; c < colorChoice.Length; c++)
            {
                temp.Add(colorToInt(colorChoice[c]));
            }
            FractalEngine.setColorMod(temp.ToArray());
            render();
        }

        #endregion FormAndControlEvents

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
        }

        protected override void saveButton_Click(object sender, EventArgs e)
        {
            base.saveButton_Click(sender, e);
        }

        protected void applyDetail_Click(object sender, EventArgs e)
        {
            base.applyDetail_Click(sender, e, txtDetailLevel);
        }

        protected void resolutionButton_Click(object sender, EventArgs e)
        {
            base.resolutionButton_Click(sender, e, resXBox, resYBox);
        }

        #endregion VirtualEvents

        #region HelperFunctions

        protected override void formToggle(bool state)
        {
            btnDetailLevel.Enabled = state;
            //colorApply.Enabled = state;
            //desktopImageButton.Enabled = state;
            resolutionButton.Enabled = state;
            //menuStrip1.Enabled = state;
            btnPortal.Enabled = state;
            //btnQuit.Enabled = state;
        }

        #endregion HelperFunctions
    }// end Class SierpinskiGUI
}// end namespace FractalViewer

