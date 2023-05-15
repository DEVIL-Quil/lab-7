using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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
            Console.WriteLine($"сотрудник.Фамилия = {sotrudnik.Фамилия}");
            Console.WriteLine($"сотрудник.Имя = {sotrudnik.Имя}");
            Console.WriteLine($"сотрудник.Отчество = {sotrudnik.Отчество}");
            Print(sotrudnik.Doljnost);
        }

        public static void Print(Auditoriya auditoriya)
        {
            Console.WriteLine(auditoriya.Название);
            Print(auditoriya.Sotrudnik);
            Console.WriteLine(auditoriya.Количество_посадочных_мест);
            Console.WriteLine(auditoriya.Количество_окон);
            Print(auditoriya.Oborudovanie);

        }

        public static void Print(ClassLibrary.Group group)
        {
            Console.WriteLine(group.Name);
            Console.WriteLine(group.Shortname);
            Console.WriteLine(group.Chislennost);
            Console.WriteLine(group.YearPostyp);
            Print(group.Specialnost);
            Print(group.ClassLeader);
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
            Console.WriteLine($"Смена = {smena.Name}");
        }

        public static void Print(Korpus korpus)
        {
            Console.WriteLine($"Название = {korpus.Name}");
            Console.WriteLine($"Адрес = {korpus.Address}");
            Print(korpus.Commandant);
            Print(korpus.Organization);
        }
        public static void Print(Doljnost doljnost)
        {

        }
        public static void Print(Organization organization)
        {

        }

        public static void Print(Spetialization spetialization)
        {
            Console.WriteLine($"специальность.Название = {spetialization.Название}");
            Console.WriteLine($"специальность.Сокращение = {spetialization.Сокращение}");
        }
        public static void Print(Student student)
        {
            Console.WriteLine($"студент.Фамилия = {student.Фамилия}");
            Console.WriteLine($"студент.Имя = {student.Имя}");
            Console.WriteLine($"студент.Отчество = {student.Отчество}");
            Console.WriteLine($"студент.Дата_рождения = {student.ДатаРождения.ToShortDateString()}");
            Print(student.Group);
        }
    }
}
