using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFromNorthwindModel
{
    public interface ICustomerService
    {
        List<Customers> GetCustomerList();
        Customers GetCustomerById(string customerId);
        void CreateCustomer(Customers customer);
        void UpdateCustomer();
        void DeleteCustomer(string customerId);
    }
}
