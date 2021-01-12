using System;
using System.Threading;
using System.Threading.Tasks;

namespace AysncCake
{
    class Program
    {
        //// ASYNC METHOD
        //public async static Task Main(string[] args)
        //{
        //    Console.WriteLine("Welcome to my birthday party");
        //    await HaveAPartyAsync();
        //    Console.WriteLine("Thanks for a lovely party");
        //    //Console.ReadLine();
        //}

        //// EASIER METHOD
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my birthday party");
            HaveAParty();
            Console.WriteLine("Thanks for a lovely party");
            //Console.ReadLine();
        }

        //private async static Task HaveAPartyAsync()
        //{
        //    var name = "Cathy";
        //    var cakeTask = BakeCakeAsync();
        //    PlayPartyGames();
        //    OpenPresents();
        //    var cake = await cakeTask;
        //    Console.WriteLine($"Happy birthday, {name}, {cake}!!");
        //}

        private  static void HaveAParty()
        {
            var name = "Cathy";
            var cakeTask = BakeCakeAsync();
            PlayPartyGames();
            OpenPresents();
            var cake = cakeTask.Result;
            Console.WriteLine($"Happy birthday, {name}, {cake}!!");
        }

        private async static Task<Cake> BakeCakeAsync()
        {
            Console.WriteLine("Cake is in the oven");
            //Thread.Sleep(TimeSpan.FromSeconds(5));
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("Cake is done");
            return new Cake();
        }

        private static void PlayPartyGames()
        {
            Console.WriteLine("Starting games");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Finishing Games");
        }

        private static void OpenPresents()
        {
            Console.WriteLine("Opening Presents");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine("Finished Opening Presents");
        }

        private async static Task<Goodybag> GoodyBagsAsync()
        {
            Console.WriteLine("Giving out goodbags");
            await Task.Delay(TimeSpan.FromSeconds(3));
            Console.WriteLine("Given goodbags");
            return new Goodybag;

        }
    }

    public class Cake
    {
        public override string ToString()
        {
            return "Here's a cake";
        }
    }
}
