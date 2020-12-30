using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Keeper : Person
    {
        private string _animal;
        private int _daysAtWork;

        
        //public WorkWeek(int daysAtWork)
        //{
        //    _daysAtWork = daysAtWork;
        //}

        public Keeper(string fName, string lName, string animal = "") : base(fName, lName)
        {
            _animal = animal;
        }

        public Keeper() { }

        public string Helper()
        {
            return $"{GetFullName()} looks after the {_animal}";
        }

        public string Work(int daysAtWork)
        {
            string message = "";
            if (_daysAtWork <=7)
            {
                message = $"{GetFullName()} is working {_daysAtWork} days this week";
            }
            else
            {
                message = "Incorrect, more working days than days of the week";
            }
            return message;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Animal: {_animal}";
        }
    }
}
