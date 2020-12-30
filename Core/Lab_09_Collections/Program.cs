using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_09_Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            //var integers = new List<int> { 2, 4, 6, 8, 10 };
            //foreach (var item in integers)
            //{
            //    Console.WriteLine(item);
            //}

            //    integers.Add(5);
            //    integers.Add(7);
            //    integers.Add(9);

            //    integers[2] = 4;
            //    integers.Reverse();
            //    integers.RemoveAt(3);

            //    integers.ForEach(x => Console.WriteLine(x));
            //    integers.Sort();
            //    Console.WriteLine();

            var myQueue = new Queue<string> { };
            myQueue.Enqueue("Nish");
            myQueue.Enqueue("Arjun");
            myQueue.Enqueue("Mandal");
            //foreach (var item in myQueue)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //Console.WriteLine(myQueue.Peek());
            Console.WriteLine(myQueue.Dequeue());
            //foreach (var x in myQueue)
            //{
            //    Console.WriteLine($"{x}");
            //}


            //var chairs = new Stack<string> { };
            //chairs.Push("Nish");
            //chairs.Push("Arjun");
            //chairs.Push("Mandal");
            //Console.WriteLine(chairs.Pop());
            //Console.WriteLine(chairs.Peek());

            //Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            //myDictionary.Add(1, "Paula Kedra");
            //myDictionary.Add(2, "David Harvey");
            //myDictionary.Add(3, "Lee Boot");
            //myDictionary.Add(3, "Nish Mandal");
            //// No Nish because 3 has already been allocated, foreach cw

            //var dictionary2020 = new Dictionary<char, string> { { 'c', "cat" }, { 'b', "bear" } };
            //var p = dictionary2020['c'];
            //// Allocated the var p with the value from dictionary

            //foreach (var item in dictionary2020)
            //{
            //    // code change Console.WriteLine($"Index/Key is {key} and value is {dictionary2020{key}}");
            //    Console.WriteLine($"Index/Key is {item.Key} and value is {item.Value}");
            //}

            //string input = "There is always only one truth!";
            //input.Trim().ToLower();
            //var countDict = new Dictionary<char, int>();
            // for each value of the input (firstly T) it will check if it has already been counted
            //and then add to the count. If it is new it will create a count for it then mve onto
            //the next letter.
            //foreach (char c in input)
            //{
            //    if(countDict.ContainsKey(c))
            //    {
            //        countDict
            //    }
            //    else
            //}

        }


    }
}
