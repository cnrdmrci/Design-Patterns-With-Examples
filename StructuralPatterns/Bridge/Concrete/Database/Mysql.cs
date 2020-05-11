using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.StructuralPatterns.Bridge.Abstract;

namespace DesignPatterns.StructuralPatterns.Bridge.Concrete.Database
{
    public class Mysql : IDatabase
    {
        public void Save(string data)
        {
            Console.WriteLine("Data was saved to Mysql database. Info: " + data);
        }
    }
}
