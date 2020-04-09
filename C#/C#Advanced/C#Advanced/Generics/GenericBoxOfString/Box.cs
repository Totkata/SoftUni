using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Box<T>
    {
        public T Value { get; set; }
        public Box(T input)
        {
            this.Value = input;
        }

       public override string ToString()
        {
            return $"{typeof(T).FullName}: {this.Value}";
        }
    }
}
