using System;

namespace FractalViewer.Common
{
    
    /*
       This Class defines a complex number,
       which has a Real part and Imaginary part
       Complex numbers know how to Add, Multiply
       and test each other for equal value
    */
    public class Complex
    {
        public double r, i;

        public Complex(double R, double I)
        {
            r = R;
            i = I;
        }

        /* 
           This method multiplies the current Complex number
           by another given Complex number and returns the result
         */
        public Complex multiply(Complex RHS)
        {
            double newR =
                  (this.r * RHS.r)
                - (this.i * RHS.i);
            double newI =
                  (this.i * RHS.r)
                + (this.r * RHS.i);

            Complex result = new Complex(newR, newI);
            return result;
        }

        /*
           This method allows a Complex number to be divided by another Complex number.
         */
        public Complex divide(Complex RHS)
        {
            double newR = this.r * RHS.r;
            newR -= this.i * RHS.i;
            newR /= Math.Pow(RHS.r, 2)
                  - Math.Pow(RHS.i, 2);
            double newI = this.i * RHS.r;
            newI -= this.r * RHS.i;
            newI /= Math.Pow(RHS.r, 2)
                  - Math.Pow(RHS.i, 2);
            return new Complex(newR, newI);
        }

        /*
           This method allows a Complex number to be taken to an exponent.
         */
        public Complex power(int power)
        {
            Complex temp = new Complex(r, i);
            Complex start = new Complex(r, i);
            for (int c = 1; c < power; c++)
            {
                temp = temp.multiply(start);
            }
            return temp;
        }

        /*
           This method adds the current Complex number
           by another given Complex number and returns the result
         */
        public Complex add(Complex RHS)
        {
            double newR = (this.r + RHS.r);
            double newI = (this.i + RHS.i);

            Complex result = new Complex(newR, newI);
            return result;
        }

        /**
           This method compares another Complex number to this one
           and if both the real and imaginary parts are equal it returns true
           @return True, if the numbers are equal; otherwise, false.
         */
        public bool equals(Complex compare)
        {
            if (compare != null)
            {
                if (this.r == compare.r && this.i == compare.i)
                {
                    return true;
                }
            }
            return false;
        }

        /*
           This method outputs the values of a Complex number 
           as (RPart,IPart)
         */
        public String toString()
        {
            return "(" + this.r + "," + this.i + ")";
        }
    }
}
