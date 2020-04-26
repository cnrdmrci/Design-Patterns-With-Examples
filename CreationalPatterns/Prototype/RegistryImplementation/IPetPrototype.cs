using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Prototype.RegistryImplementation
{
    public interface IPetPrototype
    {
        IPetPrototype ShallowCopy();
        IPetPrototype DeepCopy();
    }
}
