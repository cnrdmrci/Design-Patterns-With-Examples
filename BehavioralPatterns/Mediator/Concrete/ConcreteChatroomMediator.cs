using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Mediator.Abstract;

namespace DesignPatterns.BehavioralPatterns.Mediator.Concrete
{
    public class ConcreteChatroomMediator : AbstractChatroomMediator
    {
        private readonly Dictionary<string, Worker> _userList;

        public ConcreteChatroomMediator()
        {
            _userList = new Dictionary<string, Worker>();
        }

        public override void Register(Worker user)
        {
            if (!_userList.ContainsKey(user.Name))
            {
                _userList[user.Name] = user;
                user.Chatroom = this;
            }
        }

        public override void SendMessage(string from, string to, string message)
        {
            if (_userList.ContainsKey(to))
            {
                _userList[to].Receive(from, message);
            }
        }
    }
}
