using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.TemplateMethod.Abstract;

namespace DesignPatterns.BehavioralPatterns.TemplateMethod.Concrete
{
    public class MailNotifier : Notifier
    {
        protected override void Notify()
        {
            Console.WriteLine("Message send as mail. Content : " + Message);
        }
    }
}
