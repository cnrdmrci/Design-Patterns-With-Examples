using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.TemplateMethod.Abstract
{
    public abstract class Notifier
    {
        protected string Message { get; set; }
        public void TemplateMethod()
        {
            connectDatabase();
            getMessageFromDatabase();
            Notify();
            disconnect();
        }
        private void connectDatabase()
        {
            Console.WriteLine("Connect to database.");
        }

        private void getMessageFromDatabase()
        {
            Message = "Message from database";
        }

        protected abstract void Notify();

        private void disconnect()
        {
            Console.WriteLine("Disconnect from database.\n");
        }
    }
}
