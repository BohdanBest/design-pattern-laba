using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Observer
{

    public class ProjectSubject
    {
        private readonly List<IObserver> _observers = new();
        private string _name;
        private string _status;
        private DateTime _deadline;

        public ProjectSubject(string name, string status, DateTime deadline)
        {
            _name = name;
            _status = status;
            _deadline = deadline;
        }

        public void Attach(IObserver observer) => _observers.Add(observer);
        public void Detach(IObserver observer) => _observers.Remove(observer);

        private void Notify(ProjectEvent projectEvent) =>
            _observers.ForEach(observer => observer.Update(projectEvent));

        public void ChangeName(string newName)
        {
            _name = newName;
            Notify(new ProjectEvent(ProjectEventType.NameChanged, _name));
        }

        public void ChangeStatus(string newStatus)
        {
            _status = newStatus;
            Notify(new ProjectEvent(ProjectEventType.StatusChanged, _status));
        }

        public void ChangeDeadline(DateTime newDeadline)
        {
            _deadline = newDeadline;
            Notify(new ProjectEvent(ProjectEventType.DeadlineUpdated, _deadline.ToString("yyyy-MM-dd")));
        }

        public override string ToString() => $"Проєкт: {_name}, Статус: {_status}, Дедлайн: {_deadline:yyyy-MM-dd}";
    }
}