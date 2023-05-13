using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
//https://docs.google.com/document/d/1dhWsZqo-d1x4uk0y45lDVnu4H91wRvpRWKJ0lfCizxY/edit

namespace ClassLibrary
{
    public class Sotrudnik
    {
        public string Фамилия { get; }
        public string Имя { get; }
        public string Отчество { get; }
        public Doljnost Doljnost { get; }
        public Sotrudnik(string фамилия, string имя, string отчество, Doljnost doljnost)
        {
            Фамилия = фамилия;
            Имя = имя;
            Отчество = отчество;
            Doljnost = doljnost;
        }
    }
}
