using System;
using System.Collections.Generic;
using System.ComponentModel;
using TaskManager.Models;


namespace TaskManager.Services
{
    public class TaskManagerService
    {
        private static readonly List<Models.Task> _tasks = new(); // Lista estática
        private static int _nextId = 1;

        public void AddTask(string title, string description, DateTime dueDate)
        {
            var task = new Models.Task
            {
                Id = _nextId++,
                Title = title,
                Description = description,
                DueDate = dueDate,
                isCompleted = false
            };

            _tasks.Add(task);
        }

        public List<Models.Task> GetTasks()
        {
            return _tasks;
        }

        public void MarkTaskAsCompleted(int id)
        {
            var task = _tasks.Find(t => t.Id == id);
            if (task != null)
            {
                task.isCompleted = true;
            }
        }

        public void RemoveTask(int id)
        {
            var task = _tasks.Find(t => t.Id == id);
            if (task != null)
            {
                _tasks.Remove(task);
            }
        }
    }
}
