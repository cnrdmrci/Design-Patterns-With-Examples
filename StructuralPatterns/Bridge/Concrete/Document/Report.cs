using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.StructuralPatterns.Bridge.Abstract;

namespace DesignPatterns.StructuralPatterns.Bridge.Concrete.Belge
{
    public class Report : Document
    {
        public Report(IDatabase database) : base(database) {}
        public void SaveData(string data)
        {
            Console.WriteLine("Report type data is being saved to database. Info: " + data);
            this.SaveDatabase(data);
        }
    }
}
