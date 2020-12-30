using System;
using System.Diagnostics;

namespace Lab_10_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //var d = new DateTime();
            //var d1 = DateTime.Today;
            var d2 = DateTime.Now;
            var d3 = new DateTime(1989, 11, 2, 6, 30, 0);

            var nishage = d2 - d3;
            var nishAgeYears = (int)(nishage.Days / 365.25);
            Console.WriteLine(nishAgeYears);

            //var output = d2.ToString("dd/MM/yyyy");
            //// MM means /11/ but MMM means /Nov/ and MMMM means November
            //// dd = 16 and dddd = Monday

            //var timespan = new TimeSpan(14, 1, 0, 0);
            //var d4 = new DateTime(1989, 11, 2, 6, 30, 0);
            //var date = d4 + timespan;
            //var date2 = DateTime.Now + timespan;

            //var s = new Stopwatch();
            //s.Start();
            //int total = 0;
            //for( int i = 0; i<1000; i++)
            //{
            //    total += 1;
            //}
            //s.Stop();
            //Console.WriteLine(s.Elapsed);
            //Console.WriteLine(s.ElapsedMilliseconds);
            //Console.WriteLine(s.ElapsedTicks);


            //Suit theSuit = Suit.HEARTS;
            //var c = (int)'c';
            //var theSuitInt = (int)theSuit;

            //char t = (Char)1;
            //Suit theSuit2 = (Suit)3;

            //string theSuit3 = ((Suit)0).ToString();

            //Suits(theSuit2);

            //var monday = (DayOfWeek)1;
            //Console.WriteLine(monday);

            //int dog; //0
            //float cat; // 0 float or 0f
            //char x; //
            //DateTime aDate; // 01/01/0001 00.00.00
            //string aString;
            //bool thing; // false
            //int[] array; // null

            //int sparta; // default val = 0
            //int? global; // default val = null
            ////Nullable<int> global;

            //bool? hasPassed = true;
            //if(hasPassed.HasValue)
            //{
            //    Console.WriteLine($"hasPassed has a value of {hasPassed}");
            //}
            //else
            //{
            //    Console.WriteLine($"hasPassed is null");
            //}

            //int totalCost = 0;
            //int price = 1;
            //int? items = null;
            //if( items.HasValue)
            //{
            //    totalCost = items.Value * price;
            //}
            //Console.WriteLine(items.HasValue);
            //Console.WriteLine(totalCost);

            //int? nullableScore = null;
            //int score = nullableScore ?? -9999;
            //int score1 = nullableScore.GetValueOrDefault(-1);
            //int score2 = nullableScore.GetValueOrDefault();
            // different ways to set value of nullableScore

            //const int dozen = 12;
            //dozen = 13;
            // doesn't work but take away const to change it

            //dynamis look at notepad

            //var rng = new Random();
            //var rngSeeded = new Random(42);
            //var between1And10 = rngSeeded.Next(1, 11);
            //Console.WriteLine(between1And10);
            //// everyone gets 7 even though its random because of the seeding
            //// seeding has an order

            //var rollTheDice = new Random();

            //var dice1 = rollTheDice.Next(7);
            //var dice2 = rollTheDice.Next(7);
            //var dice3 = rollTheDice.Next(7);
            //Console.WriteLine($"{dice1} {dice2} {dice3}, {dice1 + dice2 + dice3}");

        }

        public static void Suits(Suit suit)
        {
            switch(suit)
            {
                case (Suit.HEARTS):
                    Console.WriteLine("You have stolen it");
                    break;
                case (Suit.CLUBS):
                    Console.WriteLine("Club foot");
                    break;
                case (Suit.DIAMONDS):
                    Console.WriteLine("Best friend");
                    break;
                case (Suit.SPADES):
                    Console.WriteLine("Shovel?");
                    break;
            }
        }

        public enum Suit
        {
            HEARTS, CLUBS, DIAMONDS, SPADES
        }
    }
}
