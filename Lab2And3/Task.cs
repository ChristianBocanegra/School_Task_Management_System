using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab2And3
{
    internal struct Task
    {
        public string Description;
        private bool done;
        public DateTime DueDate;

        public bool Done
        {
            get { return done; }
            set { done = value; }
        }
        public Task(string description)
        {
            this.Description = description;
            this.done = false;
            this.DueDate = DateTime.MaxValue;
        }
        public override string ToString()
        {
            return $"{Description} ,";
        }
    }
}
