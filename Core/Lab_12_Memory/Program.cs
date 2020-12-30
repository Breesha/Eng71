using System;

namespace Lab_12_Memory
{
    class Program
    {
        static void Main(string[] args)
        {
            var intArray = new int[] { 1, 2, 3, 4 };
            Example(intArray);
        }

        public static void Example(int[] arr)
        {
            arr[0] = 12;
        }
    }
}
