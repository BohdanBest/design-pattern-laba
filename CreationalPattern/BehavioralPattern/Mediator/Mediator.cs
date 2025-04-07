using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Mediator
{
    public class CompanyMediator : IMediator
    {
        private readonly List<Department> _departments = new();
        private Department _hrDepartment;
        private Department _financeDepartment;
        private Department _itDepartment;

        public void Register(Department department)
        {
            _departments.Add(department);
            switch (department.Name)
            {
                case "HR":
                    _hrDepartment = department;
                    break;
                case "Finance":
                    _financeDepartment = department;
                    break;
                case "IT":
                    _itDepartment = department;
                    break;
            }
            department.SetMediator(this);
        }

        public void SendRequest(Request request)
        {
            Console.WriteLine($"Mediator: Обробка запиту від {request.Sender.Name} - {request.Message}");
            switch (request.Type)
            {
                case RequestType.HireDeveloper:
                    _hrDepartment?.ReceiveRequest(request);
                    _itDepartment?.ReceiveRequest(request);
                    break;
                case RequestType.UpdateBudget:
                    _financeDepartment?.ReceiveRequest(request);
                    break;
                case RequestType.GeneralMessage:
                    _departments.ForEach(d =>
                    {
                        if (d != request.Sender) d.ReceiveRequest(request);
                    });
                    break;
            }
        }
    }
}