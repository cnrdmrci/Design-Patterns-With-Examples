using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.CreationalPatterns.Prototype.Common;

namespace DesignPatterns.CreationalPatterns.Prototype.BasicImplementation
{
    [Serializable]
    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
    }
}
