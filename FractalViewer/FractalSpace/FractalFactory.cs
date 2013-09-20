using FractalViewer.Exceptions;
using FractalViewer.FractalSpace;

namespace FractalViewer
{
    static class FractalFactory
    {
        public enum fractalType
        {
            Mandelbrot = 0,
            Mandelbrot3 = 1,
            Mandelbrot4 = 2,
            Julia = 3,
            Julia3 = 4,
            Julia_SanMarco = 5,
            //Buddhabrot = 6,
            Sierpinski = 7,
            MapleLeaf = 8,
            Fern = 9,
            FernPlant = 10,
            Tree = 11,
            Dragon = 12,
            Spiral = 13
        };

        public static Fractal create(fractalType type, int width, int height, FormControlObserver observer)
        {
            Fractal newFrac = null;
            switch (type)
            {
                case fractalType.Sierpinski:
                    {
                        newFrac = new Sierpinski(width, height, observer);
                        break;
                    }
                case fractalType.MapleLeaf:
                    {
                        newFrac = new MapleLeaf(width, height, observer);
                        break;
                    }
                case fractalType.Fern:
                    {
                        newFrac = new Fern(width, height, observer);
                        break;
                    }
                case fractalType.FernPlant:
                    {
                        newFrac = new FernPlant(width, height, observer);
                        break;
                    }
                case fractalType.Tree:
                    {
                        newFrac = new Tree(width, height, observer);
                        break;
                    }
                case fractalType.Dragon:
                    {
                        newFrac = new Dragon(width, height, observer);
                        break;
                    }
                case fractalType.Spiral:
                    {
                        newFrac = new Spiral(width, height, observer);
                        break;
                    }
                default:
                    {
                        throw new FractalException("Invalid Fractal type requested");
                    }
            }
            return newFrac;
        }

        public static Fractal create(fractalType type, int width, int height, FormControlObserver observer, bool statusbar)
        {
            Fractal newFrac = null;
            switch (type)
            {
                case fractalType.Mandelbrot:
                    {
                        newFrac = new Mandelbrot(width, height, observer, statusbar);
                        break;
                    }
                case fractalType.Mandelbrot3:
                    {
                        newFrac = new Mandelbrot3(width, height, observer, statusbar);
                        break;
                    }
                case fractalType.Mandelbrot4:
                    {
                        newFrac = new Mandelbrot4(width, height, observer, statusbar);
                        break;
                    }
                case fractalType.Julia:
                    {
                        newFrac = new Julia(width, height, observer, statusbar);
                        break;
                    }
                case fractalType.Julia3:
                    {
                        newFrac = new Julia3(width, height, observer, statusbar);
                        break;
                    }
                case fractalType.Julia_SanMarco:
                    {
                        newFrac = new Julia_SanMarco(width, height, observer, statusbar);
                        break;
                    }
                default:
                    {
                        throw new FractalException("Invalid Fractal type requested");
                    }
            }
            return newFrac;
        }
    }
}
