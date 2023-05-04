using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Specialnost
    {
        public string Название { get; }
        public string Сокращение { get; }
        public Specialnost(string название, string сокращение)
        {
            Название = название;
            Сокращение = сокращение;
        }
    }
}
