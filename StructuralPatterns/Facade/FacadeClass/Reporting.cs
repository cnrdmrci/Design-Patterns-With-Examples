using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Facade
{
    public class Reporting
    {
        private Database _database;
        private Report _report;
        private Email _email;

        public Reporting()
        {
            _database = new Database();
            _report = new Report();
            _email = new Email();
        }

        public string DoReportingAndGetLog(string name)
        {
            string log = "";
            log += _database.GetData(name);
            log += _report.CreateReport(name);
            log += _email.Send(name);

            return log;
        }
    }
}
