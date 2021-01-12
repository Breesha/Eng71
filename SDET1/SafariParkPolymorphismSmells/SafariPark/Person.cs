﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    // A Class to represent a Person
    public class Person 
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        
        private Address _address;
        public Person() { }
        public Person(string fName, string lName, Address add = null)
        {
            _firstName = fName;
            _lastName = lName;
            _address = add;
            
        }

        public int Age
        {
            get { return _age; }
            set { if (value >= 0) _age = value; }
        }

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        public string Move()
        {
            Console.WriteLine("Can get here, now!");
            return "Walking along";
        }

        public string Move(int times)
        {
            return $"Walking along {times} times";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}. {GetAddress()}";
        }

        private string GetAddress()
        {
            return _address.ToString();
        }
    }
}
