using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
//https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit

namespace ClassLibrary
{
    public class Group
    {
        private readonly string name;
        public string Name { get => name; }

        private readonly string shortname;
        public string Shortname { get => shortname; }

        private readonly byte chislennost;
        public byte Chislennost { get => chislennost; }

        private readonly short yearPostyp;
        public short YearPostyp { get => yearPostyp; }

        private readonly Spetialization specialnost;
        public Spetialization Specialnost { get => specialnost; }


        private readonly Sotrudnik classleader;
        public Sotrudnik ClassLeader { get => classleader; }

        public Group(string name, string shortname, byte chislennost, short yearPostyp, Spetialization specialnost, Sotrudnik classleader)
        {
            this.name = name;
            this.shortname = shortname;
            this.chislennost = chislennost;
            this.yearPostyp = yearPostyp;
            this.specialnost = specialnost;
            this.classleader = classleader;
        }
    }
}
