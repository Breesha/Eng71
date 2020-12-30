using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleHomework
{
    public class Vehicle
    {
        private int _capacity;
        private int _numPassengers;
        private int _speed;

        public Vehicle() { }

        public Vehicle(int capacity, int speed=10)
        {
            _capacity = capacity;
            _speed = speed;
        }

        public int NumPassengers
        {
        get { return _numPassengers; }
            set { if (value <= _capacity && value>=0) _numPassengers = value; }
        }

        public int Position
        {
            get { return _speed; }
            set { if (value >= 0) _speed = value; }
        }

        public string Move()
        {
            string message = "Moving along";

            if (_speed > 1)
            {

            }
            else
            {
                message = "Not moving";
            }
            return message;
        }

        public string Move(int times)
        {
            string message = "";
             
            if(times>=1)
            {
                message = $"Moving along {times} times";
                _speed = times*10;
            }
            else
            {
                message = "Not moving";
            }
            return message;
        }
    }
}
