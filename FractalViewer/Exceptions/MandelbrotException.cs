using System;

namespace FractalViewer.Exceptions
{
    [Serializable]
    public class MandelbrotException : Exception
    {

        //---------------------------------Constructor-----------------------------------
        //Description: create an Exception with an error message.
        //-------------------------------------------------------------------------------
        public MandelbrotException(string error)
            : base(error)
        {
        }

        //---------------------------------Constructor-----------------------------------
        //Description: create an Exception with no extra information.
        //-------------------------------------------------------------------------------
        public MandelbrotException()
            : base()
        {
        }
    }
}
