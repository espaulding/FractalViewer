using System;

namespace FractalViewer
{
    public class Window
    {
        public Point TL, BR;

        public Window(Point topLeft, Point bottomRight)
        {
            TL = topLeft;
            BR = bottomRight;
        }

        public double findDist()
        {
            return (Math.Sqrt(Math.Pow((BR.X - TL.X), 2) + Math.Pow((BR.Y - TL.Y), 2)));
        }
    }
}
