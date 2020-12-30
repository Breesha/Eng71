using System;
using System.ComponentModel;
using System.Diagnostics.SymbolStore;
using System.Runtime.Versioning;

namespace Calculator
{
    public class CalculatorMethod
    {
        

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            else
            {
                return a / b;
            }
        }

        public static double Modulus(double a, double b)
        {
            return a % b;
        }


    }
}