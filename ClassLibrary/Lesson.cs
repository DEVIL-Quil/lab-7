using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://docs.google.com/document/d/1KZXfKJussGflgWnWylGbFrwmdcn3liYKIsgmtxB1mN0/edit

namespace ClassLibrary
{
    public class Lesson
    {

        public DateTime dateTime;
        string[] validformats = new[] { "dd/MM/yyyy", "MM/dd/yyyy", "dd-MM-yyyy", "MM-dd-yyyy", };

        public Disciplina Disciplina { get; }
        public Sotrudnik Sotrudnik { get; }
        public Auditoriya Auditoria { get; }
        public Group Group { get; }
        public Para Para { get; }
        public TaskType TaskType { get; }
        public Podrozdelenie Podrozdelenie{get;} 

        public Lesson(DateTime dateTime, Disciplina disciplina, Sotrudnik sotrudnik, Auditoriya auditoria, Group group, Para para, TaskType tasktype, Podrozdelenie podrozdelenie)
        {
            DateTime datetime = dateTime;
            Disciplina = disciplina;
            Sotrudnik = sotrudnik;
            Auditoria = auditoria;
            Group = group;
            Para = para;
            TaskType = tasktype;
            Podrozdelenie = podrozdelenie;
        }
    }
}
