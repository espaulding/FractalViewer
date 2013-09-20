using FractalViewer;
using FractalViewer.FractalSpace;
using FractalViewer.Exceptions;
using System.Windows.Forms;
using System;

namespace FractalViewer.WhiteboxScripts
{
    static class TestMandelbrot
    {
        static bool completed = false;

        static void constructorTests(Mandelbrot m)
        {
            Console.WriteLine(" ** Constructor Tests (100,100,fco,true) **");
            
            //check constructed resolution
            int[,] matrix = m.getMatrix();

            if (matrix.GetLength(0) == 100) 
              { Console.WriteLine("PASS : Width = 100"); }
            else                            
              { Console.WriteLine("FAIL : Width != 100"); }

            if (matrix.GetLength(1) == 100) 
              { Console.WriteLine("PASS : Height = 100"); }
            else                            
              { Console.WriteLine("FAIL : Height != 100"); }

            //check constructed detail level
            if (m.getDetailLevel() == 100)
              { Console.WriteLine("PASS : Default detail level = 100"); }
            else
              { Console.WriteLine("FAIL : Default detail level != 100"); }

            Console.WriteLine("");
        }

        static void zoomTests(Mandelbrot m)
        {
            Window zoomLoc = new Window(new Point(0, 0), new Point(1, 1));
            Console.WriteLine(" ** Zooming Tests **");
            if (m.getZoomDepth() == 0)
              { Console.WriteLine("PASS : zoom depth = 0"); }
            else
              { Console.WriteLine("FAIL : zoom depth != 0"); }

            m.getZoomWindow(100, 100, ref zoomLoc);

            if (zoomLoc.TL.X == 0 && zoomLoc.TL.Y == 0 && zoomLoc.BR.X == 99 && zoomLoc.BR.Y == 99)
              { Console.WriteLine("PASS : correct initial window location"); }
            else
              { Console.WriteLine("FAIL : incorrect initial window location"); }

            Console.WriteLine("\n  * Zoom into bottom right quadrant *");
            m.zoom(new Window(new Point(48, 49), new Point(99, 99)));

            if (m.getZoomDepth() == 1)
              { Console.WriteLine("PASS : zoom depth = 1"); }
            else
              { Console.WriteLine("FAIL : zoom depth != 1"); }

            m.getZoomWindow(100, 100, ref zoomLoc);

            if (zoomLoc.TL.X == 48 && zoomLoc.TL.Y == 49 && zoomLoc.BR.X == 99 && zoomLoc.BR.Y == 99)
              { Console.WriteLine("PASS : correct zoom window location"); }
            else
              { Console.WriteLine("FAIL : incorrect zoom window location"); }

            m.unzoom(0);
            Console.WriteLine("\n  * undo the zoom *");

            if (m.getZoomDepth() == 0)
            { Console.WriteLine("PASS : zoom depth = 0"); }
            else
            { Console.WriteLine("FAIL : zoom depth != 0"); }

            m.getZoomWindow(100, 100, ref zoomLoc);

            if (zoomLoc.TL.X == 0 && zoomLoc.TL.Y == 0 && zoomLoc.BR.X == 99 && zoomLoc.BR.Y == 99)
            { Console.WriteLine("PASS : correct window location"); }
            else
            { Console.WriteLine("FAIL : incorrect window location"); }

            Console.WriteLine("\n  * Zoom into top right quadrant *");
            m.zoom(new Window(new Point(99, 49), new Point(48, 0)));

            if (m.getZoomDepth() == 1)
            { Console.WriteLine("PASS : zoom depth = 1"); }
            else
            { Console.WriteLine("FAIL : zoom depth != 1"); }

            m.getZoomWindow(100, 100, ref zoomLoc);

            if (zoomLoc.TL.X == 48 && zoomLoc.TL.Y == 0 && zoomLoc.BR.X == 99 && zoomLoc.BR.Y == 49)
            { Console.WriteLine("PASS : correct zoom window location"); }
            else
            { Console.WriteLine("FAIL : incorrect zoom window location"); }

            Console.WriteLine("");
        }

        static void settingsTests(Mandelbrot m)
        {
            Console.WriteLine("** Change Settings Tests **");

            m.setDetailLevel(200);

            if (m.getDetailLevel() == 200)
              { Console.WriteLine("PASS : detail level changed to 200"); }
            else
              { Console.WriteLine("FAIL : detail level not changed to 200"); }

            m.setResolution(500, 700);
            int[,] matrix = m.getMatrix();

            if (matrix.GetLength(0) == 500)
            { Console.WriteLine("PASS : X resolution changed to 500"); }
            else
            { Console.WriteLine("FAIL : X resolution not changed to 500"); }

            if (matrix.GetLength(1) == 700)
            { Console.WriteLine("PASS : Y resolution changed to 700"); }
            else
            { Console.WriteLine("FAIL : Y resolution not changed to 700"); }

            Console.WriteLine("");
        }

        static void calculationsTests(Mandelbrot m, ProgressBar p)
        {
            m.setResolution(100, 100);
            Console.WriteLine(" ** Calculation Tests **");
            Console.WriteLine("  * Fractal with a status bar *");
            if (m.isFinished())
              { Console.WriteLine("PASS : the fractal is not calculating"); }
            else
              { Console.WriteLine("FAIL : the fractal's calculation state is wrong"); }

            if (p.Value == 0)
              { Console.WriteLine("PASS : the progress bar is at zero percent"); }
            else
              { Console.WriteLine("FAIL : the progress bar is not at zero percent"); }

            m.beginCalc();

            if (!m.isFinished())
              { Console.WriteLine("PASS : the fractal is calculating"); }
            else
              { Console.WriteLine("FAIL : the fractal's calculation state is wrong"); }

            m.calculate();
            int[,] matrix = m.getMatrix();

            if (completed)
              { Console.WriteLine("PASS : the fractal complete event was raised"); }
            else
              { Console.WriteLine("FAIL : the fractal complete event was not raised"); }

            if (p.Value == 100)
              { Console.WriteLine("PASS : the progress bar is at 100 percent"); }
            else
              { Console.WriteLine("FAIL : the progress bar is not at 100 percent"); }

            if (m.isFinished())
              { Console.WriteLine("PASS : the fractal is not calculating"); }
            else
              { Console.WriteLine("FAIL : the fractal's calculation state is wrong"); }

            Console.WriteLine("\n  * Fractal without a status bar *");
            ProgressBar nobar = new ProgressBar();
            FormControlObserver fco = new FormControlObserver(p, new Button(), new Button());
            Mandelbrot mnostatus = new Mandelbrot(100, 100, fco, false);
            mnostatus.Completed += new Fractal.CompletedEventHandler(fractalCompletedEventTest);
            completed = false;

            if (mnostatus.isFinished())
              { Console.WriteLine("PASS : the fractal is not calculating"); }
            else
              { Console.WriteLine("FAIL : the fractal's calculation state is wrong"); }

            if (nobar.Value == 0)
              { Console.WriteLine("PASS : the progress bar is at zero percent"); }
            else
              { Console.WriteLine("FAIL : the progress bar is not at zero percent"); }

            mnostatus.beginCalc();

            if (!mnostatus.isFinished())
              { Console.WriteLine("PASS : the fractal is calculating"); }
            else
              { Console.WriteLine("FAIL : the fractal's calculation state is wrong"); }

            mnostatus.calculate();
            matrix = mnostatus.getMatrix();

            if (completed)
              { Console.WriteLine("PASS : the fractal complete event was raised"); }
            else
              { Console.WriteLine("FAIL : the fractal complete event was not raised"); }

            if (nobar.Value == 0)
              { Console.WriteLine("PASS : the progress bar is at zero percent"); }
            else
              { Console.WriteLine("FAIL : the progress bar is not at zero percent"); }

            if (mnostatus.isFinished())
              { Console.WriteLine("PASS : the fractal is not calculating"); }
            else
              { Console.WriteLine("FAIL : the fractal's calculation state is wrong"); }

            Console.WriteLine("");
        }

        public static void fractalCompletedEventTest()
        {
            //Console.WriteLine("\n *** Fractal Completed Event was raised *** \n");
            completed = true;
        }

        public static void mandelbrotMain()
        {
            Console.WriteLine("*** Testing Mandelbrot.cs ***");
            ProgressBar p = new ProgressBar();
            FormControlObserver fco = new FormControlObserver(p, new Button(), new Button());
            Mandelbrot mwithstatus = new Mandelbrot(100, 100, fco, true);
            mwithstatus.Completed += new Fractal.CompletedEventHandler(fractalCompletedEventTest);
            constructorTests(mwithstatus);
            zoomTests(mwithstatus);
            settingsTests(mwithstatus);
            calculationsTests(mwithstatus,p);       
        } //end Main
    }
}
