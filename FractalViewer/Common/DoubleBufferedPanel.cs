using System.Windows.Forms;
using System.Drawing;

namespace FractalViewer.Common
{
    class DoubleBufferedPanel : Panel
    {   
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //Color c = Color.FromArgb((int)(255), this.BackColor);
            //e.Graphics.FillRectangle(new SolidBrush(c), this.ClientRectangle);
            base.OnPaint(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //Dont paint here
            foreach (Control c in this.Controls)
            {
                c.Refresh();
            }
        }
    }
}
