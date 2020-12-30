//using System;
//using CodeFromNorthwindModel;
//using System.Linq;
//using Microsoft.EntityFrameworkCore;

//namespace CodeFromNorthwindBusiness
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            using (var db = new NorthwindContext())
//            {
//                //1.1 Query Syntax
//                var list = db.Customers.ToList();
//                var LondParisCustomerQuery =
//                from c in db.Customers
//                where c.City == "London" || c.City == "Paris"
//                select c;

//                foreach (var item in LondParisCustomerQuery)
//                {
//                    Console.WriteLine($"{item.CompanyName} {item.CustomerId}");
//                }

//                //1.1 Method Syntax
//                var customersInLondonParis = db.Customers.Where(c => c.City == "London" || c.City == "Paris");
//                foreach (var item in customersInLondonParis)
//                {
//                    Console.WriteLine($"{item.CompanyName} {item.CustomerId}");
//                }

//                //1.2 Query Syntax
//                var productsInBottlesQuery =
//                    from p in db.Products
//                    where p.QuantityPerUnit.Contains("bottle")
//                    select p;

//                foreach (var item in productsInBottlesQuery)
//                {
//                    Console.WriteLine(item.ProductName + " " + item.QuantityPerUnit);
//                }

//                //1.2 Method Syntax
//                        var productsInBottles = db.Products.Where(p => p.QuantityPerUnit.Contains("Bottle"));
//                foreach (var item in productsInBottles)
//                {
//                    Console.WriteLine(item.ProductName + " " + item.QuantityPerUnit);
//                }

//                //1.3 Query Syntax
//                var productsInBottlesQuery2 =
//                    from p in db.Products
//                    join s in db.Suppliers on p.SupplierId equals s.SupplierId
//                    where p.QuantityPerUnit.Contains("Bottle")
//                    select new { productName = p.ProductName, supplierName = s.CompanyName, quantityPerUnit = p.QuantityPerUnit };

//                foreach (var item in productsInBottlesQuery2)
//                {
//                    Console.WriteLine($"Product:{item.productName}. Company Name: {item.supplierName}. Quantity per Unit: {item.quantityPerUnit}");
//                }

//                //1.3 Method Query
//                                 var productsInBottles2 = db.Products.Where(p => p.QuantityPerUnit.Contains("Bottle")).Include(s => s.Supplier);
//                foreach (var item in productsInBottles2)
//                {
//                    Console.WriteLine($"{item.ProductId}: {item.ProductName} {item.QuantityPerUnit} Supplier: {item.Supplier.CompanyName}");
//                }

//                //1.4 Query Syntax
//                var productGroupByCategory =
//                     from p in db.Products
//                     join c in db.Categories on p.CategoryId equals c.CategoryId
//                     group p by c.CategoryName into newGroup
//                     select new { Category = newGroup.Key, NumOfProd = newGroup.Count() };

//                foreach (var item in productGroupByCategory)
//                {
//                    Console.WriteLine($"{item.Category} - {item.NumOfProd}");
//                }

//                //1.4 Method Syntax
//                var productGroupByCategory2 =
//                    db.Products.Include(c => c.Category).ToList().GroupBy(C => C.Category.CategoryName);

//                foreach (var item in productGroupByCategory2)
//                {
//                    Console.WriteLine($"{item.Key} - {item.Count()}");
//                }

//                //1.5 Query Syntax
//                var employeesUKQuery =
//                from e in db.Employees
//                where e.Country == "UK"
//                select new { firstName = e.FirstName, lastName = e.LastName, Country = e.Country };

//                foreach (var item in employeesUKQuery)
//                {
//                    Console.WriteLine($"{item.firstName} {item.lastName} - {item.Country}");
//                }

//                //1.5 Method Syntax
//                var employeesUKQuery2 =
//                    db.Employees.Where(e => e.Country == "UK");


//                foreach (var item in employeesUKQuery2)
//                {
//                    Console.WriteLine($"{item.FirstName} {item.LastName} - {item.Country}");
//                }

//                //1.6 Query Syntax
//                var query16a =
//                (from o in db.Orders
//                 where o.Freight > 100 && o.ShipCountry == "USA" || o.ShipCountry == "Uk"
//                 select o).Count();
//                Console.WriteLine(query16a);

//                //1.6 Method
//                var query16b =
//                    db.Orders.Where(x => x.Freight > 100).Where(y => y.ShipCountry.Contains("USA") || y.ShipCountry.Contains("UK")).Count();

//                Console.WriteLine($"No. of Order >100 from US or UK {query16b}");

//                //1.7 Query
//                var query17a =
//                    (from o in db.Orders
//                    join od in db.OrderDetails on o.OrderId equals od.OrderId
//                    orderby o.OrderDetails.Sum(od => (float)od.UnitPrice * od.Quantity * od.Discount) descending
//                    select new { o.OrderId, Discount = o.OrderDetails.Sum(od => (float)od.UnitPrice * od.Quantity * od.Discount) }).First();

//                //1.7 Method
//                var query17b = db.Orders.Include(o => o.OrderDetails).OrderByDescending(o => o.OrderDetails.Sum(od => (float)od.UnitPrice * od.Quantity * od.Discount))
//                .Select(o => new { o.OrderId, Discount = o.OrderDetails.Sum(od => (float)od.UnitPrice * od.Quantity * od.Discount) }).First();


//            }
//        }
//    }
//}
