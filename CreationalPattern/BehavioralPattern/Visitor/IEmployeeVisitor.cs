using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Visitor
{
    public interface IEmployeeVisitor
    {
        void Visit(Developer developer);
        void Visit(Manager manager);
    }
}