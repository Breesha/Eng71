using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class WaterPistol : Weapon
    {
        //constructors
        public WaterPistol(string brand) : base(brand) { }

        //method
        public override string Shoot()
        {
            return $"Splash!! {base.Shoot()}";
        }
    }
}
