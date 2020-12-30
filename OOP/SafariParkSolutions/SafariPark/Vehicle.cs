using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Vehicle : IMovable
    {
        private int _capacity;
        private int _numPassengers;
        private int _speed=10;

        public Vehicle() { }

        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            _speed = speed;
        }

        public int NumPassengers
        {
            get { return _numPassengers; }
            set { if (value <= _capacity && value >= 0) _numPassengers = value; }
        }

        public int Position { get; private set; }

        public override string ToString()
        {
            return $"{base.ToString()} capacity: {_capacity} passengers: {_numPassengers} speed: {_speed} position: {Position}";
        }


        public virtual string Move()
        {
            Position += _speed;
            return $"Moving along";
        }

        public virtual string Move(int times)
        {
            Position += _speed*times;
            return $"Moving along {times} times";
        }
    }
}
