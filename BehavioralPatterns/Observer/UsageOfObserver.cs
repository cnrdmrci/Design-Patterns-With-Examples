using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Observer.Concrete;
using DesignPatterns.BehavioralPatterns.Observer.Concrete.Observers;
using DesignPatterns.BehavioralPatterns.Observer.Concrete.Subject;

namespace DesignPatterns.BehavioralPatterns.Observer
{
    public class UsageOfObserver
    {
        public static void Run()
        {
            TemperatureSubject temperatureSubject = new TemperatureSubject();

            TermometerA termometerA = new TermometerA();
            TermometerB termometerB = new TermometerB();
            TermometerC termometerC = new TermometerC();

            temperatureSubject.RegisterObserver(termometerA);
            temperatureSubject.RegisterObserver(termometerB);
            temperatureSubject.RegisterObserver(termometerC);

            temperatureSubject.TemperatureValue = 10;

            temperatureSubject.RemoveObserver(termometerB);

            temperatureSubject.TemperatureValue = 11;
            temperatureSubject.TemperatureValue = 12;

        }
    }
}
