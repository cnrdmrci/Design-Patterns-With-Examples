using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Bridge.Abstract
{
    public abstract class Document
    {
        private readonly IDatabase _database;

        public Document(IDatabase database)
        {
            _database = database;
        }

        public void SaveDatabase(string data)
        {
            _database.Save(data);
        }
    }
}
