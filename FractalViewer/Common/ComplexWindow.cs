
namespace FractalViewer.Common
{
    /**
 * 
 * @author Eric Spaulding
 * This Class defines a window on the Complex plane
 * using two Complex numbers one of which is the top
 * left corner and the other is the bottom right corner
 * of the window. The real part is used as X and the imaginary
 * part is used as the Y.
 *
 */
    public class ComplexWindow
    {

        private Complex tlCorner;
        private Complex brCorner;

        public ComplexWindow(Complex tl, Complex br)
        {
            tlCorner = tl;
            brCorner = br;
        }

        public Complex getTL()
        {
            return tlCorner;
        }

        public Complex getBR()
        {
            return brCorner;
        }
    }
}
