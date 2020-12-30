using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class LaserGun : Weapon
    {
        //constructors
        public LaserGun(string brand) : base(brand)
        {
        }

        //methods
        public override string Shoot()
        {
            return $"Zing!! {base.Shoot()}";
        }
    }
}
