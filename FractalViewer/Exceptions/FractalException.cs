using System;

namespace FractalViewer.Exceptions
{
    [Serializable]
    public class FractalException : Exception
    {

        //---------------------------------Constructor-----------------------------------
        //Description: create an Exception with an error message.
        //-------------------------------------------------------------------------------
        public FractalException(string error)
            : base(error)
        {
        }

        //---------------------------------Constructor-----------------------------------
        //Description: create an Exception with no extra information.
        //-------------------------------------------------------------------------------
        public FractalException()
            : base()
        {
        }
    }
}
