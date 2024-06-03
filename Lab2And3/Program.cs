using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2And3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Course course1 = new Course(100, "COMP123");
            Course course2 = new Course(200, "COMP125");
            Console.WriteLine(course1);
            Console.WriteLine(course2);
            
            course1.AddEvaluation(EvaluationType.Assignment, 10, "Assignment 1");
            course1.AddEvaluation(EvaluationType.Assignment, 5, "Assignment 2");
            course1.AddEvaluation(EvaluationType.Quiz, 30, "Quiz 1");
            course1.AddEvaluation(EvaluationType.Test, 30, "Final Test");
            
            course2.AddEvaluation(EvaluationType.Assignment, 15, "Assignment 1");
            course2.AddEvaluation(EvaluationType.Assignment, 10, "Assignment 2");
            course2.AddEvaluation(EvaluationType.Assignment, 10, "Assignment 3");
            course2.AddEvaluation(EvaluationType.Test, 25, "Midterm Test");
            
            Console.WriteLine(course1);
            Console.WriteLine(course2);
            
            course1.Evaluations[0].DueDate = new DateTime(2024, 10, 1);
            
            course1.Evaluations[0].Grade = 65;
            
            course1.Evaluations[1].Grade = 98;
            
            Console.WriteLine(course1);
            
            course1.AddTask("task1");
            
            Task tempTask = course1.Tasks[0];
            tempTask.DueDate = new DateTime(2024, 9, 25);
            course1.Tasks[0] = tempTask;
            
            Task task2 = course1.AddTask("task2");
            
            Console.WriteLine(course1.TasksToString());
            
            course1.Evaluations[1].AddTask("Revise chapter 9 and 7");
            
            Console.WriteLine(course1.Evaluations[1].TasksToString());
            
            MyDay myDay = MyDay.NewDay();
            
            tempTask = course1.Tasks[0];
            tempTask.Done = true;
            course1.Tasks[0] = tempTask;

            myDay.AddDayTask(course1.Tasks[0]);
            myDay.AddDayTask(course1.Tasks[1]);
            
            Console.WriteLine(myDay.ToString());
        }        
    }
}
