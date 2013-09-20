using System;

namespace FractalViewer.FractalSpace
{
    class Tree : IFS
    {
        private double[,] cf = new double[,] {{ 0.05,  0.6 ,  0    ,  0     ,  0   ,  0    },
                                              { 0.05, -0.5 ,  0.0  ,  0.0   ,  0   ,  1    },
                                              { 0.6 ,  0.5 ,  0.698,  0.698 ,  0   ,  0.6  },
                                              { 0.5 ,  0.45,  0.349,  0.3492,  0   ,  1.1  },
                                              { 0.5 ,  0.55, -0.524, -0.524 ,  0   ,  1.0  },
                                              { 0.55,  0.4 , -0.698, -0.698 ,  0   ,  0.7  }};

        private double[] weights = new double[] { .02, .02, .34, .19, .19, .24 };

        public Tree(int newWidth, int newHeight, FormControlObserver observer)
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
                    nx = cf[trans, 0] * Math.Cos(cf[trans, 2]) * x - cf[trans, 1] * Math.Sin(cf[trans, 3]) * y + cf[trans, 4];
                    ny = cf[trans, 0] * Math.Sin(cf[trans, 2]) * x + cf[trans, 1] * Math.Cos(cf[trans, 3]) * y + cf[trans, 5];
                    x = nx;
                    y = ny;
                    citer++;
                }

                //plot the point
                tx = (int)(x / 2.5 * width) + (width / 2);
                ty = (int)(y / 2.5 * height) + (height);
                ty = ty * -1 + 2 * height;

                if (tx > 0 && tx < width)
                {
                    if (ty > 0 && ty < height)
                    {
                        switch (trans)
                        {
                            case 0:
                                {
                                    pic[tx, ty] = 1;
                                    break;
                                }
                            case 1:
                                {
                                    pic[tx, ty] = 1;
                                    break;
                                }
                            case 2:
                                {
                                    pic[tx, ty] = 3;
                                    break;
                                }
                            case 3:
                                {
                                    pic[tx, ty] = 2;
                                    break;
                                }
                            case 4:
                                {
                                    pic[tx, ty] = 2;
                                    break;
                                }
                            case 5:
                                {
                                    pic[tx, ty] = 4;
                                    break;
                                }
                        }
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
