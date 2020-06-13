using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Observer.Abstract
{
    public abstract class AbstractSubject
    {
        private readonly List<IObserver> _observers;

        protected AbstractSubject()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        protected void NotifyObservers()
        {
            _observers.ForEach(x=>x.Update(this));
            Console.WriteLine("\n");
        }
    }
}
