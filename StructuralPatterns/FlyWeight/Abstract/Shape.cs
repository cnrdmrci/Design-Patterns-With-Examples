using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.FlyWeight.Abstract
{
    public enum ShapeEnum
    {
        Square,
        Rectangular
    }
    public abstract class Shape
    {
        protected int Height;
        protected int Width;
        protected string Color;
        public abstract void Display(string color);
    }
}
