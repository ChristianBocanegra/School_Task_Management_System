using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2And3
{
    internal class Evaluation
    {
        private Guid id;
        private EvaluationType type;
        private string name;
        private DateTime dueDate;
        private byte weight;
        private byte grade;
        private Course course;
        private List<Task> tasks = new List<Task>();
        private string textFile;
        public EvaluationType Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }
        public byte Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public byte Grade 
        { 
            get { return grade; } 
            set { grade = value; } 
        }
        public List<Task> Tasks
        {
            get { return tasks; }
        }
        public Course Course
        {
            get { return course; }
        }
        public string TextFile
        {
            get { return textFile; }
            set { textFile = value; }
        }
        public Guid Id
        {
            get { return id; }
        }
        public Evaluation(Course course, EvaluationType type, byte weight)
        {
            this.course = course;
            this.Type = type;
            this.Weight = weight;
            course.Evaluations.Add(this);
        }
        public Task AddTask(string description)
        {
            Task evaluationTask1 = new Task(description);
            tasks.Add(evaluationTask1);
            return evaluationTask1;
        }
        public string TasksToString()
        {
            string allEvaluationTask = "List of evaluation tasks: ";
            foreach (Task addEvaluationTask in tasks)
            {
                allEvaluationTask += addEvaluationTask.ToString();
            }
            return allEvaluationTask;
        }
        public override string ToString()
        {
            return $"Evaluation Name: {Name}\n" +
                $"Type: {Type}\n" +
                $"Due Date: {DueDate}\n" +
                $"Weight: {Weight}\n" +
                $"Grade: {Grade}\n";
        }
    }
}
