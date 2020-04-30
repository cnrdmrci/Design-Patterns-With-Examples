using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.ObjectPool
{
    public sealed class ObjectPoolMultiThread<T> where T : new()
    {
        private static ObjectPoolMultiThread<T> _instance;
        private static readonly object LockObject = new Object();
        private static readonly List<T> Available = new List<T>();
        private static readonly List<T> InUse = new List<T>();
        private int _maxPoolSize;

        private ObjectPoolMultiThread()
        {
            _maxPoolSize = 10; //default 10
        }

        public void Reset()
        {
            lock (LockObject)
            {
                Available.Clear();
                InUse.Clear();
                _instance = new ObjectPoolMultiThread<T>();
                _maxPoolSize = 10;
            }
            
        }

        public static ObjectPoolMultiThread<T> GetInstance()
        {
            if (_instance == null)
            {
                lock (LockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new ObjectPoolMultiThread<T>();
                    }
                }
            }
            return _instance;

        }

        public void SetMaxPoolSize(int maxPoolSize)
        {
            _maxPoolSize = maxPoolSize;
        }

        public T GetItemFromThePool()
        {
            lock (LockObject)
            {
                if (Available.Count > 0)
                {
                    T item = Available[0];
                    InUse.Add(item);
                    Available.RemoveAt(0);
                    return item;
                }

                //Bu kısımda nesne oluşturma işlemi yapılabilir.
                return default(T); //return null;
            }
        }

        public void PutItemInThePool(T item)
        {
            lock (LockObject)
            {
                if (Available.Count <= _maxPoolSize)
                {
                    Available.Add(item);
                    InUse.Remove(item);
                }
            }
        }
    }
}
