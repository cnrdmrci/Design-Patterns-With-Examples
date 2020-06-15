using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.TemplateMethod.Abstract;

namespace DesignPatterns.BehavioralPatterns.TemplateMethod.Concrete
{
    public class SmsNotifier : Notifier
    {
        protected override void Notify()
        {
            Console.WriteLine("Message send as sms. Content : " + Message);
        }
    }
}
