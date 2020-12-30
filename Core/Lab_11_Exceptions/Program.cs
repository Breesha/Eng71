using System;
using System.IO;

namespace Lab_11_Exceptions
{
    public class Program
    {

        private static string[] _theBeatles = new string[] { "John", "Paul", "George", "Ringo" };

        public static void ChangeBeatles(int pos, string name)
        {

            if (pos < 0 || pos >= _theBeatles.Length)
            {
                throw new ArgumentException($"Another Beatle cannot be added");
            }
            _theBeatles[pos] = name;
        }

        static void Main(string[] args)
        {

            //checked
            //{
            //    int three = 3;
            //    int max = int.MaxValue;
            //    Console.WriteLine(max + three);
            //}

            //try
            //{
            //    ChangeBeatles(4, "Brain");
            //}
            //catch(ArgumentException ex)
            //{
            //    Console.WriteLine("Exception thrown:" + ex.Message);
            //}
            //try
            //{
            //    _theBeatles[4] = "Brain";
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("Sorry no 5th Beatle allowed");
            //}


            //int x = 10;
            //int y = 1;
            //try
            //{
            //    int output = x / y;
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("An exception has occured");
            //}
            //finally
            //{
            //    Console.WriteLine("But life goes on");
            //}

            ////Hierachy
            //try
            //{
            //    File.OpenRead("tryEx.txt");
            //}
            //catch(DirectoryNotFoundException ex)
            //{
            //    Console.WriteLine("could not find tryEx.txt Directory");
            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine("could not find tryEx.txt file");
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine("Problem writing file");
            //}

            //try
            ////{
            //    _theBeatles[4] = "Brain";
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("1. sorry no 5th Beatle");
            //    Console.WriteLine($"2. {ex.ToString()};");
            //    Console.WriteLine($"3. {ex.Message};");
            //    Console.WriteLine($"4. {ex.Data};");
            //}


        }
    }
}