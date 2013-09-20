using System;

namespace FractalViewer.FractalSpace
{
    class FernPlant : IFS
    {
        private const int N_TRANS = 6;
        private double[,,] cf = new double[,,] {{{ 0   ,  0   ,  0   , 0.16,  0   ,  0.01 },
                                                { 0.85, -0.11, -0.04, 0.75,  0   ,  1.6  },
                                                { 0.2 , -0.26,  0.23, 0.22,  0   ,  1.6  },
                                                {-0.15,  0.28,  0.26, 0.24,  0   ,  0.44 }},
                                               {{ 0   ,  0   ,  0   , 0.16,  0   ,  0.01 },
                                                { 0.85,  0.14, -0.04, 0.85,  0   ,  1.6  },
                                                { 0.2 , -0.26,  0.23, 0.22,  0   ,  1.6  },
                                                {-0.15,  0.28,  0.26, 0.24,  0   ,  0.44 }},
                                               {{ 0   ,  0   ,  0   , 0.16,  0   ,  0.01 },
                                                { 0.85,  0.08, -0.04, 0.85,  0   ,  1.6  },
                                                { 0.2 , -0.26,  0.23, 0.22,  0   ,  1.6  },
                                                {-0.15,  0.28,  0.26, 0.24,  0   ,  0.44 }},
                                               {{ 0   ,  0   ,  0   , 0.16,  0   ,  0.01 },
                                                { 0.85, -0.04, -0.04, 0.85,  0   ,  1.6  },
                                                { 0.2 , -0.26,  0.23, 0.22,  0   ,  1.6  },
                                                {-0.15,  0.28,  0.26, 0.24,  0   ,  0.44 }}};
        private double[] weights = new double[] { .01, .85, .07, .07 };

        public FernPlant(int newWidth, int newHeight, FormControlObserver observer)
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
            int progress = 0;
            clearMatrix();
            Random r = new Random();

            for (int leaf = 0; !done && !(leaf >= cf.GetLength(0)); leaf++)
            {
                cpoints = 0;
                while (!done && cpoints < detailLevel / 4)
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
                        nx = cf[leaf, trans, 0] * x + cf[leaf, trans, 1] * y + cf[leaf, trans, 4];
                        ny = cf[leaf, trans, 2] * x + cf[leaf, trans, 3] * y + cf[leaf, trans, 5];
                        x = nx;
                        y = ny;
                        citer++;
                    }

                    //plot the point
                    tx = (int)(x / 13 * width) + (width / 2);
                    ty = (int)(y / 13 * height) + (height);
                    ty = ty * -1 + 2 * height;

                    if (tx > 0 && tx < width)
                    {
                        if (ty > 0 && ty < height)
                        {
                            switch (leaf)
                            {
                                case 0:
                                    {
                                        pic[tx, ty] = 3;
                                        break;
                                    }
                                case 1:
                                    {
                                        pic[tx, ty] = 4;
                                        break;
                                    }
                                case 2:
                                    {
                                        pic[tx, ty] = 2;
                                        break;
                                    }
                                case 3:
                                    {
                                        pic[tx, ty] = 2;
                                        break;
                                    }
                            }
                        }
                    }

                    //update status bar
                    //this should update roughly every 1%
                    if ((cpoints + progress) % ((double)(detailLevel) / 100) == 0)
                    {
                        completion = (int)((double)(cpoints + progress) / (detailLevel) / 100);
                        fco.updateStatusbar(completion);
                    }
                    cpoints++;
                }
                progress += cpoints;
            }
            done = true;
            fco.toggleStopButton(false);
            fco.toggleStatusbar(false);
            fco.togglePortalButton(true);
            OnComplete();
        }
    }
}
