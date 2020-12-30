using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeFromNorthwindModel
{
    class Program
    {
        
        public static bool IsEven(int n)
        {
            //static as its outside main and not instantiated to use the method
            return n % 2 == 0;
        }
        static void Main(string[] args)
        {
            //using NorthwindContext in this scope
            //using (var db = new NorthwindContext())
            // {
            //Console.WriteLine(db.ContextId);

            ////Read
            //foreach (var c in db.Customers)
            //{
            //    Console.WriteLine($"Customer {c.ContactName} has ID {c.CustomerId} and lives in {c.City}");
            //}

            //var newCustomer = new Customer
            //{
            //    CustomerId = "MANDA",
            //    ContactName = "Nish Mandal",
            //    CompanyName = "ToysRUs",
            //    City = "Paris"
            //};

            //db.Customers.Add(newCustomer);
            //db.SaveChanges();

            //UPDATE
            //Find customer by primary key
            //var selectCustomer = db.Customers.Find("MAND");
            // OR use First OrdDefault
            //var selectedCustomer = db.Customers.Where(c => c.CustomerId == "MANDA").FirstOrDefault();

            //db.Customers.Remove(selectedCustomer);
            //db.SaveChanges();

            //UPDATE
            //var selectedCustomer = db.Customers.Find("ALFKI");
            //selectedCustomer.City = "Berlin";
            //db.SaveChanges();




            ////USING QUERY SYNTAX
            //int[] myArray = { 1, 2, 3 };
            //var output = (from number in myArray select number);

            //foreach (var item in output)
            //{
            //    Console.WriteLine(item);
            //}

            //using (var db = new NorthwindContext())
            // {
            //    //Using Query Syntax against oout NorthwindContext
            //    //Find Customers from London
            //    var LondCustomerQuery = 
            //            from c in db.Customers
            //            where c.City =="London"
            //            orderby c.ContactName
            //            select c;

            //    foreach (var c in LondCustomerQuery)
            //    {
            //        Console.WriteLine(c);
            //    }

            //var orderQuery =
            //    from order in db.Orders
            //    where order.Freight > 750
            //    select order;

            //foreach (var item in orderQuery)
            //{
            //    Console.WriteLine(item);
            //}


            ////WHERE
            //var londonBerlinQuery1 =
            //    (from c in db.Customers
            //     where c.City == "London" || c.City == "Berlin"
            //     select c).ToList();

            //foreach (var item in londonBerlinQuery1)
            //{
            //    Console.WriteLine(item);
            //}


            ////GROUPBY
            ////GOOD FOR SQL MINI PROJECT
            //var orderProductByUnitsInStockQuery =
            //    from p in db.Products
            //    group p by p.SupplierId into newGroup
            //    select new
            //    {
            //        SupplierID = newGroup.Key,
            //        UnitsOnStock = newGroup.Sum(c => c.UnitsInStock)
            //    };

            //foreach (var item in orderProductByUnitsInStockQuery)
            //{
            //    Console.WriteLine(item);
            //}


            ////OrderBy
            //var orderProductsByUnitPrice =
            //    from p in db.Products
            //    orderby p.UnitPrice descending
            //    select p;

            //foreach (var item in orderProductsByUnitPrice)
            //{
            //    Console.WriteLine($"{item.ProductId} - {item.UnitPrice}");
            //}

            ////CRUD Operations
            ////CREATE
            //var newCustomer = new Customer
            //{
            //    CustomerId = "MANDA",
            //    ContactName = "Nish Mandal",
            //    CompanyName= "Sparta Global"
            //};

            //db.Customers.Add(newCustomer);
            //db.SaveChanges();

            ////UPDATE
            //var selectedCustomer =
            //    from c in db.Customers
            //    where c.CustomerId == "MANDA"
            //    select c;

            //foreach (var item in selectedCustomer)
            //{
            //    item.City = "Paris";
            //}
            //db.SaveChanges();

            ////DELETE
            //var customerToBeDeleted =
            //    from c in db.Customers
            //    where c.CustomerId == "MANDA"
            //    select c;

            //foreach (var item in customerToBeDeleted)
            //{
            //    db.Customers.Remove(item);
            //}

            //db.SaveChanges();




            //LAMBDA EXPRESSIONS AND METHOD SYNTAX
            //BREAKDOWN OF LAMBDA
            //var nums = new List<int> { 3, 7, 1, 2, 8, 3, 0, 4, 5 };
            //int allCount = nums.Count();
            //allcount will equal 9

            //int countEven = 0;
            //foreach (var item in nums)
            //{
            //    if (item % 2 == 0) countEven++;
            //}

            //int countEven = 0;
            //foreach (var n in nums)
            //{
            //    if (IsEven(n)) countEven++;
            //}

            //int evenCount = nums.Count(IsEven);
            ////delegate used so the method is put in the bracket not the link to call method
            //int evenCount = nums.Count(delegate (int n) { return n % 2 == 0; });
            ////we don't use annonymous functions
            ////instead use lambda

            //int evenCount = nums.Count(n => n % 2 == 0);
            //// return type is implicity - boolean
            ///

            //var people = new List<Person>
            //{
            //    new Person {Name = "Cathy",Age = 40},
            //    new Person {Name="Nish", Age = 55},
            //    new Person {Name = "Lee", Age = 20}
            //};

            //var peopleCount = people.Count();
            //var youngPeopleCount2 = people.Count(people => people.Age < 30);
            //var totalAge = people.Sum(p=>p.Age);
            //var olderPeopleTotalAge = people.Sum(p => p.Age >= 30 ? p.Age : 0);


            

            using (var db = new NorthwindContext())
            {
                //Lambda expression and method syntax

                //var customersInBerlinAndLondon = db.Customers.Where(c => c.City == "London" || c.City == "Berlin");

                //foreach (var item in customersInBerlinAndLondon)
                //{
                //    Console.WriteLine(item);
                //}

                ////GroupBy
                //var orderProductsByUnitsInStockQuery =
                //    db.Products.GroupBy(p => p.SupplierId).Select(newGroup => new
                //    {
                //        SupplierId = newGroup.Key,
                //        UnitsOnStock = newGroup.Sum(c => c.UnitsInStock)
                //    });
                //foreach (var item in orderProductsByUnitsInStockQuery)
                //{
                //    Console.WriteLine(item);
                //}

                ////OrderBy
                //var customerOrderedQuery =
                //    db.Products.OrderBy(p => p.QuantityPerUnit).ThenByDescending(c => c.ReorderLevel);

                //foreach (var item in customerOrderedQuery)
                //{
                //    //Console.WriteLine(item);
                //    Console.WriteLine(item.QuantityPerUnit + " " + item.ReorderLevel);
                //}

                ////same in QUery Syntax
                //var customerOrderedQuery2 =
                //    from p in db.Products
                //    orderby p.ReorderLevel
                //    orderby p.QuantityPerUnit
                //    select new { p.QuantityPerUnit, p.ReorderLevel, p.ProductName };

                //foreach (var item in customerOrderedQuery2)
                //{
                //    Console.WriteLine($"{item.ProductName} || {item.QuantityPerUnit} || {item.ReorderLevel} );

                //}



                //////CRUD Operations Method Syntax

                //CREATE
                //var newCustomer = new Customer
                //{
                //    CustomerId = "MANDA",
                //    ContactName = "Nish Mnadal",
                //    CompanyName = "Sparta Global"
                //};
                //db.Customers.Add(newCustomer);
                //db.SaveChanges();

                ////READ
                //db.Customers.ToList().ForEach(c => Console.WriteLine(c));

                ////UPDATE
                //db.Customers.Where(c => c.CustomerId == "MANDA").FirstOrDefault().City = "Berlin";
                //db.SaveChanges();

                ////DELETE
                //var customerToBeDeleted = db.Customers.Where(c => c.CustomerId == "MANDA").FirstOrDefault();
                //db.Customers.Remove(customerToBeDeleted);
                //db.SaveChanges();



                ////LOADING AND JOINING TABLES
                //var orderQueryWithCustomer =
                //    from order in db.Orders.Include(o => o.Customer).ThenInclude(c=>c.CustomerCustomerDemos) // can add more
                //    //joining order and customer together then join customerCustomerDemos
                //    where order.Freight > 750
                //    select order;

                //foreach (var order in orderQueryWithCustomer)
                //{
                //    if(order.Customer !=null)
                //        //Get rid of data with no customers (inner join)
                //    {
                //        Console.WriteLine($"{order.Customer.ContactName} paid {order.Freight} for shipping");
                //    }
                //}

               
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
