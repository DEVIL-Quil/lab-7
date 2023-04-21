using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;


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
                   
                    default: Console.WriteLine("Такой класс не реализован"); break;

                }
            }
        }

    }
}
