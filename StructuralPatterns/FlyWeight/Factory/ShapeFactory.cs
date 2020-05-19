using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.StructuralPatterns.FlyWeight.Abstract;
using DesignPatterns.StructuralPatterns.FlyWeight.Concrete;

namespace DesignPatterns.StructuralPatterns.FlyWeight.Factory
{
    public class ShapeFactory
    {
        private readonly Dictionary<ShapeEnum, Shape> _characters = new Dictionary<ShapeEnum, Shape>();

        public Shape GetShape(ShapeEnum shapeEnum)
        {
            // Uses "lazy initialization"
            Shape shape = null;
            if (_characters.ContainsKey(shapeEnum))
            {
                shape = _characters[shapeEnum];
            }
            else
            {
                switch (shapeEnum)
                {
                    case ShapeEnum.Square: shape = new Square(); break;
                    case ShapeEnum.Rectangular: shape = new Rectangular(); break;
                    //...
                }
                _characters.Add(shapeEnum, shape);
            }
            return shape;
        }
    }
}
