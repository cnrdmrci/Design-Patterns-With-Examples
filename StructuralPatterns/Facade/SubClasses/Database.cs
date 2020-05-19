using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Facade
{
    class Database
    {
        public string GetData(string name)
        {
            return $"Get data from database for {name}.\n";
        }
    }
}
