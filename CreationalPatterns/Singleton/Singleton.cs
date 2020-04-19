using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Singleton
{
    public sealed class Singleton
    {
        private static Singleton _instance;

        private Singleton() { }

        public static Singleton getInstance()
        {
            return _instance ??= new Singleton();
        }

        public static Singleton Instance => _instance ??= new Singleton();
    }
}
