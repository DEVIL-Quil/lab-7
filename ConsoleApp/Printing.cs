using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    public class Printing
    {
        public static void Print(Lesson lesson)
        {
            Console.WriteLine($"Дата проведения занятия = {lesson.dateTime}");
            Print(lesson.Disciplina);
            Print(lesson.Sotrudnik);
            Print(lesson.Auditoria);
            Print(lesson.Group);
            Print(lesson.Para);
            Print(lesson.TaskType);
        }

        public static void Print(Disciplina disciplina)
        {
           
        }

        public static void Print(Sotrudnik sotrudnik)
        {

        }

        public static void Print(Auditoriya auditoriya)
        {

        }

        public static void Print(Group group)
        {
           
        }

        public static void Print(Para para)
        {

        }

        public static void Print(TaskType taskType)
        {

        }
    }
}
