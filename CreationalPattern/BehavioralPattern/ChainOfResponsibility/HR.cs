using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.ChainOfResponsibility
{
    public class HR : Approver
    {
        public override void ProcessRequest(SalaryRequest request)
        {
            if (request.Amount <= 5000)
                Console.WriteLine($"HR схвалив підвищення для {request.EmployeeName} на {request.Amount}$");
            else
                Console.WriteLine($"Запит {request.EmployeeName} на {request.Amount}$ відхилено");
        }
    }
}