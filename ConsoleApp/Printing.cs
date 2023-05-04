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
            Console.WriteLine($"Название = {disciplina.Название}");
            Console.WriteLine($"Cокращение = {disciplina.Сокращение}");
        }

        public static void Print(Sotrudnik sotrudnik)
        {

        }

        public static void Print(Auditoriya auditoriya)
        {
            Console.WriteLine(auditoriya.Название);
            Print(auditoriya.Sotrudnik);
            Console.WriteLine(auditoriya.Количество_посадочных_мест);
            Console.WriteLine(auditoriya.Количество_окон);
            Print(auditoriya.Oborudovanie);

        }

        public static void Print(Group group)
        {
           
        }

        public static void Print(Para para)
        {
            Console.WriteLine($"Время начала пары = {para.BeginPara}");
            Console.WriteLine($"Время окончания пары = {para.EndPara}");
            Console.WriteLine($"Время начала перерыва = {para.BeginBreak}");
            Console.WriteLine($"Время окончания перерыва = {para.EndBreak}");
            Print(para.Smena);
        }

        public static void Print(TaskType taskType)
        {

        }

        public static void Print(Oborudovanie oborudovanie)
        {

        }
        public static void Print(Smena smena)
        {

        }

        public static void Print(Korpus korpus)
        {
            Console.WriteLine($"Название = { korpus.name }");
            Console.WriteLine($"Адрес = { korpus.address }");
            Console.WriteLine($"Комендант = { korpus.commandant }");
            Console.WriteLine($"Организация = { korpus.organization }");
        }
    }
}
