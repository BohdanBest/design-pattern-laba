using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Observer
{
    public class ProjectEvent
    {
        public ProjectEventType EventType { get; }
        public string Details { get; }

        public ProjectEvent(ProjectEventType eventType, string details)
        {
            EventType = eventType;
            Details = details;
        }
    }
}