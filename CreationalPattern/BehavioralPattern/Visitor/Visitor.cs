using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CreationalPattern.BehavioralPattern.Visitor
{
    public interface IEmployeeVisitor
    {
        void Visit(Developer developer);
    }

    public interface IEmployee
    {
        void Accept(IEmployeeVisitor visitor);
    }

    public class SalaryCalculator : IEmployeeVisitor
    {
        public void Visit(Developer developer) => Console.WriteLine($"Розрахунок ЗП для розробника: 3000$");

    }

}