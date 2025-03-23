using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreationalPattern.Patterns.Singleton;
using CreationalPattern.Patterns.FactoryMethod;

namespace CreationalPattern.StructuralPattern.Facade
{
    public class CompanyFacade
    {
        public static void StartCompany()
        {
            Console.WriteLine("Компанія запущена:");
            new Company().StartWork();
            new DeveloperFactory().CreateEmployee().Work();
        }
    }
}