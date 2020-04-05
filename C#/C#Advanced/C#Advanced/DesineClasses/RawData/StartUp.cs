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

            string cargoType = Console.ReadLine();

            foreach (var car in cars)
            {
                if (car.Cargo.Type == cargoType && cargoType == "fragile")
                {
                    bool presureIsLow = false;

                    foreach (var tire in car.Tires)
                    {
                        if (tire.Presure < 1)
                        {
                            presureIsLow = true;
                            break;
                        }
                    }
                    if (presureIsLow)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
                else if (car.Cargo.Type == cargoType && cargoType == "flamable")
                {
                    if (car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }

        private static void AddCar(List<Car> cars)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            string model = input[0];

            int engineSpeed = int.Parse(input[1]);
            int enginePower = int.Parse(input[2]);
            Engine engine = new Engine(engineSpeed,enginePower);

            int cargoWeight = int.Parse(input[3]);
            string cargoType = input[4];
            Cargo cargo = new Cargo(cargoWeight, cargoType);

            List<Tire> tires = new List<Tire>();
            for (int i = 5; i < 13; i+=2)
            {
                double presure = double.Parse(input[i]);
                int age = int.Parse(input[i + 1]);
                Tire tire = new Tire(presure,age);
                tires.Add(tire);
            }
            Car car = new Car(model, engine, cargo, tires);
            cars.Add(car);
        }
    }
}
