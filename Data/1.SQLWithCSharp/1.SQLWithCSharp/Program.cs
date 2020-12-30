using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace _1.SQLWithCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new List<Customer>();
            using (var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                connection.Open();
                Console.WriteLine(connection.State);

                //READ+
                using (var command = new SqlCommand("select * from customers", connection))
                {
                    SqlDataReader sqlReader = command.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        //create variables for customer
                        var customerID = sqlReader["CustomerID"].ToString();
                        var contactName = sqlReader["ContactName"].ToString();
                        var companyName = sqlReader["CompanyName"].ToString();
                        var city = sqlReader["City"].ToString();
                        var contactTitle = sqlReader["ContactTitle"].ToString();

                        //new customer object
                        var customer = new Customer { CustoemrID = customerID, ContactName = contactName, CompanyName = companyName, City = city, ContactTitle = contactTitle };

                        customers.Add(customer);
                    }
                    foreach (var c in customers)
                    {
                        Console.WriteLine(c.GetFullName());
                    }


                    //Comment out the above
                    //Create and Insert
                    var newCustomer = new Customer
                    {
                        CustomerID = "MANDA",
                        ContactName = "Nish Mandal",
                        City = "Birmingham",
                        CompanyName = "Sparta Global"
                    };
                    string sqlString = $"INSERT INTO CUSTOMERS(CustomerID, ContactName, City) VALUES ('{newCustomer.CustomerID}','{newCustomer.ContactName}','{newCustomer.City}',{newCustomer.CompanyName}')";
                    
                    using (var command2 = new SqlCommand(sqlString,connection))
                    {
                        int affected = command2.ExecuteNonQuery();
                    }

                    //Comment out above
                    //UPDATE
                    var selectedCustomer = new Customer
                    {
                        CustomerID = "MANDA",
                        ContactName = "Nish Mandal",
                        City = "Birmingham",
                        CompanyName = "Sparta Global"
                    };
                    string sqlUpdateString = $"UPDATE CUSTOMER SET CITY = 'Berlin' WHERE CustomerID = '{selectedCustomer.CustomerID}";

                    using (var command3=new SqlCommand(sqlUpdateString,connection))
                    {
                        int affected = command3.executenonquery();
                    }

                    //Comment out above
                    //DELETE
                    var customerForDeletion = new Customer
                    {
                        CustomerID = "MANDA",
                        ContactName = "Nish Mandal",
                        City = "Birmingham",
                        CompanyName = "Sparta Global"
                    };
                    string sqlDeleteString = $"DELETE FROM CUSTOMERS WHERE CustomerID = '{customerForDeletion.CustomerID}'");
                    using (var command4 = new SqlConnect(sqlDeleteString,connection))
                    {
                        int affected = command4.ExecuteNonQuery();
                    }

                    //readded himself but switches City and companyName around
                    //Using stored procedures(recreate customer before carrying on)^
                    //Update programme procedure
                    using (var updateCustomerCommand = new SqlCommand("UodateCustomer", connection))
                    {
                        updateCustomerCommand.CommandType = CommandType.StoredProcedure;
                        //add parameters
                        updateCustomerCommand.Parametes.AddWithValue("ID", "MANDA");
                        updateCustomerCommand.Parametes.AddWithValue("NewName", "Nish Kumar");
                        //run the update
                        int affected = updateCustomerCommand.ExecuteNonQuery();

                    }
                }
            }
        }
    }

    public class Customer
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string City { get; set; }

        public string GetFullName()
        {
            return $"{ContactTitle} - {ContactName}";
        }

    }
}
