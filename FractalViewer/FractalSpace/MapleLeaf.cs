using System;

namespace FractalViewer.FractalSpace
{
    class MapleLeaf : IFS
    {
        private const int N_TRANS = 6;
        private double[,] cf = new double[,] {{ 0.14,  0.01,  0   ,  .51, -0.08, -1.31 },
                                              { 0.43,  0.52, -0.45,  .5 ,  1.49, -0.75 },
                                              { 0.45, -0.49,  0.47,  .47, -1.62, -0.74 },
                                              { 0.49,  0   ,  0   ,  .51,  0.02,  1.62 }};
        private double[] weights = new double[] { .1, .35, .35, .2 };

        public MapleLeaf(int newWidth, int newHeight, FormControlObserver observer)
            : base (newWidth,newHeight, observer)
        {
            niterations = 400;
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
                while (!done && citer < niterations)
                {
                    //TODO : add a block here for pausing
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
                ty = (int)(y / 13 * height) + (height / 2);
                ty = ty * -1 + height;

                if (tx > 0 && tx < width)
                {
                    if (ty > 0 && ty < height)
                    {
                        switch (trans)
                        {
                            case 0:
                                {
                                    pic[tx, ty] = 2;
                                    break;
                                }
                            case 1:
                                {
                                    pic[tx, ty] = 4;
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
