using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.StructuralPatterns.Bridge.Abstract;

namespace DesignPatterns.StructuralPatterns.Bridge.Concrete.Database
{
    public class Postgresql : IDatabase
    {
        public void Save(string data)
        {
            Console.WriteLine("Data was saved to Postgresql database. Info: " + data);
        }
    }
}
