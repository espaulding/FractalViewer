using FractalViewer.Common;

namespace FractalViewer.FractalSpace
{
    class Mandelbrot3 : Mandelbrot
    {
        public Mandelbrot3(int newWidth, int newHeight, FormControlObserver sbo, bool statusbar)
            : base (newWidth,newHeight,sbo, statusbar)
        {
            //default Mandelbrot3 window is assigned here
            start = new ComplexWindow(new Complex(-1.2d, 1.3d), new Complex(1.2d, -1.3d));
            cWindow = new ComplexWindow(new Complex(-1.2d, 1.3d), new Complex(1.2d, -1.3d));
        }

        //see Mandelbrot.cs for iterate comment
        protected override int iterate(int x, int y)
        {
            int iterations = 0;
            Complex origin = complexConvert(x, y);
            Complex spot = origin;
            double currentDist = 0;

            while ((currentDist <= escapeDist) && (++iterations <= detailLevel))
            {
                spot = spot.power(3).add(origin);
                currentDist = findDist(origin, spot);
            }

            if (iterations >= detailLevel)
            {
                return ((int)(100 / currentDist));
                //return 0;
            }
            return iterations;
        }
    }
}
