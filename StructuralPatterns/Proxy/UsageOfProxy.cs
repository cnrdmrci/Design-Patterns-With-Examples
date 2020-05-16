using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.StructuralPatterns.Proxy.Abstract;
using DesignPatterns.StructuralPatterns.Proxy.Concrete;

namespace DesignPatterns.StructuralPatterns.Proxy
{
    public class UsageOfProxy
    {
        public static void Run()
        {
            try
            {
                IDatabase databaseManager = new DatabaseManagerProxy("caner", "12345");
                Console.WriteLine(databaseManager.GetDataFromDatabase());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
