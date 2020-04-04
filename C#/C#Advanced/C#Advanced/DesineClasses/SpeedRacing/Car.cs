using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TraveledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKm;
            this.TraveledDistance = 0.0;
        }

        public void Drive(double distance)
        {

            if (this.FuelAmount < distance * this.FuelConsumptionPerKilometer)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.FuelAmount -= distance * this.FuelConsumptionPerKilometer;
                this.TraveledDistance += distance;
            }
        }
    }
}
