using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Observer.Abstract;
using DesignPatterns.BehavioralPatterns.Observer.Concrete.Subject;

namespace DesignPatterns.BehavioralPatterns.Observer.Concrete.Observers
{
    public class TermometerA : IObserver
    {
        public void Update(AbstractSubject abstractSubject)
        {
            TemperatureSubject temperatureSubject = (TemperatureSubject) abstractSubject;
            Console.WriteLine("Termometer A; new temperature value : " + temperatureSubject.TemperatureValue);
        }
    }
}
