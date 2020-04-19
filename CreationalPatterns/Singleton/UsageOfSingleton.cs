using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Singleton
{
    public class UsageOfSingleton
    {
        public static void Run()
        {
            double resultAddition = SingletonCalculator.Instance.Addition(8, 5);
            double resultSubstraction = SingletonCalculator.Instance.Substraction(8, 5);

            Console.WriteLine("Addition: "+resultAddition + ", Substraction: " + resultSubstraction + "\n");

            string logs = SingletonCalculator.Instance.GetAllLog();
            Console.WriteLine("Logs: \n" + logs);

        }
    }

}
