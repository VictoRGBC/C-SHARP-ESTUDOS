using System;
using MetodosAbstratos.Entities.Enums;
using System.Globalization;

namespace MetodosAbstratos.Entities
{
    abstract class Shape
    {
        public Color Color{ get; set; }

        public Shape()
        {
        }

        public Shape(Color color)
        {
           Color = color;
        }

        public abstract double Area();
    }
}
