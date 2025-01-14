﻿namespace TaskManager.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool isCompleted { get; set; }

        public override string ToString()
        {
            return $"{Id}:{Title} - {Description} | {(isCompleted ? "Concluída" : "Pendente")}";
        }
    }
}
