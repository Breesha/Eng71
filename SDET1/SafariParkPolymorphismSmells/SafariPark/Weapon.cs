using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    public enum WeaponType
    {
        Waterpistol,
        LaserGun,
        BubbleBlaster
    }
    public class Weapon : IShootable
    {
        

        private string _brand;
        public Weapon( string brand)
        {
            _brand = brand;
        }
        public override string ToString()
        {
            return $"{base.ToString()} - {_brand}";
            
        }

        public virtual string Shoot()
        {
            return $"Shooting a {ToString()}";
        }
    }

    public class WaterPistol: Weapon
    {
        public WaterPistol(string brand): base(brand)
        {

        }

        public override string Shoot()
        {
            return $"Splash!! {base.Shoot()}";
        }
    }

    public class LaserGun : Weapon
    {
        public LaserGun(string brand) : base(brand)
        {

        }

        public override string Shoot()
        {
            return $"Zing!! {base.Shoot()}";
        }
    }
}


