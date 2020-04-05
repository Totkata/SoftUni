using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine()
        {
            this.Model = "";
            this.Power = 0;
            this.Displacement = 0;
            this.Efficiency = "n/a";
        }
        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = 0;
            this.Efficiency = "n/a";
        }
        public Engine(string model, int power,int displacement)
            : this(model, power)
        {
            this.Displacement = displacement;
            this.Efficiency = "n/a";
        }
        public Engine(string model, int power, string efficiency)
            : this(model, power)
        {
            this.Displacement = 0;
            this.Efficiency =efficiency;
        }
        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }
    }
}
