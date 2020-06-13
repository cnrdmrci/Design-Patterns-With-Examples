using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Observer.Abstract
{
    public interface IObserver
    {
        void Update(AbstractSubject abstractSubject);
    }
}
