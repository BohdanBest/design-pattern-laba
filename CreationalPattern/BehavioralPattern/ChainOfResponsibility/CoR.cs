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
}