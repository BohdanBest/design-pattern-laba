using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.ChainOfResponsibility
{
    public abstract class Approver
    {
        protected Approver NextApprover;
        public void SetNext(Approver next) => NextApprover = next;
        public abstract void ProcessRequest(SalaryRequest request);
    }

    public class SalaryRequest
    {
        public string EmployeeName { get; set; }
        public decimal Amount { get; set; }
    }

    public class TeamLead : Approver
    {
        public override void ProcessRequest(SalaryRequest request)
        {
            if (request.Amount <= 1000)
                Console.WriteLine($"TeamLead схвалив підвищення для {request.EmployeeName} на {request.Amount}$");
            else
                NextApprover?.ProcessRequest(request);
        }
    }

    public class HR : Approver
    {
        public override void ProcessRequest(SalaryRequest request)
        {
            Console.WriteLine($"HR схвалив підвищення для {request.EmployeeName} на {request.Amount}$");
        }
    }
}