using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using ConsoleApp;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Какой класс Вы хотите создать: ");
                switch (Console.ReadLine())
                {
                    case "Занятие": Printing.Print(ClassCreator.Lesson()); break;

                    case "Пара": Printing.Print(ClassCreator.Para()); break;

                    case "Аудитория": Printing.Print(ClassCreator.Auditoriya()); break;

                    case "Дисциплина": Printing.Print(ClassCreator.Disciplina()); break;

                    case "Корпус": Printing.Print(ClassCreator.Korpus()); break;

                    default: Console.WriteLine("Такой класс не реализован"); break;

                }
            }
        }

    }
}
