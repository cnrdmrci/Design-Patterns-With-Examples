using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.StructuralPatterns.FlyWeight.Abstract;

namespace DesignPatterns.StructuralPatterns.FlyWeight.Concrete
{
    public class Square : Shape
    {
        public Square()
        {
            Height = 10;
            Width = 10;
        }
        public override void Display(string color)
        {
            Color = color;
            int squareArea = Height * Width;
            Console.WriteLine("Square area : " + squareArea + ", Color: " + Color);
        }
    }
}
