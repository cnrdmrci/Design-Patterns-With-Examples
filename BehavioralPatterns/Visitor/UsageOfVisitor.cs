using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Visitor.AbstractProduct;
using DesignPatterns.BehavioralPatterns.Visitor.AbstractVisitor;
using DesignPatterns.BehavioralPatterns.Visitor.ConcreteProduct;
using DesignPatterns.BehavioralPatterns.Visitor.ConcreteVisitor;

namespace DesignPatterns.BehavioralPatterns.Visitor
{
    public class UsageOfVisitor
    {
        public static void Run()
        {
            IFoodVisitor taxVisitor = new TaxVisitor();

            IFood pizza = new Pizza(35);
            IFood sandwich = new Sandwich(25);
            IFood soup = new Soup(10);
            IFood rice = new Rice(15);

            Console.WriteLine("Pizza price before tax : " + pizza.Price);
            pizza.Accept(taxVisitor);
            Console.WriteLine("Pizza price after tax : " + pizza.Price);

            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Sandwich price before tax : " + sandwich.Price);
            sandwich.Accept(taxVisitor);
            Console.WriteLine("Sandwich price after tax : " + sandwich.Price);

            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Soup price before tax : " + soup.Price);
            soup.Accept(taxVisitor);
            Console.WriteLine("Soup price after tax : " + soup.Price);

            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Rice price before tax : " + rice.Price);
            rice.Accept(taxVisitor);
            Console.WriteLine("Rice price after tax : " + rice.Price);
            
        }
    }
}
