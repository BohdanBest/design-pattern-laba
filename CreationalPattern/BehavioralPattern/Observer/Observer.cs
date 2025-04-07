using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Observer
{

    public class EmployeeObserver : IObserver
    {
        private readonly string _name;

        public EmployeeObserver(string name) => _name = name;

        public void Update(ProjectEvent projectEvent)
        {
            switch (projectEvent.EventType)
            {
                case ProjectEventType.StatusChanged:
                    Console.WriteLine($"{_name} (Співробітник): Статус проєкту змінено на '{projectEvent.Details}'");
                    break;
                case ProjectEventType.DeadlineUpdated:
                    Console.WriteLine($"{_name} (Співробітник): Новий дедлайн: {projectEvent.Details}");
                    break;
                case ProjectEventType.NameChanged:
                    Console.WriteLine($"{_name} (Співробітник): Назва проєкту змінена на '{projectEvent.Details}'");
                    break;
            }
        }
    }

    public class ManagerObserver : IObserver
    {
        private readonly string _name;

        public ManagerObserver(string name) => _name = name;

        public void Update(ProjectEvent projectEvent)
        {
            switch (projectEvent.EventType)
            {
                case ProjectEventType.StatusChanged:
                    Console.WriteLine($"{_name} (Менеджер): Статус оновлено: {projectEvent.Details}. Перевіряю графік.");
                    break;
                case ProjectEventType.DeadlineUpdated:
                    Console.WriteLine($"{_name} (Менеджер): Дедлайн змінено на {projectEvent.Details}. Оновлюю план.");
                    break;
                case ProjectEventType.NameChanged:
                    Console.WriteLine($"{_name} (Менеджер): Нова назва проєкту: {projectEvent.Details}. Оновлюю документацію.");
                    break;
            }
        }
    }
}