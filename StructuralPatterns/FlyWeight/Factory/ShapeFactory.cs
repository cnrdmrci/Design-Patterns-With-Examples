using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.StructuralPatterns.FlyWeight.Abstract;
using DesignPatterns.StructuralPatterns.FlyWeight.Concrete;

namespace DesignPatterns.StructuralPatterns.FlyWeight.Factory
{
    public class ShapeFactory
    {
        private readonly Dictionary<ShapeEnum, Shape> _shapes = new Dictionary<ShapeEnum, Shape>();

        public Shape GetShape(ShapeEnum shapeEnum)
        {
            // Uses "lazy initialization"
            Shape shape = null;
            if (_shapes.ContainsKey(shapeEnum))
            {
                shape = _shapes[shapeEnum];
            }
            else
            {
                switch (shapeEnum)
                {
                    case ShapeEnum.Square: shape = new Square(); break;
                    case ShapeEnum.Rectangular: shape = new Rectangular(); break;
                    //...
                }
                _shapes.Add(shapeEnum, shape);
            }
            return shape;
        }
    }
}
