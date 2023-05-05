using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// https://docs.google.com/document/d/1qCEMkbMRvvHP361IFDeWgSpHfVRUp6BV67nrsjl3fSw/edit

namespace ClassLibrary
{
    public class Disciplina
    {
        public string Название { get; }
        public string Сокращение { get; }
        public Disciplina(string название , string сокращение ) 
        {
            Название = название;
            Сокращение = сокращение;

        }
    }
}
