using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Iterator
{
    public interface IEmployeeIterator
    {
        bool MoveNext();
        Employee Current { get; }
        void Reset();
    }
}