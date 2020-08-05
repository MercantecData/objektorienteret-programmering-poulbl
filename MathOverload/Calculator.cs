using System;

namespace MathOverload
{
    public class Calculator
    {
        /*******************************************
         * ADD
         ********************************************/
        public int Add(int a, int b)
        {
            return a + b;
        }

        public float Add(float a, float b)
        {
            return a + b;
        }

        public int Add(string a, string b)
        {
            int x, y;
            if(Int32.TryParse(a, out x) && Int32.TryParse(b, out y))
            {
                return x + y;
            }
            else
            {
                throw new FormatException("One of the parameters is not a whole number.");
            }
        }


        /*******************************************
         * SUBTRACT
         ********************************************/
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public float Subtract(float a, float b)
        {
            return a - b;
        }
        public int Subtract(string a, string b)
        {
            int x, y;
            if (Int32.TryParse(a, out x) && Int32.TryParse(b, out y))
            {
                return x - y;
            }
            else
            {
                throw new FormatException("One of the parameters is not a whole number.");
            }
        }

        /*******************************************
         * MULTIPLY
         ********************************************/
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public float Multiply(float a, float b)
        {
            return a * b;
        }
        public int Multiply(string a, string b)
        {
            int x, y;
            if (Int32.TryParse(a, out x) && Int32.TryParse(b, out y))
            {
                return x * y;
            }
            else
            {
                throw new FormatException("One of the parameters is not a whole number.");
            }
        }

        /*******************************************
         * DIVIDE
         ********************************************/
        public int Divide(int a, int b)
        {
            return a / b;
        }

        public float Divide(float a, float b)
        {
            return a / b;
        }
        public int Divide(string a, string b)
        {
            int x, y;
            if (Int32.TryParse(a, out x) && Int32.TryParse(b, out y))
            {
                return x / y;
            }
            else
            {
                throw new FormatException("One of the parameters is not a whole number.");
            }
        }

        /*******************************************
         * SQUARE
         ********************************************/
        public double Square(int a)
        {
            return Math.Sqrt(a);
        }

        public double Square(float a)
        {
            return Math.Sqrt(a);
        }
        public double Square(string a)
        {
            int x;
            if (Int32.TryParse(a, out x))
            {
                return Math.Sqrt(x);
            }
            else
            {
                throw new FormatException("One of the parameters is not a whole number.");
            }
        }
    }
}
