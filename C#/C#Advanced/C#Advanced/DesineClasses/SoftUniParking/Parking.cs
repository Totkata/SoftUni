﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    class Parking
    {
        private List<Car> cars;
        private int capacity;

        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new List<Car>();
        }

        public int Count => this.cars.Count();

        public string AddCar(Car car)
        {
            string output = string.Empty;

            if (this.cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            { 
                return "Car with that registration number, already exists!";
            }
            else if (this.cars.Count >= this.capacity)
            {
               return "Parking is full!";
            }
            else
            {
                cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }
        public string RemoveCar(string registrationNumber)
        {
            string output = string.Empty;

            foreach (var car in cars)
            {
                if (car.RegistrationNumber == registrationNumber)
                {
                    
                }
            }
            if (!this.cars.Any(x => x.RegistrationNumber == registrationNumber))
            {
                return $"Car with that registration number, doesn't exist!";
            }
            else
            {
                this.cars.Remove(this.cars.FirstOrDefault(x => x.RegistrationNumber == registrationNumber));
                return $"Successfully removed {registrationNumber}"; ;
            }
        }
        public Car GetCar(string registrationNumber)
        {
            return this.cars.FirstOrDefault(x => x.RegistrationNumber == registrationNumber);
        }
        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var currentNumber in registrationNumbers)
            {
                this.cars.RemoveAll(x => x.RegistrationNumber == currentNumber);
            }
        }
    }
}
