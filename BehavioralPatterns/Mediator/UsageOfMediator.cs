using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Mediator.Abstract;
using DesignPatterns.BehavioralPatterns.Mediator.Colleague;
using DesignPatterns.BehavioralPatterns.Mediator.Concrete;

namespace DesignPatterns.BehavioralPatterns.Mediator
{
    public class UsageOfMediator
    {
        public static void Run()
        {
            AbstractChatroomMediator chatroom = new ConcreteChatroomMediator();

            // Create participants and register them
            Worker Caner = new Developer("Caner");
            Worker Tamer = new Developer("Tamer");
            Worker Mehmet = new Developer("Mehmet");
            Worker Onur = new Intern("Onur");
            Worker Murat = new Intern("Murat");

            chatroom.Register(Caner);
            chatroom.Register(Tamer);
            chatroom.Register(Mehmet);
            chatroom.Register(Onur);
            chatroom.Register(Murat);

            Caner.Send(Onur.Name,"Hi " + Onur.Name);
            Onur.Send(Caner.Name,"Hi " + Caner.Name);

            Caner.Send(Onur.Name,"Welcome!");
            Tamer.Send(Onur.Name,"Welcome!");
            Caner.Send(Onur.Name,"Welcome!");
            Mehmet.Send(Onur.Name,"Welcome!");
            Murat.Send(Onur.Name,"Welcome!");

        }
    }
}
