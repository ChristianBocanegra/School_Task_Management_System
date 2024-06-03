using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab2And3
{
    internal class Course
    {
        private string code;
        private uint id;
        private string name;
        private byte semester;
        private List<Evaluation> evaluations = new List<Evaluation>();
        private List<Task> tasks = new List<Task>();
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public uint Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public byte Semester
        {
            get { return semester; }
            set { semester = value; }
        }
        public List<Evaluation> Evaluations 
        { 
            get { return evaluations; } 
        }
        public List<Task> Tasks
        {
            get { return tasks; }
        }
        public ushort Grade
        {
            get
            {
                ushort sumGrade = 0;
                foreach (Evaluation number in evaluations)
                {
                    sumGrade += (ushort)(number.Weight * number.Grade);
                }
                return sumGrade;
            }
        }
        public Course(uint id, string code)
        {
            this.id = id;
            this.Code = code;
            this.evaluations = new List<Evaluation>();
            this.tasks = new List<Task>();
        }
        public Task AddTask(string description)
        {
            Task courseTask1 = new Task(description);
            tasks.Add(courseTask1);
            return courseTask1;
        }
        public string TasksToString()
        {
            string AllCourseTask = "Course Task List: ";
            foreach (Task addCourseTask in tasks)
            {
                AllCourseTask += addCourseTask.ToString();
            }
            return AllCourseTask;
        }
        public void AddEvaluation(EvaluationType type, byte weight, string name)
        {
            Evaluation courseEvaluation = new Evaluation(this, type, weight);
            courseEvaluation.Name = name;
            evaluations.Add(courseEvaluation);
        }
        public override string ToString()
        {
            return $"Code: {Code}\n" +
                $"ID: {Id}\n";
        }
    }   
}
