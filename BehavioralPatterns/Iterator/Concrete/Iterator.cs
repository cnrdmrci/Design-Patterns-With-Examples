using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Iterator.Abstract;
using DesignPatterns.BehavioralPatterns.Iterator.Product;

namespace DesignPatterns.BehavioralPatterns.Iterator.Concrete
{
    public class Iterator<T> : IIterator<T>
    {
        private int _currentIndex = 0;
        private readonly List<T> _elementList;
        public Iterator(List<T> elementList)
        {
            _elementList = elementList;
        }

        public T CurrentElement { get; private set; }

        public bool HasNextElement()
        {
            if (_currentIndex < _elementList.Count)
            {
                CurrentElement = _elementList[_currentIndex++];
                return true;
            }
            
            return false;
        }
    }
}
