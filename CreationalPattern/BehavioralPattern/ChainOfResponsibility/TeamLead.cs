using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.ChainOfResponsibility
{
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
}