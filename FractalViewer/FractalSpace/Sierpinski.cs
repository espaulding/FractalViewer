using System;

namespace FractalViewer.FractalSpace
{
    class Sierpinski : Fractal
    {
        protected Point[] points = new Point[] {};

        public Sierpinski(int newWidth, int newHeight,FormControlObserver observer)
        {
            this.fco = observer;
            detailLevel = 100000;
            setResolution(newWidth, newHeight);
            defaultPoints();
        }

        //in addition to reseting the resolution also rescale the previous
        //sierpinski points to fit the new resolution
        public override void setResolution(int x, int y)
        {
            int oldX = width;
            int oldY = height;
            if (oldX == 0) { oldX = x; }
            if (oldY == 0) { oldY = y; }
            width = x;
            height = y;
            for (int c = 0; c < points.Length; c++)
            {
                points[c].X = (int)((double)points[c].X / oldX * x);
                points[c].Y = (int)((double)points[c].Y / oldY * y);
            }
            pic = null;
            pic = new int[width, height];
        }

        private void defaultPoints()
        {
            Point[] p = new Point[3] { new Point(width / 2, 0), new Point(0, height), new Point(width, height) };
            setPoints(p);
        }

        public override void setPoints(Point[] npoints)
        {
            points = npoints;
        }

        public override void calculate()
        {
            fco.toggleStopButton(true);
            fco.toggleStatusbar(true);
            clearMatrix();
            done = false;
            completion = 0;
            int c = 0;
            int color;
            Random r = new Random();
            Point p = points[0];

            while (!done && c < detailLevel)
            {
                //pick a point at random and move halfway towards it from the current point
                color = r.Next(1, points.Length + 1);
                p = findMidPoint(p,points[color-1]);
                pic[p.X, p.Y] = color;

                //this should update roughly every 1%
                if (c % ((double)detailLevel / 100) == 0)
                {
                    completion = (int)((double)c / ((double)detailLevel / 100));
                    fco.updateStatusbar(completion);
                }
                c++;
            }
            
            done = true;
            fco.toggleStatusbar(false);
            fco.toggleStopButton(false);
            OnComplete();
        }

        protected Point findMidPoint(Point p1, Point p2)
        {
            return new Point((p1.X+p2.X)/2, (p1.Y+p2.Y)/2);
        }
    }
}
