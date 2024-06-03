using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2And3
{
    internal static class TaskManager
    {
        private static List<Task> tasks;
        public static List<Task> Tasks { get; }
        static TaskManager()
        {
            tasks = new List<Task>();
        }
        static Task CreateTask(string description)
        {
            Task task1 = new Task(description);
            tasks.Add(task1);
            return task1;
        }
        static string AllTasksToString() 
        {
            string allTasks = "List of tasks: ";
            foreach (Task addTask in tasks)
            {
               allTasks += addTask.ToString();
            }
            return allTasks;
        }
    }
}
