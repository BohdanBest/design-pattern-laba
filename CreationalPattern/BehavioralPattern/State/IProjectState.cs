using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.State
{
    // Інтерфейс стану
    public interface IProjectState
    {
        void AddTask(ProjectContext context, string task);
        void TestTask(ProjectContext context, string task);
        void Complete(ProjectContext context);
    }
}