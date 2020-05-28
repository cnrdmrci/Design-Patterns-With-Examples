using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Iterator.Abstract
{
    public interface IIteratorCreator<out T>
    {
        IIterator<T> CreateIterator();
    }
}
