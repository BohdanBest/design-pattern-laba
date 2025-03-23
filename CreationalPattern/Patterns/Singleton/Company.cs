using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.Patterns.Singleton
{
    public class Company
    {
        private static Company _instance;
        public Company() { }
        public static Company Instance
        {
            get
            {
                _instance ??= new Company();
                return _instance;
            }
        }

        public void StartWork() => Console.WriteLine("Company starts working");
    }

}
