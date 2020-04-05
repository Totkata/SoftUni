using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Tire
    {
        public double Presure { get; set; }
        public int Age { get; set; }

        public Tire(double presure, int age)
        {
            this.Presure = presure;
            this.Age = age;
        }
    }
}
