using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Bridge.Abstract
{
    public interface IDatabase
    {
        void Save(string data);
    }
}
