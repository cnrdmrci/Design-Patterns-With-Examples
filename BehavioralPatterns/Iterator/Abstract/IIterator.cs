using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Iterator.Abstract
{
    public interface IIterator<out T>
    {
        T CurrentElement { get; }
        bool HasNextElement();
    }
}
