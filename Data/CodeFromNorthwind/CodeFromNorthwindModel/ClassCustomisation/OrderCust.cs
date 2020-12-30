using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFromNorthwindModel
{
    public partial class Order
    {

        public override string ToString()
        {
            return $"{OrderId} - {Freight} - {ShipCity}";
        }
    }
}
