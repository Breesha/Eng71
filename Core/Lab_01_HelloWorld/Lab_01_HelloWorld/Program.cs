using System;
using System.Dynamic;

namespace Lab_01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 100;
            //x += 10;

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //    x += i;
            //}


            Console.WriteLine("Hello, Command Line demo");

            foreach (string item in args)
            {
                Console.WriteLine($"{item} is on ENg 71");
            }
        }
    }
}

// Case convention
// camelCase for variables
// int camelCaseLikeThis = 1;
// string _firstName;
// PascalCaseLikeThis
// example - public class Program; static void Main () {}
// snake_case_often_used_for_sql
// kebab -case-for-html
