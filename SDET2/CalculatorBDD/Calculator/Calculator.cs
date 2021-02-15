using System;
using System.Collections.Generic;

namespace CalculatorProject
{
    public class Calculator
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public List<int> NumList { get; set; }

        public int Add()
        {
            return Num1 + Num2;
        }

        public int Subtract()
        {
            return Num1 - Num2;
        }

        public int Multiply()
        {
            return Num1 * Num2;
        }

        public int IterateThrough()
        {
            int num=0;
            int count = 0;
            for (int i = 0; i < NumList.Count; i++)
            {
                num = NumList[i];
                if (num%2==0)
                {
                    count += num;
                }
            }
            return count;
        }
    }
}
