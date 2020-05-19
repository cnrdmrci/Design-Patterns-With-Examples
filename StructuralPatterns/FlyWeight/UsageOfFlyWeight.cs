using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.StructuralPatterns.FlyWeight.Abstract;
using DesignPatterns.StructuralPatterns.FlyWeight.Factory;

namespace DesignPatterns.StructuralPatterns.FlyWeight
{
    public class UsageOfFlyWeight
    {
        public static void Run()
        {
            List<ShapeEnum> shapeList = new List<ShapeEnum> {ShapeEnum.Rectangular, ShapeEnum.Square, ShapeEnum.Rectangular, ShapeEnum.Rectangular};

            ShapeFactory shapeFactory = new ShapeFactory();

            foreach (ShapeEnum shapeEnum in shapeList)
            {
                Shape shape = shapeFactory.GetShape(shapeEnum);
                shape.Display("Black");
            }
        }
    }
}
