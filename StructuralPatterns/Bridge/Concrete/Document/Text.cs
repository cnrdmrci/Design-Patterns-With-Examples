using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.StructuralPatterns.Bridge.Abstract;

namespace DesignPatterns.StructuralPatterns.Bridge.Concrete.Belge
{
    public class Text : Document
    {
        public Text(IDatabase database) : base(database) { }
        public void SaveData(string data)
        {
            Console.WriteLine("Text type data is being saved to database. Info: " + data);
            SaveDatabase(data);
        }
    }
}
