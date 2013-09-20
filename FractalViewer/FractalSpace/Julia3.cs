using FractalViewer.Common;

namespace FractalViewer.FractalSpace
{
    class Julia3 : Mandelbrot
    {
        public Julia3(int newWidth, int newHeight, FormControlObserver sbo, bool statusbar)
            : base(newWidth, newHeight, sbo, statusbar)
        {
            //default julia3 window is assigned here
            start = new ComplexWindow(new Complex(-1.05d, 1.15d), new Complex(1.25d, -1.15d));
            cWindow = new ComplexWindow(new Complex(-1.05d, 1.15d), new Complex(1.25d, -1.15d));
        }

        //see Mandelbrot.cs for iterate comment
        protected override int iterate(int x, int y)
        {
            int iterations = 0;
            Complex origin = new Complex(-.5, -.05);
            Complex spot = complexConvert(x, y);
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


