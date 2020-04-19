using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Singleton
{
    public sealed class SingletonThreadSafe
    {
        private static SingletonThreadSafe _instance;
        private static readonly object LockObject = new Object();

        private SingletonThreadSafe()
        {
            //Prevent form the reflection api.
            if (_instance != null)
            {
                throw new Exception("Use static Instance property to get the single instance of this class.");
            }
        }

        public static SingletonThreadSafe Instance
        {
            get
            {
                //Double-Checked Locking pattern (DCL)
                if (_instance == null)
                {
                    lock (LockObject)
                    {
                        if (_instance == null)
                            _instance = new SingletonThreadSafe();
                    }
                }

                return _instance;
            }
        }
    }
}
