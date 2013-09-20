
namespace FractalViewer.FractalSpace
{
    //IFS stands for Iteration Function System
    //A starting figure is used and then the system uses several geometric transformations
    //to transform the original figure into smaller and smaller versions of itself

    //This program uses the random point method for IFS image generation
    //which transforms the original image by applying a randomly choosen transformation
    //to the figure's corners.

    //the transformations are based rotation, dilation, x movement, and y movement
    //which are stored in a matrix with the columns being the above and the rows
    //being different transformations
    abstract class IFS : Fractal
    {
        protected int niterations;
        protected double x,y;
       
        public IFS(int newWidth, int newHeight, FormControlObserver observer)
        {
            fco = observer;
            setResolution(newWidth, newHeight);
            newpoint();
            detailLevel = 50000;
        }

        protected void newpoint()
        {
            x = 0;
            y = 0;
        }
    }
}
