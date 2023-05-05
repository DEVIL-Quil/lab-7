using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://docs.google.com/document/d/1pDw7bbBJDmeqT8VVwp68BSOF_4yd9cNb9xpH_q2KW0E/edit

namespace ClassLibrary
{
    public class Spetialization
    {
        public string Название { get; }
        public string Сокращение { get; }
        public Spetialization(string название, string сокращение)
        {
            Название = название;
            Сокращение = сокращение;
        }
    }
}