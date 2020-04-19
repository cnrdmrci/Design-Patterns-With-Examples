using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Singleton
{
    public class SingletonCalculator
    {
        private string _log;
        private static int _counter;
        private static SingletonCalculator _instance;
        private static readonly object LockObject = new Object();

        private SingletonCalculator() { }

        public static SingletonCalculator Instance
        {
            get
            {
                //Double-Checked Locking pattern (DCL)
                if (_instance == null)
                {
                    lock (LockObject)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingletonCalculator();
                            _counter = 0;
                        }
                            
                    }
                }

                return _instance;
            }
        }

        public double Addition(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            addLog(result);
            
            return result;
        }

        public double Substraction(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            addLog(result);

            return result;
        }

        private void addLog(double result)
        {
            //you can do thread safe
            _counter++;
            _log += _counter + ".Calculate)  " + result + "\n";
        }

        public string GetAllLog()
        {
            return _log;
        }

    }
}
