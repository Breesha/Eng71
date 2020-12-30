using System;
using System.ComponentModel;
using System.Diagnostics.SymbolStore;
using System.Runtime.Versioning;

namespace Lab_04_Methods_Testing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //DoThis();
            //var output = DoThat();
            //DoThatAgain(10, "Good afternoon all");
            //var output = DoThatAgain(10, "Good afternoon all");
            //var output2 = DoThatAgain(10);
            //OrderPizza(true, true);
            //int a = 10;
            //Add(a);

            //var result = Mansib(10, "Here is a string", out bool isLarge);
            //Console.WriteLine(isLarge);

            //var myTuple = ("Nish", "Mandal", 30);
            //var myTuplea = (fName: "Nish", lName: "Mandal", 30);
            //(string, string, int) myTuple2 = ("sparta", "Global", 13);
            //Console.WriteLine(myTuple);
            //Console.WriteLine(myTuplea);
            //Console.WriteLine(myTuple.Item1);

            //var result = TupleExample(10, "here's a string");
            //Console.WriteLine(result);
            //Console.WriteLine(result.Item2);
            //Console.WriteLine(result.xsquared);

            //var (square, greatThan10) = TupleExample(25, "Hello");
            //Console.WriteLine(greatThan10);

            //Console.WriteLine(Add(1,2));
            //Console.WriteLine(Add(1,2,3));

            //var product = TripleCalc(3, 2, 3, out int sum);
            //Console.WriteLine(product + " : " + sum);
            //Console.WriteLine(TripleCalc(1,2,5));

            var (weeks, days) = DaysAndWeeks(12);
            Console.WriteLine(weeks + " " + days);
        }

        public static (int weeks, int days) DaysAndWeeks(int totalDays)
        {
            var a = totalDays / 7;
            var b = totalDays % 7;
            return (a, b);
        }

        //public static int TripleCalc(int a, int b, int c, out int sum)
        //{
        //    sum = a + b + c;
        //    return a * b * c;
        //}

        //public static (int sum, int product) TripleCalc(int a, int b, int c)
        //{
        //    int sum = (a + b + c);
        //    return (sum, a * b * c);
        //}

        //public static int Add(int x, int y)
        //{
        //    return x + y;
        //}

        //public static int Add(int x, int y, int z)
        //{
        //    return x + y + z;
        //}

        //public static (int xsquared, bool isLarge) TupleExample(int x, string y)
        //{
        //    Console.WriteLine(y);
        //    var z = (x > 10);
        //    return (x * x, z);
        //}

        //public static int Mansib(int x, string y, out bool z)
        //{
        //    Console.WriteLine(y);
        //    z = (x > 10);
        //    return x * x;
        //}

        //static void Add(int number)
        //{
        //    number++;
        //}

        //static void OrderPizza(bool anchovies, bool pineapple, bool mushroom = false)
        //{

        //}

        //public static int DoThatAgain(int x, string y = "Default")
        //{
        //    Console.WriteLine(y);
        //    return x * x;
        //}

        //public static int DoThat()
        //{
        //    Console.WriteLine("I am returning 100");
        //    return 100;
        //}
        //public static void DoThis()
        //{
        //    Console.WriteLine("I am doing something");
        //}
    }
}
