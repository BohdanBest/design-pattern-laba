using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.Patterns.Builder
{
    public class Project
    {
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public List<string> TeamMembers { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Project Name: {Name}, Budget: {Budget}, Team Members: {string.Join(", ", TeamMembers)}");
        }
    }

    public class ProjectBuilder
    {
        private readonly Project _project = new();

        public ProjectBuilder SetName(string name)
        {
            _project.Name = name; return this;
        }
        public ProjectBuilder SetBudget(decimal budget)
        {
            _project.Budget = budget; return this;
        }
        public ProjectBuilder AddTeamMember(string teamMembers)
        {
            _project.TeamMembers ??= [];
            _project.TeamMembers.Add(teamMembers);
            return this;
        }
        public Project Build() => _project;
    }

}