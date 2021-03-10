using System;
using System.Collections.Generic;
using System.Text;
using _136.Exercicio_Resolvido.Entities.Enums;

namespace _136.Exercicio_Resolvido.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }
        //declarando um metodo abstrado
        public abstract double Area();

    }
}
