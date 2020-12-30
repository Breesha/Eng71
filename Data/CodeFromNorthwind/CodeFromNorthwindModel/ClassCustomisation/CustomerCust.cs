using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFromNorthwindModel
{
    public partial class Customer
    {
        public override string ToString()
        {
            return $"{CustomerId} - {ContactName} - {City}";
        }

        // public override string ToString() =>$"{CustomerId} - {ContactName} - {City}";
        //can be used as a lambda too
    }
}
