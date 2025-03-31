using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Visitor
{
    public class Developer : IEmployee
    {
        public string Name { get; set; }

        public void Accept(IEmployeeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}