using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Facade
{
    class Email
    {
        public string Send(string name)
        {
            return $"Send data to {name}.\n";
        }
    }
}
