using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Vehicle> vehicles = new List<Vehicle>();

            while (input != "End")
            {
                string[] splitedInput = input.Split(" ");
                string type = splitedInput[0];
                string model = splitedInput[1];
                string color = splitedInput[2];
                string horsePower = splitedInput[3];
                Vehicle vehicle = new Vehicle(type, model, color, horsePower);
                vehicles.Add(vehicle);
                input = Console.ReadLine();
            }

            while (input != "Close the Catalogue")
            {
                Vehicle desiredVehicle = vehicles.FirstOrDefault(x => x.Model == input);
                Console.WriteLine(desiredVehicle);
                input = Console.ReadLine();
            }

            var cars = vehicles
                .Where(x => x.Type == "car")
                .ToList();

            var trucks = vehicles
                .Where(x => x.Type == "truck")
                .ToList();

            double carsAvgHorsepower = cars.Count > 0 ? cars.Average(x => double.Parse(x.Horsepower)) : 0.0;
            double trucksAvgHorsepower = trucks.Count > 0 ? trucks.Average(x => double.Parse(x.Horsepower)) : 0.0;

            Console.WriteLine($"Cars have average horsepower of: {carsAvgHorsepower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHorsepower:f2}.");
        }
    }
    class Vehicle
    {
        public Vehicle(string type, string model, string color, string horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Horsepower { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string type = string.Empty;
            if (Type == "car")
            {
                type = "Car";
            }
            else
            {
                type = "Truck";
            }
            sb.Append($"Type: {type}")
            .Append(Environment.NewLine)
            .Append($"Model: {Model}")
            .Append(Environment.NewLine)
            .Append($"Color: {Color}")
            .Append(Environment.NewLine)
            .Append($"Horsepower: {Horsepower}");
            return sb.ToString().TrimEnd();
        }
    }
}
