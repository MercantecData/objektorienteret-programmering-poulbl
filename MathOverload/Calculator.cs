using System;
using System.Reflection;

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

        public dynamic Add(dynamic a, dynamic b)
        {
            if (a is string)
            {
                if (b is string)
                {
                    try
                    {
                        Int32.TryParse(a, out int x);
                        Int32.TryParse(b, out int y);
                        return x + y;
                    }
                    catch(FormatException e)
                    {
                        throw e;
                    }
                }
                else
                {
                    Type typeB = b.GetType();
                    if(typeB.Name == "int")
                    {
                        Int32.TryParse(b, out int x);
                        return a + x;
                    }
                    else
                    {
                        a = Convert.ToDouble(a);
                        return a + b;
                    }
                }
            }
            if (b is string)
            {
                Type typeA = a.GetType();
                if (typeA.Name == "int")
                {
                    Int32.TryParse(a, out int x);
                    return b + x;
                }
                else
                {
                    b = Convert.ToDouble(b);
                    return a + b;
                }
            }
            if ((a is int || a is float || a is double || a is decimal) && (b is int || b is float || b is double || b is decimal))
            {
                b = Convert.ChangeType(b, a.GetType());
                return a + b;
            }

            return a + b;
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
