using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Prototype.Common
{
    [Serializable]
    public abstract class Cloneable<T>
    {
        public virtual T GetShallowCopy()
        {
            return (T)this.MemberwiseClone();
        }

        public virtual T GetDeepCopy()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Position = 0;
            return (T)formatter.Deserialize(stream);
        }
    }
}
