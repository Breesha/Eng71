using System;
using System.Collections.Generic;

namespace SafariPark
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person cathy = new Person("cathy", "French");
            //cathy.Age = 20;
            ////Console.WriteLine(cathy.GetFullName());
            //Console.WriteLine(cathy.Age);
            //cathy.Age = -1;
            //Console.WriteLine(cathy.Age);
            ////  it will still be 20 because of if statement in Person.cs

            //Person nish;
            //nish = new Person("Nish", "Mandal") { Age = 30 };
            //Console.WriteLine(nish.GetFullName());

            //var spartan = new Spartan("Nish", "Mandal");
            //// need to pass in the values cant just have new Spartan
            //Console.WriteLine(spartan.FirstName);

            // () are optional here so can get rid of them if initializing it
            //var list = new ShoppingList() { Bread = 2, Potato = 3 };
            //list.Lemon = 5;
            //var list2 = new ShoppingList();
            ////GET
            //list2.Milk = 5;
            ////SET
            //var milkAmount = list2.Milk;

            //Person jino = new Person("Jino", "Bimpa") { Age = 20 };
            //Point3D pt3D = new Point3D(5, 8, 2);
            //DemoMethod(pt3D, jino);

            //Hunter lauren = new Hunter("Lauren", "Pang", "Leica") { Age = 20 };

            //Console.WriteLine(lauren.Age);
            //Console.WriteLine(lauren.Shoot());
            //Console.WriteLine(lauren.GetFullName());

            //Hunter h = new Hunter();
            //Console.WriteLine(h.Shoot());

            //var kam = new Hunter("Kam", "Sohal", "Nikon") { Age = 25 };
            //Console.WriteLine($"Kam Equals Lauren?{kam.Equals(lauren)}");
            //Console.WriteLine($"Kam HasCode: {kam.GetHashCode()}");
            //Console.WriteLine($"Kam type: {kam.GetType()}");
            //Console.WriteLine($"Kam ToString: {kam.ToString()}");


            //Airplane a = new Airplane(200, 100, "JetsRUs")
            //{ NumPassengers = 150 };
            //a.Ascend(500);
            //Console.WriteLine(a.Move(3));
            //Console.WriteLine(a);
            //a.Descend(200);
            //Console.WriteLine(a.Move());
            //a.Move();
            //Console.WriteLine(a);

            //var nish = new Hunter("Nish", "Mandal") { Age = 30 };

            //var gameObject = new List<object>()
            //{
            //    new Person ("Cathy", "French"),
            //    new Airplane (400,200,"Sparta Air"),
            //    nish,
            //    new Vehicle(12,20)
            //};

            //foreach (var gameObj in gameObject)
            //{
            //    Console.WriteLine(gameObj.ToString());
            //}

            //// this didnt wwork ignore it
            //var cathy = new Person("Cathy", "French");
            //var hunterCathy = cathy as Hunter;
            //SpartaWrite(hunterCathy);

            //var IMovableObject = new List<IMovable>
            //{
            //    new Vehicle(),
            //    new Person(),
            //    new Hunter()
            //};

            //foreach (var IMovableObj in IMovableObject)
            //{
            //    Console.WriteLine(IMovableObj.Move() );
            //}

            //var weaponList = new List<Weapon>
            //{
                
            //    new LaserGun("Acme"),
            //    new WaterPistol("Supersoaker")
            //};

            //foreach (var weaponObj in weaponList)
            //{
            //    Console.WriteLine(weaponObj.Shoot());
            //}

            var iShootList = new List<IShootable>
            {
                new Camera("Pentax"),
                new Hunter("Nish","Mandal", new Camera ("Pentax")),
                new WaterPistol("Supersoaker"),
                new LaserGun("Acme")



            };

            foreach (var iShootObj in iShootList)
            {
                Console.WriteLine(iShootObj.Shoot());
            }

        }

        //static void SpartaWrite(object obj)
        //{
        //    Console.WriteLine(obj.ToString());
        //    if(obj is Hunter)
        //    {
        //        var hunter = (Hunter)obj;
        //        Console.WriteLine(hunter.Shoot());
        //    }

        //}

        //static void DemoMethod(Point3D pt, Person p)
        //{
        //    pt.y = 1000;
        //    p.Age = 92;
        //}
    }
}
