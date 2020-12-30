using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Camera : IShootable
    {
        //field
        private string _brand;

        //constructor
        public Camera(string brand)
        {
            _brand = brand;
        }

        //methods
        public string Shoot()
        {
            return $"Shooting a {base.ToString()}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {_brand}";
        }
    }
}
