using System;
using System.Collections.Generic;
using FractalViewer.Common;
using FractalViewer.Exceptions;
using System.Diagnostics;

namespace FractalViewer.FractalSpace
{
    class Mandelbrot : Fractal
    {
        protected int escapeDist = 5;
        protected ComplexWindow start;
        protected ComplexWindow cWindow; //coordinates on the complex plane
        protected int xStep = 1, yStep = 1;
        protected List<ComplexWindow> windowHistory = new List<ComplexWindow>();
        protected List<Point> resolutionHistory = new List<Point>();
        protected List<int> detailHistory = new List<int>();   
        protected bool hasStatus = true;

        public Mandelbrot(int newWidth, int newHeight, FormControlObserver observer, bool statusbar)
        {
            this.fco = observer;
            hasStatus = statusbar;
            setResolution(newWidth, newHeight);
            detailLevel = 100;
            //default Mandelbrot window is assigned here
            start = new ComplexWindow(new Complex(-2.6d, 1.2d), new Complex(1.0d, -1.2d));
            cWindow = new ComplexWindow(new Complex(-2.6d, 1.2d), new Complex(1.0d, -1.2d));
            //Debug.Assert(false,"Mandelbrot Constructor","detail message");
        }

        /**
	    * This method takes a point on the screen
	    * and converts it to a point on the Fractal's window, and it then
        * iterates that point until either the point escapes or max iterations is hit
	    * @return iterations required for the point to escape
	    */
        protected virtual int iterate(int x, int y)
        {
            int iterations = 0;
            Complex origin = complexConvert(x, y);
            Complex spot = origin;
            double currentDist = 0;

            while ((currentDist <= escapeDist) && (++iterations <= detailLevel))
            {
                spot = spot.power(2).add(origin);
                currentDist = findDist(origin, spot);
            }

            if (iterations >= detailLevel)
            {
                return ((int)(100 / currentDist));
                //return 0; //black background
            }
            return iterations;
        }

        public override void calculate()
        {
            //in order to stop the minimap from interfering with the main mandelbrot
            //the hasStatus is used to determine which fractal should actually be hooked
            //up to the form controls like the status bar or other buttons
            if (hasStatus)
            {
                fco.toggleStatusbar(true);
                fco.toggleStopButton(true);
                fco.togglePortalButton(false);
                completion = 0;
            }
            done = false;
            for (int x = 0; !done && !(x >= width); x += xStep)
            {
                for (int y = 0; !done && !(y >= height); y += yStep)
                {
                    //TODO : add a block here for pausing
                    pic[x, y] = iterate(x, y);
                }

                if (hasStatus)
                {
                    //this should update roughly every 3%
                    if (x % (int)((double)(width) / 33) == 0 || x == width - 1)
                    {
                        completion = (int)((double)x / (width - 1) * 100);
                        fco.updateStatusbar(completion);
                    }
                }
            }
            done = true;
            if (hasStatus)
            {
                fco.toggleStopButton(false);
                fco.toggleStatusbar(false);
                fco.togglePortalButton(true);
            }
            OnComplete();
        }

        //used to zoom into the complex plane
        //also remembers previous states so that the user
        //can move backwards or undo a zoom
        public override void zoom(Window zoomSpace)
        {
            if (resolutionHistory.Count - 1 < zoomDepth)
            {
                resolutionHistory.Add(new Point(width, height));
                windowHistory.Add(cWindow);
                detailHistory.Add(detailLevel);
            }
            else
            {
                resolutionHistory[zoomDepth] = new Point(width, height);
                windowHistory[zoomDepth] = cWindow;
                detailHistory[zoomDepth] = detailLevel;
            }
            Complex TL = complexConvert(zoomSpace.TL.X, zoomSpace.TL.Y);
            Complex BR = complexConvert(zoomSpace.BR.X, zoomSpace.BR.Y);
            cWindow = setWindow(TL, BR);
            zoomDepth++;
        }

        //get the requested previous state out of the history
        public override void unzoom(int historyIndex)
        {
            if (historyIndex < 0 || historyIndex > resolutionHistory.Count - 1)
            {
                throw new MandelbrotException("Invalid unzoom index");
            }
            cWindow = windowHistory[historyIndex];
            width = resolutionHistory[historyIndex].X;
            height = resolutionHistory[historyIndex].Y;
            detailLevel = detailHistory[historyIndex];
            zoomDepth = historyIndex;
        }

        protected double findDist(Complex p1, Complex p2)
        {
            return (Math.Sqrt(Math.Pow((p2.r - p1.r), 2) + Math.Pow((p2.i - p1.i), 2)));
        }

        /**
        * This method maps a Cartesian X,Y point onto the
        * corresponding point of the complex window of the Fractal
        * @return a Complex number where the Real Part assumes the X and the Imaginary part assumes the Y
        */
        protected Complex complexConvert(int x, int y)
        {
            double xMagnitude = Math.Abs(cWindow.getTL().r - cWindow.getBR().r);
            double yMagnitude = Math.Abs(cWindow.getTL().i - cWindow.getBR().i);
            double newX = x * xMagnitude / (width - 1) + cWindow.getTL().r;
            double newY = cWindow.getBR().i - y * yMagnitude / (height - 1) + yMagnitude;
            return new Complex(newX, newY);
        }

        //used to put the box on the minimap and show the user
        //their current location on the complex plane
        public override void getZoomWindow(int w, int h, ref Window zoomLocation)
        {
            w--; h--;
            double sx1 = start.getTL().r, sx2 = start.getBR().r;
            double sy1 = start.getTL().i, sy2 = start.getBR().i;
            double cx1 = cWindow.getTL().r, cx2 = cWindow.getBR().r;
            double cy1 = cWindow.getTL().i, cy2 = cWindow.getBR().i;

            double xMagnitude = Math.Abs(sx1 - sx2);
            double yMagnitude = Math.Abs(sy1 - sy2);
            zoomLocation.TL.X = (int)Math.Round(((cx1 - sx1) / xMagnitude * w));
            zoomLocation.BR.X = (int)Math.Round(((cx2 - sx1) / xMagnitude * w));
            zoomLocation.TL.Y = (int)Math.Round(((sy1 - cy1) / yMagnitude * h));
            zoomLocation.BR.Y = (int)Math.Round(((sy1 - cy2) / yMagnitude * h)); 
        }

        //checks the relative positions of the given Top Left and Bottom Right
        //to make sure that the TL is the TL and the BR is the BR
        protected ComplexWindow setWindow(Complex newTL, Complex newBR)
        {
            double left = newTL.r;
            double right = newBR.r;
            double top = newTL.i;
            double bottom = newBR.i;
            if (left > right)
            {
                double temp = left;
                left = right;
                right = temp;
            }
            if (top < bottom)
            {
                double temp = top;
                top = bottom;
                bottom = temp;
            }
            return new ComplexWindow(new Complex(left, top), new Complex(right, bottom));
        }
    }
}
