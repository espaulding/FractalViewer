using FractalViewer.Common;

namespace FractalViewer.FractalSpace
{
    class Mandelbrot4 : Mandelbrot
    {
        public Mandelbrot4(int newWidth, int newHeight, FormControlObserver sbo, bool statusbar)
            : base(newWidth, newHeight, sbo, statusbar)
        {
            //default Mandelbrot4 window is assigned here
            start = new ComplexWindow(new Complex(-1.4d, 1.3d), new Complex(1.0d, -1.25d));
            cWindow = new ComplexWindow(new Complex(-1.4d, 1.3d), new Complex(1.0d, -1.25d));
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
                spot = spot.power(4).add(origin);
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
