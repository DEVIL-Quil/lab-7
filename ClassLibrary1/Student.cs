using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
//https://docs.google.com/document/d/1FrtPd2tz85cDVhZCYXqL0wrByPjNbd6kUbjXzOzfLPc/edit

namespace ClassLibrary
{
    public class Student
    {
        public string Фамилия { get; }
        public string Имя { get; }
        public string Отчество { get; }
        public Group Group { get; }
        public DateTime ДатаРождения { get; }
        public Student(string фамилия, string имя, string отчество, Group group)
        : this(фамилия, имя, отчество, group, DateTime.Today)
        {

        }
        public Student(string фамилия, string имя, string отчество, Group group, DateTime датаРождения)
        {
            Фамилия = фамилия;
            Имя = имя;
            Отчество = отчество;
            Group = group;
            ДатаРождения = датаРождения;
        }
    }
}
