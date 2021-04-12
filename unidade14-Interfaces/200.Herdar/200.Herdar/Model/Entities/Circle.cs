using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using _200.Herdar.Model.Enums;

namespace _200.Herdar.Model.Entities
{
    class Circle: Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public override string ToString()
        {
            return "Circle color = "
                + Color
                + ", radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
