using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Person : IMovable
    {

        private string _firstName;
        private string _lastName;
        //public int MyProperty { get; set; } AccessViolationException by prop tab tab
        //public int Age{ get; set; } can also be written as below

        private int _age;

        public int Age
        {
            get { return _age; }
            set { if(value>=0) _age = value; }
        }

        public Person() { }

        public Person(string fName, string lName)
        {
            _firstName = fName;
            _lastName = lName;
        }

        public Person(string fName, string lName, int Age)
        {
            _firstName = fName;
            _lastName = lName;
            this.Age= Age;
        }

        public string GetFullName()
        {
            
            return $"{_firstName} {_lastName}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}"; 
        }

        public virtual string Move()
        {
            return $"Walking along";
        }

        public virtual string Move(int times)
        {
            return $"Walking along {times} times";
        }
    }
}
