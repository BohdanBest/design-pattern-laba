using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.ChainOfResponsibility
{
    public class SalaryRequest
    {
        public string EmployeeName { get; }
        public decimal Amount { get; }
        public SalaryRequest(string employeeName, decimal amount) => (EmployeeName, Amount) = (employeeName, amount);
    }

}