using System;

namespace DataTypes_Lib
{
    public static class IntegerCalc
    {
        public static int Add(int num1, int num2)
        {
            if (num1 == int.MaxValue || num2 == int.MaxValue)
            {
                throw new OverflowException();
            }
            else if (num1 == int.MinValue || num2 == int.MinValue)
            {
                throw new OverflowException();
            }
            else
            {
                return num1 + num2;
            }
        }

        public static int Subtract(int num1, int num2)
        {
            if (num1 == int.MaxValue || num2 == int.MaxValue)
            {
                throw new OverflowException();
            }
            else if (num1 == int.MinValue || num2 == int.MinValue)
            {
                throw new OverflowException();
            }
            else
            {
                return num1 - num2;
            }
        }

        public static int Multiply(int num1, int num2)
        {
            if (num1 == int.MaxValue || num2 == int.MaxValue)
            {
                throw new OverflowException();
            }
            else if (num1 == int.MinValue || num2 == int.MinValue)
            {
                throw new OverflowException();
            }
            else
            {
                return num1 * num2;
            }
        }

        public static int Divide(int num1, int num2)
        {
            if (num2 !=0)
            {
                return num1 / num2;
            }
            else
            {
                throw new ArgumentException("Can't divide by zero");
            }
        }

        public static int Modulus(int num1, int num2)
        {
            if (num2 != 0)
            {
                return num1 % num2;
            }
            else
            {
                throw new ArgumentException("Can't modulo by zero");
            }
        }
    }
}
