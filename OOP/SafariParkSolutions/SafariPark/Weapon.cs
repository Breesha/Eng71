using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public abstract class Weapon : IShootable
    {
        //field
        private string _brand;

        //constructor
        public Weapon(string brand)
        {
            _brand = brand;
        }

        //methods
        public virtual string Shoot()
        {
            return $"Shooting a {base.ToString()}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {_brand}";
        }
    }
}
