﻿using System;

namespace Constructors
{
    public class Vehicle
    {
        private readonly string _registrationNumber;
        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is being initialized {0} .",registrationNumber);
        }
    }
}
