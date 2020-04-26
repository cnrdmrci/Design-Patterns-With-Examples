using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Prototype.RegistryImplementation
{
    public class PrototypeRegistry
    {
        private readonly Dictionary<string,IPetPrototype> _petPrototypes;

        public PrototypeRegistry()
        {
            _petPrototypes = new Dictionary<string, IPetPrototype>();
        }

        public void AddPetPrototype(string key,IPetPrototype petPrototype)
        {
            _petPrototypes.Add(key, petPrototype);
        }

        public IPetPrototype GetPetPrototypeByKey(string key)
        {
            return _petPrototypes[key];
        }
    }
}
