using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Composite
{
    public class UsageOfComposite
    {
        public static void Run()
        {
            //Backend team
            //-------------------------------------------------------------------------------
            Developer backendDeveloper1 = new Developer("backendDeveloper1",20);
            Developer backendDeveloper2 = new Developer("backendDeveloper2",25);

            Manager backendTeamLead = new Manager("backendTeamLead",22);
            backendTeamLead.AddWorker(backendDeveloper1);
            backendTeamLead.AddWorker(backendDeveloper2);

            //Frontend team
            //-------------------------------------------------------------------------------
            Developer frontenDeveloper1 = new Developer("frontenDeveloper1", 15);
            Developer frontenDeveloper2 = new Developer("frontenDeveloper2", 18);

            Manager frontendTeamLead = new Manager("frontendTeamLead", 19);
            frontendTeamLead.AddWorker(frontenDeveloper1);
            frontendTeamLead.AddWorker(frontenDeveloper2);

            //all of team
            //-------------------------------------------------------------------------------
            Manager director = new Manager("director", 30);
            director.AddWorker(frontendTeamLead);
            director.AddWorker(backendTeamLead);

            Developer intern = new Developer("intern", 5);
            director.AddWorker(intern);

            Console.WriteLine("Total working time : " + director.GetTotalWorkingTime());
        }
    }
}
