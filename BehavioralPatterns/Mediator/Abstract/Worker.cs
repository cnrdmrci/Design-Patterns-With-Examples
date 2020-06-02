using System;
using DesignPatterns.BehavioralPatterns.Mediator.Concrete;

namespace DesignPatterns.BehavioralPatterns.Mediator.Abstract
{
    /// <summary>
    /// The 'AbstractColleague' class
    /// </summary>
    public abstract class Worker
    {
        public readonly string Name;
        public ConcreteChatroomMediator Chatroom { get; set; }

        protected Worker(string name)
        {
            Name = name;
        }


        public void Send(string to, string message)
        {
            Chatroom.SendMessage(Name, to, message);
        }


        public virtual void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'", from, Name, message);
        }
    }
}
