using System;
using DesignPatterns.BehavioralPatterns.Mediator.Abstract;

namespace DesignPatterns.BehavioralPatterns.Mediator.Colleague
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    public class Developer : Worker
    {
        public Developer(string name) :base(name)
        {}

        public override void Receive(string from, string message)
        {
            Console.Write("Receiver developer, ");
            base.Receive(from, message);
        }
    }
}
