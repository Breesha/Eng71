using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    public class Address
    {
        public int HouseNo { get; set; } = 0;
        public string Street { get; set; } = "";
        public string Town { get; set; } = "";

        public override string ToString()
        {
            return $"Address: {HouseNo} {Street}, {Town}";
        }
    }
}
