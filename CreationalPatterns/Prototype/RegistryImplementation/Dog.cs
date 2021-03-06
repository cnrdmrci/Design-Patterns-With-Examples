﻿using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.CreationalPatterns.Prototype.Common;

namespace DesignPatterns.CreationalPatterns.Prototype.RegistryImplementation
{
    [Serializable]
    public class Dog : IPetPrototype
    {
        public string Name { get; set; }

        public Dog(string name)
        {
            Name = name;
        }

        public IPetPrototype ShallowCopy()
        {
            return this.GetShallowCopy();
        }

        public IPetPrototype DeepCopy()
        {
            return this.GetDeepCopy();
        }
    }
}
