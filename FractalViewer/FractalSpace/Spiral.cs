using System;

namespace FractalViewer.FractalSpace
{
    class Spiral : IFS
    {
        private double[,] cf = new double[,] {{  0.787879, -0.424242,  0.242424,  0.859848,  1.758647,  1.408065 },
                                              { -0.121212,  0.257576,  0.151515,  0.053030, -6.721654,  1.377236 },
                                              {  0.181818, -0.136364,  0.090909,  0.181818,  6.086107,  1.568035 }};
        private double[] weights = new double[] { .9, .05, .05 };

        public Spiral(int newWidth, int newHeight, FormControlObserver observer)
            : base(newWidth, newHeight, observer)
        {
            niterations = 100;
        }

        //See IFS.cs for explanation of Iteration Function Systems
        public override void calculate()
        {
            fco.toggleStopButton(true);
            fco.toggleStatusbar(true);
            fco.togglePortalButton(false);
            done = false;
            completion = 0;
            int cpoints = 0;
            int citer;
            double nx, ny, p;
            int tx, ty;
            int trans = 0;
            clearMatrix();
            Random r = new Random();

            while (!done && cpoints < detailLevel)
            {
                newpoint();
                citer = 0;

                //TODO : add a block here for pausing

                while (!done && citer < niterations)
                {
                    p = r.NextDouble();

                    for (int counter = 0; counter < weights.Length; counter++)
                    {
                        if (p < weights[counter])
                        {
                            trans = counter;
                            break;
                        }
                        else
                        {
                            p -= weights[counter];
                        }
                    }

                    //move along x axis
                    nx = cf[trans, 0] * x + cf[trans, 1] * y + cf[trans, 4];
                    ny = cf[trans, 2] * x + cf[trans, 3] * y + cf[trans, 5];
                    x = nx;
                    y = ny;
                    citer++;
                }

                //plot the point
                tx = (int)(x / 18 * width) + (width / 2);
                ty = (int)(y / 18 * height) + (height);
                ty = ty * -1 + (int)(1.9 * height);

                if (tx > 0 && tx < width)
                {
                    if (ty > 0 && ty < height)
                    {
                        pic[tx, ty] = trans + 2;
                    }
                }

                //update status bar
                //this should update roughly every 1%
                if (cpoints % ((double)detailLevel / 100) == 0)
                {
                    completion = (int)((double)cpoints / (detailLevel / 100));
                    fco.updateStatusbar(completion);
                }
                cpoints++;
            }
            done = true;
            fco.toggleStopButton(false);
            fco.toggleStatusbar(false);
            fco.togglePortalButton(true);
            OnComplete();
        }
    }
}
