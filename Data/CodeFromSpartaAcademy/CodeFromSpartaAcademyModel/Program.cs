using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeFromSpartaAcademyModel
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SpartaAcademyContext())
            {

                ////READ
                //foreach (var e in db.Employees)
                //{
                //    Console.WriteLine($"Employee {e.FirstName} {e.LastName} has ID {e.EmployeeId} with employment type {e.EmployeeType}");
                //}

                ////CREATE
                //var newEmployee = new Employee
                //{

                //    FirstName = "Breesha",
                //    LastName = "Foxton",
                //    EmployeeType = "T"
                //};

                //db.Employees.Add(newEmployee);
                //db.SaveChanges();

                ////UPDATE
                //var selectedEmployee = db.Employees.Find(19);
                //selectedEmployee.StartDate = DateTime.Now;
                //db.SaveChanges();


                ////DELETE
                //var selectedEmployee = db.Employees.Find(19);
                ////var selectedEmployee = db.Employees.Where(e => e.EmployeeId == 19).FirstOrDefault();
                //db.Employees.Remove(selectedEmployee);
                //db.SaveChanges();

            }
        }
    }
}
