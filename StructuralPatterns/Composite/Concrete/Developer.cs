using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Composite
{
    public class Developer : IWorker
    {
        public string Name { get; private set; }
        private readonly int _workingTime;
        public Developer(string name,int workingTime)
        {
            Name = name;
            _workingTime = workingTime;
        }

        public int GetTotalWorkingTime()
        {
            return _workingTime;
        }
    }
}
