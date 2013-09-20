using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FractalViewer
{
    public partial class IFSGUI : GUI
    {
        //background data globals
        protected Color[] colorChoice = new Color[] { Color.Brown, Color.LightGreen, Color.DarkGreen, Color.Green };

        public IFSGUI(FractalPortal p) : base(p)
        {
            InitializeComponent();
        }

        #region FormAndControlEvents

        protected void IFSGUI_Load(object sender, EventArgs e)
        {
            fractalViewerPanel.Width = 600;
            maxDetailLevel = 1000000;

            color1Box.BackColor = colorChoice[0];
            color2Box.BackColor = colorChoice[1];
            color3Box.BackColor = colorChoice[2];
            color4Box.BackColor = colorChoice[3];
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
            f = FractalFactory.create(FractalFactory.fractalType.Fern, xResolution, yResolution, fco);
            f.Completed += new Fractal.CompletedEventHandler(render);
            txtDetailLevel.Text = f.getDetailLevel().ToString();

            cbIFSTypes.SelectedIndex = 0; //changing the selected index raises an event which does call doFractal
            //doFractal();
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

        protected void cbIFSTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbIFSTypes.SelectedIndex)
            {
                case 0:
                    {
                        f = FractalFactory.create(FractalFactory.fractalType.Fern, xResolution, yResolution, fco);
                        break;
                    }
                case 1:
                    {
                        f = FractalFactory.create(FractalFactory.fractalType.FernPlant, xResolution, yResolution, fco);
                        break;
                    }
                case 2:
                    {
                        f = FractalFactory.create(FractalFactory.fractalType.MapleLeaf, xResolution, yResolution, fco);
                        break;
                    }
                case 3:
                    {
                        f = FractalFactory.create(FractalFactory.fractalType.Tree, xResolution, yResolution, fco);
                        break;
                    }
                case 4:
                    {
                        f = FractalFactory.create(FractalFactory.fractalType.Dragon, xResolution, yResolution, fco);
                        break;
                    }
                case 5:
                    {
                        f = FractalFactory.create(FractalFactory.fractalType.Spiral, xResolution, yResolution, fco);
                        break;
                    }
            }
            f.Completed += new Fractal.CompletedEventHandler(render);
            txtDetailLevel.Text = f.getDetailLevel().ToString();
            doFractal();
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
            resolutionButton.Enabled = state;
            //menuStrip1.Enabled = state;
            //btnPortal.Enabled = state;
            //btnQuit.Enabled = state;
        }

        #endregion HelperFunctions
    }// end Class IFSGUI
}// end namespace FractalViewer
