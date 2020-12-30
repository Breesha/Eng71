using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Spartan
    {
        public string FirstName { get; set; }

        public string LastName { get; }

        public Spartan(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }
    }
}
