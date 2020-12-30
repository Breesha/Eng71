using System;
using System.Net.Mail;

namespace Lab_05_Selection
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(PassFail(93));
            Console.WriteLine(Grade(64));

            //int day = 4;
            //switch (day);
            //{
            //    case 1:
            //        Console.WriteLine("Monday);
            //        break;
            //    case 2:

            //}

            //Console.WriteLine(Priority(3));
            //Console.WriteLine(PassFailTernary(39));
            
        }

        //public static string PassFailTernary(int mark)
        //{
        //    return mark >= 40 ? "Pass" : "Fail";
        //}

        //public static string Priority(int level)
        //{
        //    string priority = "Code";
        //    switch (level)
        //    {
        //        case 3:
        //            priority += " Red";
        //            break;
        //        case 2:
        //        case 1:
        //            priority += " Amber";
        //            break;
        //        case 0:
        //            priority += " Green";
        //            break;
        //        default:
        //            priority = "Error";
        //            break;
        //    }
        //    return priority;
        //}

        public static string Grade(int mark)
        {
            //var grade = "";
            string grade;

            if (mark >= 40)
            {
                grade = "Pass";

                if (mark >= 75)
                {
                    grade += " with Distinction";
                }
                else if (mark >= 60)
                {
                    grade += " with Merit";
                }
            }
            else
            {
                grade = "Fail";
            }
            return grade;
        }

        //public static string PassFail(int mark)
        //{
        //    var grade = "Fail";

        //    if (mark>=40)
        //    {
        //        grade = "Pass";
        //    }
        //    return grade;
        //}
    }
}
