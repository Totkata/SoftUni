using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Car
    {
        public string Model { get; set; }
        public string EngineModel { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, string engineModel, Engine engine)
        {
            this.Model = model;
            this.EngineModel = engineModel;
            this.Engine = engine;
            this.Weight = 0;
            this.Color = "n/a";
        }
        public Car(string model, string engineModel, Engine engine, int weight)
            : this(model, engineModel, engine)
        {
            this.Weight = weight;
            this.Color = "n/a";
        }
        public Car(string model, string engineModel, Engine engine, string color)
            : this(model, engineModel, engine)
        {
            this.Weight = 0;
            this.Color = color;
        }
        public Car(string model, string engineModel, Engine engine, int weight,string color)
        {
            this.Model = model;
            this.EngineModel = engineModel;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }
    }
}
