using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Visitor
{
    public class Developer : IEmployee
    {
        public string Name { get; }
        public int YearsOfExperience { get; }
        public int LinesOfCodeWritten { get; }

        public Developer(string name, int yearsOfExperience, int linesOfCodeWritten)
        {
            Name = name;
            YearsOfExperience = yearsOfExperience;
            LinesOfCodeWritten = linesOfCodeWritten;
        }

        public void Accept(IEmployeeVisitor visitor) => visitor.Visit(this);

        public override string ToString() => $"{Name} (Розробник, Досвід: {YearsOfExperience} роки, Код: {LinesOfCodeWritten} рядків)";
    }
}