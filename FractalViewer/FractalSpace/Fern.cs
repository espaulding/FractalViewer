using System;

namespace FractalViewer.FractalSpace
{
    class Fern : IFS
    {
        private double[,] cf = new double[,] {{ 0   ,  0   ,  0   , 0.16,  0   ,  0.01 },
                                              { 0.85,  0.04, -0.04, 0.85,  0   ,  1.6  },
                                              { 0.2 , -0.26,  0.23, 0.22,  0   ,  1.6  },
                                              {-0.15,  0.28,  0.26, 0.24,  0   ,  0.44 }};
        private double[] weights = new double[] { .01, .85, .07, .07 };

        public Fern(int newWidth, int newHeight, FormControlObserver observer)
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
            completion = 0;
            done = false;
            int cpoints = 0;
            int citer;
            double nx, ny, p;
            int tx, ty;
            int trans = 0;
            clearMatrix();
            Random r = new Random();

            while (!done && cpoints < detailLevel)
            {
                //TODO : add a block here for pausing
                newpoint();
                citer = 0;
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
                tx = (int)(x / 13 * width) + (width / 2);
                ty = (int)(y / 13 * height) + (height);
                ty = ty * -1 + 2*height;

                if (tx > 0 && tx < width)
                {
                    if (ty > 0 && ty < height)
                    {
                        pic[tx, ty] = trans + 1;
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
