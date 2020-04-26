using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.CreationalPatterns.Prototype.BasicImplementation;
using DesignPatterns.CreationalPatterns.Prototype.RegistryImplementation;

namespace DesignPatterns.CreationalPatterns.Prototype
{
    public class UsageOfPrototype
    {
        public static void Run()
        {
            Console.WriteLine("Basic Implementation");

            Person basicImp = new Person();
            basicImp.PersonId = 1;
            basicImp.Name = "Caner";
            basicImp.Gender = "Erkek";
            basicImp.Address = new Address() {Country = "Türkiye"};

            Person basicImpShallowCopy = basicImp.GetShallowCopy();
            Person basicImpDeepCopy = basicImp.GetDeepCopy();

            //---------------------------------------------------------------

            Console.WriteLine("Registry Implementation");

            PrototypeRegistry prototypeRegistry = new PrototypeRegistry();
            
            Cat catA = new Cat("catA");
            Cat catB = new Cat("catB");
            Dog dogA = new Dog("dogA");

            prototypeRegistry.AddPetPrototype("catA", catA);
            prototypeRegistry.AddPetPrototype("catB", catB);
            prototypeRegistry.AddPetPrototype("dogA", dogA);

            Dog dogCopyA = prototypeRegistry.GetPetPrototypeByKey("dogA").ShallowCopy() as Dog;
            Cat catCopyA = prototypeRegistry.GetPetPrototypeByKey("catA").DeepCopy() as Cat;


        }
    }
}
