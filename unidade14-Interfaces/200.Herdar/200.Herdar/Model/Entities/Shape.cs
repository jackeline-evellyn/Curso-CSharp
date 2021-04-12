using System;
using System.Collections.Generic;
using System.Text;
using _200.Herdar.Model.Enums;

namespace _200.Herdar.Model.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
