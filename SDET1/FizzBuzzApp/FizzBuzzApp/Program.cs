using System;

namespace FizzBuzzExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int max = 50;

            for (int i = 0; i <= max ; i++)
            {
                Console.WriteLine($"{FizzBuzz(i)}");
            }
        }

        public static string FizzBuzz(int n)
        {
            string result = "";
            if (n%3==0)
            {
                result= "Fizz";
            }
            if (n%5==0)
            {
                result += "Buzz";
            }
            if (result==string.Empty)
            {
                result = n.ToString();
            }
            return result;
        }
    }
}
