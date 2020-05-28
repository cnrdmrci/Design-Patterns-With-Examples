using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Iterator.Abstract;
using DesignPatterns.BehavioralPatterns.Iterator.Product;

namespace DesignPatterns.BehavioralPatterns.Iterator.Concrete
{
    public class IteratorCreator<T> : IIteratorCreator<T>
    {
        private readonly List<T> _elementList;

        public IteratorCreator(List<T> elementList)
        {
            _elementList = elementList;
        }

        public IIterator<T> CreateIterator()
        {
            return new Iterator<T>(_elementList);
        }
    }
}
