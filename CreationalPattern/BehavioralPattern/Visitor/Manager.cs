using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Visitor
{
    public class Manager : IEmployee
    {
        public string Name { get; }
        public int YearsOfExperienceInManagement { get; }
        public int ProjectsManaged { get; }

        public Manager(string name, int yearsOfExperienceInManagement, int projectsManaged)
        {
            Name = name;
            YearsOfExperienceInManagement = yearsOfExperienceInManagement;
            ProjectsManaged = projectsManaged;
        }

        public void Accept(IEmployeeVisitor visitor) => visitor.Visit(this);

        public override string ToString() => $"{Name} (Менеджер, Досвід: {YearsOfExperienceInManagement} роки, Проєкти: {ProjectsManaged})";
    }
}