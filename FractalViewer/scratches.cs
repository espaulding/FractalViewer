using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FractalViewer
{
    class scratches
    {
        public void displayResults()
        {
            //offset used to scan through the list and get the right pictures based on the current page we are on 
            int offSet = page * 20;

            //each block does same thing will only comment one of them!!!!!!!!!!!!!!!!!!!!
            //check to make sure we are still with in the array and picture still exists
            if ((0 + offSet) < list.Count && File.Exists(((PictureClass)list[0 + offSet]).getPath()))
            {
                //add the path to the current page listing
                currentPicturesList[0] = ((PictureClass)list[0 + offSet]).getPath();
                //get the image from the memory and create thumbnail of it
                Bitmap image1 = (Bitmap)Bitmap.FromFile(((PictureClass)list[0 + offSet]).getPath());
                Image newImag1 = image1.GetThumbnailImage(150, 150, new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero);
                //set thumbnail as the image of the picturebox starting from one and moving across then down
                pictureBox1.Image = newImag1;
            }
            else
            {
                //if we are past the array or image does not exist them set image in picturebox to null and path to null
                currentPicturesList[0] = null;
                pictureBox1.Image = null;
            }
        }
    }
}
