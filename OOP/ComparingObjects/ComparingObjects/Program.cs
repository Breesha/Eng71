using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var bobOne=new Person("Bob", "Builder") { Age = 25 };
            var bobTwo = bobOne;
            var areSame = bobOne.Equals(bobTwo);

            var bobThree=new Person("Bob", "Builder") { Age = 25 };
            var areSame2 = bobOne.Equals(bobThree);
            // different referencee memory places/ Hashcodes so aren't the same

            var personList = new List<Person>
            {
                new Person("Bob", "Builder") { Age = 25 },
                new Person("Cath","Cookson"),
                new Person("Dan","Dare"),
                new Person("Amy", "Andrews")
            };

            
            //personList.ForEach(c => Console.WriteLine(c));
            //Console.WriteLine();
            //personList.Sort();
            //personList.ForEach(c => Console.WriteLine(c));

            //var hasBob = personList.Contains(bobOne);
            ////Console.WriteLine(bobOne.GetHashCode()+" " +bobTwo.GetHashCode());

            //var nish = new Person("Nish", "Mandal") { Age = 30 };
            //var isNishBob = bobOne.CompareTo(nish);
        }
    }

    public class Person : IEquatable<Person> , IComparable<Person>
    {
        private string _firstName;
        private string _lastName;

        public int Age { get; set; }

        public Person(string fName, string lName)
        {
            _firstName = fName;
            _lastName = lName;
        }

        public override string ToString()
        {
            return $"{_firstName} {_lastName}";
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person other)
        {
            return other != null &&
                   _firstName == other._firstName &&
                   _lastName == other._lastName &&
                   Age == other.Age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_firstName, _lastName, Age);
        }

        public int CompareTo([AllowNull] Person other)
        {
            if (other == null) return 1;
            if(this._lastName != other._lastName)
            {
                return this._lastName.CompareTo(other._lastName);
            }
            else if(this._firstName != other._firstName)
            {
                return this._firstName.CompareTo(other._firstName);
            }
            else
            {
                return this.Age.CompareTo(other.Age);
            }
        }

        public static bool operator ==(Person left, Person right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);
        }
    }
}
