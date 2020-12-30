using System;

namespace Lab_07_Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 100; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            int[] myArray = { 10, 20, 30 };

            //for (int i = 0; i <= myArray.Length - 1; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}
            //// or
            //for(int i = myArray.Length-1; i<+0; i--)
            //{
            //    Console.WriteLine(myArray[i]);
            //}

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }

            // while loops
            //    int counter = 0;

            //while (counter < 10)
            //{
            //    Console.WriteLine(counter * 10);
            //    counter++;
            //}

            ////do while loops
            //do
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}
            //while (counter<=10);

            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{

            //    sum += i;
            //}
            //Console.WriteLine(sum);

            ////this makes it lower case and then prints the letters individually
            //string upper = "NISH IS KING";
            //string lower = upper.ToLower();
            //foreach (var item in lower)
            //{
            //    Console.WriteLine(item);
            //}

            ////break statement
            //for (int i=0; i<10;i++)
            //{
            //    Console.WriteLine(i);
            //    if (i==5)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("break");

            //int counter = 0;

            //while (counter<10)
            //{
            //    counter++;
            //    Console.WriteLine(counter);
            //    //if the counter is less than 4, then at this point, just restart the loop
            //    if (counter < 4) continue;
            //    // if less than 4 if doesn't reach this far goes back to start of while loop
            //    Console.WriteLine(counter*4);
            //    //if over 4, run loop and then back to the top of while if still under 10
            //}


            //for (int i = 1; i < 21; i++)
            //{
            //    Console.WriteLine(i);

            //    if (i % 15 == 0)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("break");
        }

    }
}
