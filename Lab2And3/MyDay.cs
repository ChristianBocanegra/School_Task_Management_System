using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2And3
{
    internal class MyDay
    {
        private DateTime date;
        private List<Task> todaysTasks;
        private static MyDay currentDay;
        public List<Task> TodaysTasks 
        { 
            get { return todaysTasks; } 
        }
        private MyDay () 
        {
            this.date = DateTime.Now;
            todaysTasks = new List<Task> ();
        }
        public static MyDay NewDay()
        {
            if (currentDay == null || currentDay.date != DateTime.Today)
            {
                currentDay = new MyDay();
            }
            return currentDay;
            
        }
        public void AddDayTask(Task task)
        {
            todaysTasks.Add(task);
        }
        public override string ToString()
        {
            string currentTaskDay = "List of tasks for the current day: ";
            foreach (Task addCurrentTaskDay in todaysTasks) 
            { 
                currentTaskDay += addCurrentTaskDay.ToString();
            }
            return currentTaskDay;
        }
    }
}
