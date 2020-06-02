using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Mediator.Abstract
{
    public abstract class AbstractChatroomMediator
    {
        public abstract void Register(Worker user);
        public abstract void SendMessage(string from,string to,string message);
    }
}
