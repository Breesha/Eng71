using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Hunter : Person , IShootable
    {
        //constructors
        private IShootable _shooter;
        public IShootable Shooter
        {
            get { return _shooter; }
            set { _shooter = value; }
        }

        public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
        {
            Shooter = shooter;
        }

        public Hunter() { }

        //methods
        public override string ToString()
        {
            return $"{base.ToString()} Shooter: { Shooter}";
        }

        public string Shoot()
        {
            return $"{GetFullName()}: {Shooter.Shoot()}";
        }
    }

    //public class SDET: Hunter
    //{
    //    public string IDE { get; set; }
    //}
    //// used to demonstrate 
}
