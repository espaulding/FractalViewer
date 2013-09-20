using System;
using System.Collections.Generic;
using System.Drawing;

namespace FractalViewer
{
    static class FractalEngine
    {

        private static List<int> colorMod = new List<int>();
        private static int currentX = 0, currentY = 0;
        private static int xStep = 1, yStep = 1;
        private static int width, height;

        static public void setStep(int x, int y)
        {
            //enforce a minimum step to avoid infinite loop when rendering
            if (x < 1) { x = 1; } 
            if (y < 1) { y = 1; }
            if (x > 10) { x = 10; }
            if (y > 10) { y = 10; }
            xStep = x;
            yStep = y;
        }

        static public void setColorMod(int ncolorMod)
        {
            if (ncolorMod < 0)
            {
                ncolorMod = 0;
            }
            colorMod.Clear();
            colorMod.Add(ncolorMod);
        }

        static public void setColorMod(int[] ncolorMods)
        { 
            colorMod.Clear();
            for (int c = 0; c < ncolorMods.Length; c++)
            {
                colorMod.Add(ncolorMods[c]);
                if (ncolorMods[c] < 0)
                {
                    //any color that is invalid becomes green
                    ncolorMods[c] = 30 * 256;
                }
            }
        }

        /**
	    * This method takes the previously calculated fractal matrix and
        * the color modifiers to color the bitmap 1 pixel at a time
	    */
        static public void render(Bitmap bmp, int[,] pic)
        {
            currentX = 0;
            currentY = -1 * yStep; // -1; otherwise the top left pixel will be skipped
            width = pic.GetLength(0);
            height = pic.GetLength(1);
            if (pic != null && bmp != null)
            {
                //multiple colorMods are meant for use with Sierpinski
                //a single colorMod is meant to bring out the small details of the Mandlebrot
                if (colorMod.Count == 1)
                {
                    renderOneColormod(bmp, pic);
                }
                else
                {
                    renderManyColormods(bmp, pic);
                }
            }
        }

        static private void renderManyColormods(Bitmap bmp, int[,] pic)
        {
            Graphics g = Graphics.FromImage(bmp);
            SolidBrush painter = new SolidBrush(Color.Black);
            int[] pixel = new int[] { 0, 0, 0 }; //paint a black background
            while (nextPoint())
            {
                if (pic[currentX, currentY] == 0)
                {
                    pixel[0] = 0; pixel[1] = 0; pixel[2] = 0;
                }
                else
                {
                    //Modulus the pic[x,y] in case this happens to be used with a fractal other than Sierpinski
                    convertToRGB(colorMod[(pic[currentX, currentY] - 1) % colorMod.Count], ref pixel);
                }   

                painter.Color = Color.FromArgb(255, pixel[0], pixel[1], pixel[2]);
                g.FillRectangle(painter, currentX, currentY, 1, 1);
            }
            painter.Dispose();
        }

        static private void renderOneColormod(Bitmap bmp, int[,] pic)
        {
            Graphics g = Graphics.FromImage(bmp);
            SolidBrush painter = new SolidBrush(Color.Black);
            int[] pixel = new int[] { 0, 0, 0 };
            int[] brush = new int[] { 0, 0, 0 };
            convertToRGB(colorMod[0], ref pixel);
            while (nextPoint())
            {
                brush[0] = pixel[0] * pic[currentX, currentY];
                brush[1] = pixel[1] * pic[currentX, currentY];
                brush[2] = pixel[2] * pic[currentX, currentY];

                //adjust the shades of red, green, and blue so that they never overflow
                for (int x = 0; x < 3; x++)
                {
                    if (brush[x] > 255) { brush[x] %= 255; }
                    if (brush[x] < 1) { brush[x] = 1; }
                }
                painter.Color = Color.FromArgb(255, brush[0], brush[1], brush[2]);
                g.FillRectangle(painter, currentX, currentY, 1, 1);
            }
            painter.Dispose();
        }

        /**
        * This method converts a raw integer into three separate parts,
        * which correspond with the red, green, and blue parts of a windows color
        * The result is an array of three integers between 0 and 255 red,green,blue
        */
        static private void convertToRGB(int color, ref int[] RGB)
        {
            RGB[0] = color / (int)Math.Pow(256, 2);
            RGB[1] = (color - (RGB[0] * 256 * 256)) / 256;
            RGB[2] = color - (RGB[0] * 256 * 256) - (RGB[1] * 256);
        }

        /**
        * This method gets the next Cartesian point 
        * that needs to be iterated. returns true
        * when the last point is reached
        */
        static private bool nextPoint()
        {
            currentY += yStep;
            if (currentY >= height)
            {
                currentY = 0;
                currentX += xStep;
                if (currentX >= width)
                {
                    currentX = 0;
                    return false;
                }// end x boundary check
            }// end y boundary check
            return true;
        }
    }
}
