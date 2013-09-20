using System;
using System.Windows.Forms;

namespace FractalViewer
{
    public partial class FractalPortal : Form
    {
        public FractalPortal()
        {
            InitializeComponent();
        }

        private void btnMandel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MandelGUI GUI = new MandelGUI(this);
            GUI.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void quitCallback()
        {
            this.Close();
        }

        public void makeVisible()
        {
            this.Visible = true;
        }

        private void btnSierpinski_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SierpinskiGUI GUI = new SierpinskiGUI(this);
            GUI.Show();
        }

        private void btnJulia_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            IFSGUI GUI = new IFSGUI(this);
            GUI.Show();
        }
    }
}
