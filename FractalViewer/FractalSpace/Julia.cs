﻿using FractalViewer.Common;

namespace FractalViewer.FractalSpace
{
    class Julia : Mandelbrot
    {
        public Julia(int newWidth, int newHeight, FormControlObserver sbo, bool statusbar)
            : base(newWidth, newHeight, sbo, statusbar)
        {
            //default Mandelbrot3 window is assigned here
            start = new ComplexWindow(new Complex(-1.6d, 1.2d), new Complex(1.6d, -1.2d));
            cWindow = new ComplexWindow(new Complex(-1.6d, 1.2d), new Complex(1.6d, -1.2d));
        }

        //see Mandelbrot.cs for iterate comment
        protected override int iterate(int x, int y)
        {
            int iterations = 0;
            Complex origin = new Complex(-.522618123, .686838352031);
            Complex spot = complexConvert(x, y);
            double currentDist = 0;

            while ((currentDist <= escapeDist) && (++iterations <= detailLevel))
            {
                spot = spot.power(2).add(origin);
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


