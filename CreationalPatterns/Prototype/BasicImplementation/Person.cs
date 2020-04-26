using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.CreationalPatterns.Prototype.Common;

namespace DesignPatterns.CreationalPatterns.Prototype.BasicImplementation
{
    [Serializable]
    public class Person : Cloneable<Person>
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public Address Address { get; set; }
    }
}
