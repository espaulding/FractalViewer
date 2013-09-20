using System;

namespace FractalViewer.WhiteboxScripts
{
    class WhiteboxMaster
    {
        //turn on the console in a windows form application
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        [STAThread]
        static void Main()
        {
            AllocConsole();

            //run scripts 
            TestMandelbrot.mandelbrotMain();

            Console.ReadLine(); //pause the console
        }
    }
}
