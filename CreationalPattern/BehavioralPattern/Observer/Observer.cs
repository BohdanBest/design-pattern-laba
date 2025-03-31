using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Observer
{
    public interface IObserver
    {
        void Update(string message);
    }

    public class EmployeeObserver : IObserver
    {
        public void Update(string message) => Console.WriteLine($"Співробітник отримав повідомлення: {message}");
    }

    public class ProjectSubject
    {
        private readonly List<IObserver> _observers = new();
        public void Attach(IObserver observer) => _observers.Add(observer);
        public void Notify(string message) => _observers.ForEach(o => o.Update(message));
    }
}