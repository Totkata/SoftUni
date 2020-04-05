using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var engines = new List<Engine>();

            for (int i = 0; i < n; i++)
            {
                AddEngine(engines);
            }

            int m = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < m; i++)
            {
                AddCar(cars, engines);
            }

            foreach (var car in cars)
            {
                PrintCar(car);
            }
        }

        private static void PrintCar(Car car)
        {
            Console.WriteLine($"{car.Model}:");
            Console.WriteLine($"  {car.Engine.Model}:");
            Console.WriteLine($"    Power: {car.Engine.Power}");
            if (car.Engine.Displacement == 0)
            {
                Console.WriteLine($"    Displacement: n/a");
            }
            else
            {
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
            }
            Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
            if (car.Weight == 0)
            {
                Console.WriteLine($"  Weight: n/a");
            }
            else
            {
                Console.WriteLine($"  Weight: {car.Weight}");
            }
            Console.WriteLine($"  Color: {car.Color}");
        }

        private static void AddCar(List<Car> cars, List<Engine> engines)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string model = input[0];
            string engineModel = input[1];
            Engine realEngine = new Engine();
            foreach (var engine in engines)
            {
                if (engine.Model == engineModel)
                {
                    realEngine = engine;
                    break;
                }
            }
            if (input.Length == 3)
            {
                int weight;

                if (int.TryParse(input[2], out weight))
                {
                    var car = new Car(model, engineModel, realEngine,weight);
                    cars.Add(car);
                }
                else
                {
                    string color = input[2];

                    var car = new Car(model, engineModel, realEngine, color);
                    cars.Add(car);
                }
            }
            else if (input.Length == 4)
            {
                int weight = int.Parse(input[2]);
                string color = input[3];

                var engine = new Car(model, engineModel,realEngine, weight,color);
                cars.Add(engine);
            }
            else
            {
                var engine = new Car(model, engineModel, realEngine);
                cars.Add(engine);
            }
        }

        private static void AddEngine(List<Engine> engines)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string model = input[0];
            int power = int.Parse(input[1]);

            if (input.Length == 3)
            {
                int displacement;

                if (int.TryParse(input[2], out displacement))
                {
                    var engine = new Engine(model, power,displacement);
                    engines.Add(engine);
                }
                else
                {
                    string efficiency = input[2];

                    var engine = new Engine(model, power, efficiency);
                    engines.Add(engine);
                }
            }
            else if (input.Length == 4)
            {
                int displacement = int.Parse(input[2]);
                string efficiency = input[3];

                var engine = new Engine(model, power, displacement, efficiency);
                engines.Add(engine);
            }
            else
            {
                var engine = new Engine(model, power);
                engines.Add(engine);
            }
        }
    }
}
