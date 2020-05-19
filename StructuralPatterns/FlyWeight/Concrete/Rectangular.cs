using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.StructuralPatterns.FlyWeight.Abstract;

namespace DesignPatterns.StructuralPatterns.FlyWeight.Concrete
{
    public class Rectangular : Shape
    {
        public Rectangular()
        {
            Height = 10;
            Width = 20;
        }
        public override void Display(string color)
        {
            Color = color;
            int rectangularArea = Height * Width;
            Console.WriteLine("Rectangular area : " + rectangularArea + ", Color: " + Color);
        }
    }
}
