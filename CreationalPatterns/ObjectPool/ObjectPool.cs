using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.ObjectPool
{
    public class ObjectPool<T> where T : new()
    {
        private static ObjectPool<T> _instance;
        private static readonly List<T> Available = new List<T>();
        private static readonly List<T> InUse = new List<T>();
        private int _maxPoolSize;

        private ObjectPool()
        {
            _maxPoolSize = 10; //default 10
        }

        public void Reset()
        {
            Available.Clear();
            InUse.Clear();
            _instance = new ObjectPool<T>();
            _maxPoolSize = 10;
        }

        public static ObjectPool<T> GetInstance()
        {
            return _instance ??= new ObjectPool<T>();
        }

        public void SetMaxPoolSize(int maxPoolSize)
        {
            _maxPoolSize = maxPoolSize;
        }

        public T GetItemFromThePool()
        {
            if (Available.Count > 0)
            {
                T item = Available[0];
                InUse.Add(item);
                Available.RemoveAt(0);
                return item;
            }

            return default(T); //return null;
        }

        public void PutItemInThePool(T item)
        {
            if (Available.Count <= _maxPoolSize)
            {
                Available.Add(item);
                InUse.Remove(item);
            }
        }

    }
}
