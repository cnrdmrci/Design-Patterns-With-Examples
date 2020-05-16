using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Composite
{
    public class Manager : IWorker
    {
        public string Name { get; private set; }
        private readonly List<IWorker> _workers;
        private readonly int _workingTime;
        public Manager(string name, int workingTime)
        {
            Name = name;
            _workingTime = workingTime;
            _workers = new List<IWorker>();
        }

        public void AddWorker(IWorker worker)
        {
            _workers.Add(worker);
        }

        public int GetTotalWorkingTime()
        {
            return _workers.Sum(x => x.GetTotalWorkingTime()) + _workingTime;
        }
    }
}
