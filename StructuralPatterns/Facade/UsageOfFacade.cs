using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Facade
{
    public class UsageOfFacade
    {
        public static void Run()
        {
            Reporting reporting = new Reporting();
            string reportLog = reporting.DoReportingAndGetLog("Caner");

            Console.WriteLine(reportLog);
        }
    }
}
