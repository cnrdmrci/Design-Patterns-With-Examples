using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.TemplateMethod.Abstract;
using DesignPatterns.BehavioralPatterns.TemplateMethod.Concrete;

namespace DesignPatterns.BehavioralPatterns.TemplateMethod
{
    public class UsageOfTemplateMethod
    {
        public static void Run()
        {
            Notifier mailNotifier = new MailNotifier();
            mailNotifier.TemplateMethod();

            Notifier smsNotifier = new SmsNotifier();
            smsNotifier.TemplateMethod();
        }
    }
}
