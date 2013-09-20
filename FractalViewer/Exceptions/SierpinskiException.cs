using System;

namespace FractalViewer.Exceptions
{
    [Serializable]
    public class SierpinskiException : Exception
    {

        //---------------------------------Constructor-----------------------------------
        //Description: create an Exception with an error message.
        //-------------------------------------------------------------------------------
        public SierpinskiException(string error)
            : base(error)
        {
        }

        //---------------------------------Constructor-----------------------------------
        //Description: create an Exception with no extra information.
        //-------------------------------------------------------------------------------
        public SierpinskiException()
            : base()
        {
        }
    }
}
