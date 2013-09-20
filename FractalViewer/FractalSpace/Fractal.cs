using FractalViewer.Exceptions;
using System;
//using System.Threading; //pausing may need this

namespace FractalViewer
{

    public abstract class Fractal
    {
        protected static object Lock = new object();
        protected volatile bool isPaused = false;
        protected volatile bool done = true;
        protected int height, width;
        protected int[,] pic;
        protected int completion = 0;
        protected int zoomDepth = 0;
        protected int detailLevel;
        protected volatile FormControlObserver fco;

        public delegate void CompletedEventHandler();
        public event CompletedEventHandler Completed;

        public abstract void calculate();

        public void cancel()
        {
            done = true;
            isPaused = false;
        }

        public void pause()
        {
            isPaused = true;
        }

        public void unpause()
        {
            isPaused = false;
        }

        public bool isFinished()
        {
            return done;
        }

        //this may seem pointless but it is used to synch up multiple threads
        //so that thread racing can be avoided
        public void beginCalc()
        {
            done = false;
        }

        public int[,] getMatrix()
        {
            return pic;
        }

        //a function that is used to wrap the Completed EVENT
        //this function is called when that event needs to be raised
        protected virtual void OnComplete()
        {
            if (Completed != null)
            {
                Completed();
            }
        }

        protected void clearMatrix()
        {
            for (int x = 0; x < pic.GetLength(0); x++)
            {
                for (int y = 0; y < pic.GetLength(1); y++)
                {
                    pic[x, y] = 0;
                }
            }
        }

        public virtual void setPoints(Point[] points)
        {
            throw new FractalException("setPoints is not supported by the current Fractal type");
        }

        public virtual void setResolution(int x, int y)
        {
            width = x;
            height = y;
            pic = null;
            pic = new int[width, height];
        }

        public void setDetailLevel(int newDetailLevel)
        {
            detailLevel = newDetailLevel;
        }

        public int getDetailLevel()
        {
            return detailLevel;
        }

        public virtual void zoom(Window zoomSpace)
        {
            throw new FractalException("zoom is not supported by the current Fractal type");
        }

        public virtual void unzoom(int historyIndex)
        {
            throw new FractalException("unzoom is not supported by the current Fractal type");
        }

        public int getZoomDepth()
        {
            return zoomDepth;
        }

        public virtual void getZoomWindow(int w, int h, ref Window zoomLocation)
        {
            throw new FractalException("getZoomWindow is not supported by the current Fractal type");
        }
    }
}
