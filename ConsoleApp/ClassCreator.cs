using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ClassLibrary;

namespace ConsoleApp
{
    public class ClassCreator
    {
        public static Lesson Lesson()
        {
            return new Lesson(Datetime(), Disciplina(), Sotrudnik(), Auditoriya(), Group(), Para(), TaskType());
        }

        public static DateTime Datetime()
        {
            Console.WriteLine("Введите дату проведения в числовом формате День/месяц/год");
            string date;
            date = Console.ReadLine() ?? "";
            DateTime My;
            DateTime dateTime;

            string[] validformats = new[] { "dd/MM/yyyy", "MM/dd/yyyy", "dd-MM-yyyy", "MM-dd-yyyy", };

            CultureInfo provider = CultureInfo.InvariantCulture;

            if (DateTime.TryParseExact(date, validformats, provider,
                                        DateTimeStyles.None, out dateTime))
            {
                My = dateTime;
            }
            else
            {
                My = DateTime.Now;
            }
            return My;

        }

        public static Disciplina Disciplina()
        {
            return Disciplina();           
        }

        public static Sotrudnik Sotrudnik()
        {
            return Sotrudnik();
        }

        public static Auditoriya Auditoriya()
        {
            return Auditoriya();
        }

        public static Group Group()
        {
            return Group();
        }

        public static Para Para()
        {
            return Para();

        }

        public static TaskType TaskType()
        {
            return TaskType();

        }
    }
}
