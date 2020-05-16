using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.StructuralPatterns.Proxy.Abstract;

namespace DesignPatterns.StructuralPatterns.Proxy.Concrete
{
    public class DatabaseManager : IDatabase
    {
        public string GetDataFromDatabase()
        {
            return "Data from database";
        }
    }
}
