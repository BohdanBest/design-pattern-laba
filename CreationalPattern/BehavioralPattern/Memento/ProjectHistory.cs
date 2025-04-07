using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Memento
{
    public class ProjectHistory
    {
        private readonly List<ProjectMemento> _history = new();

        public void Save(Project project, string comment)
        {
            _history.Add(project.Save(comment));
            Console.WriteLine($"Збережено стан: {comment}");
        }

        public void Restore(Project project, int index)
        {
            if (index >= 0 && index < _history.Count)
            {
                project.Restore(_history[index]);
                Console.WriteLine($"Відновлено стан: {_history[index].Comment}");
            }
            else
            {
                Console.WriteLine("Немає стану для відновлення за цим індексом.");
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("Історія змін:");
            for (int i = 0; i < _history.Count; i++)
            {
                Console.WriteLine($"{i}: {_history[i].GetState()} (Коментар: {_history[i].Comment})");
            }
        }
    }
}