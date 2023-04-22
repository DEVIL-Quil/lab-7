using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://docs.google.com/document/d/10XwtkjNB6-lRehWP_7qbgWC1nn_oIpa28ezyPXX3B28/edit
namespace ClassLibrary
{
    public class Auditoriya
    {
        public string Название { get; }
        public byte Количество_посадочных_мест { get; }
        public byte Количество_окон { get; }

        public Sotrudnik Sotrudnik { get; }

        public Oborudovanie Oborudovanie { get; }


        public Auditoriya(string название, Sotrudnik sotrudnik, byte количество_посадочных_мест, byte количество_окон, Oborudovanie oborudovanie)
        {
            this.Название = название;
            Sotrudnik = sotrudnik;
            this.Количество_посадочных_мест = количество_посадочных_мест;
            this.Количество_окон = количество_окон;
            Oborudovanie = oborudovanie;
        }
    }
}
