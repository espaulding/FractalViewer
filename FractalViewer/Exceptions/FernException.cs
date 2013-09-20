using System;

namespace FractalViewer.Exceptions
{
    [Serializable]
    public class FernException : Exception
    {

        //---------------------------------Constructor-----------------------------------
        //Description: create an Exception with an error message.
        //-------------------------------------------------------------------------------
        public FernException(string error)
            : base(error)
        {
        }

        //---------------------------------Constructor-----------------------------------
        //Description: create an Exception with no extra information.
        //-------------------------------------------------------------------------------
        public FernException()
            : base()
        {
        }
    }
}
