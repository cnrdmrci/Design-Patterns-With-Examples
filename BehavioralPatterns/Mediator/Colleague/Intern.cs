using System;
using DesignPatterns.BehavioralPatterns.Mediator.Abstract;

namespace DesignPatterns.BehavioralPatterns.Mediator.Colleague
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    public class Intern : Worker
    {
        public Intern(string name) : base(name)
        {}

        public override void Receive(string from, string message)
        {
            Console.Write("Receiver intern, ");
            base.Receive(from, message);
        }
    }
}
