using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.StructuralPatterns.Bridge.Concrete.Belge;
using DesignPatterns.StructuralPatterns.Bridge.Concrete.Database;

namespace DesignPatterns.StructuralPatterns.Bridge
{
    public class UsageOfBridge
    {
        public static void Run()
        {
            string data = "anything";

            Report reportAndPostgresql = new Report(new Postgresql());
            reportAndPostgresql.SaveData(data);

            Report reportAndMysql = new Report(new Mysql());
            reportAndMysql.SaveData(data);

            Text textAndPostgresql = new Text(new Postgresql());
            textAndPostgresql.SaveData(data);

            Text textAndMysql = new Text(new Mysql());
            textAndMysql.SaveData(data);


        }
    }
}
