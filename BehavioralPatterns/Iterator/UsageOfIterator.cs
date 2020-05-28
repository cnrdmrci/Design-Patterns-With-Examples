using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Iterator.Abstract;
using DesignPatterns.BehavioralPatterns.Iterator.Concrete;
using DesignPatterns.BehavioralPatterns.Iterator.Product;

namespace DesignPatterns.BehavioralPatterns.Iterator
{
    public class UsageOfIterator
    {
        public static void Run()
        {
            List<Element> elementList = new List<Element>
            {
                new Element() {ElementName = "Element 1"},
                new Element() {ElementName = "Element 2"},
                new Element() {ElementName = "Element 3"},
                new Element() {ElementName = "Element 4"},
                new Element() {ElementName = "Element 5"}
            };


            var iteratorCreator = new IteratorCreator<Element>(elementList);

            var iterator = iteratorCreator.CreateIterator();

            while (iterator.HasNextElement())
            {
                Console.WriteLine(iterator.CurrentElement.ElementName);
            }
        }
    }
}
