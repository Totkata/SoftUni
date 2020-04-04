using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                AddCar(cars);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] splitedCommand = command.Split(" ").ToArray();

                string model = splitedCommand[1];
                double distance = double.Parse(splitedCommand[2]);

                foreach (var car in cars)
                {
                    if (car.Model == model)
                    {
                        car.Drive(distance);
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var car in cars)
            {
                PrintCar(car);
            }
        }

        private static void PrintCar(Car car)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
        }

        private static void AddCar(List<Car> cars)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            string model = input[0];
            double fuel = double.Parse(input[1]);
            double fuelConsuption = double.Parse(input[2]);

            Car car = new Car(model, fuel, fuelConsuption);

            cars.Add(car);
        }
    }
}
