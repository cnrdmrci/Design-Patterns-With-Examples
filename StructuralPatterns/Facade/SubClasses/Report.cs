using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Facade
{
    class Report
    {
        public string CreateReport(string name)
        {
            return $"Create report for {name}.\n";
        }
    }
}
