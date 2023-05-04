using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// https://docs.google.com/document/d/13_TXjBoKn0TzKMcWP9A6jX2vyQEgcxBc4vY1CfJn9ps/edit

namespace ClassLibrary
{
    class Korpus
    {
        public string name { get; }
        public string address { get; }
        public Sotrudnik commandant { get; }
        public Organization organization { get; } 

        public Corps(string name, string address, Sotrudnik commandant, Organization organization)
        {
            this.name = name;
            this.address = address;
            this.commandant = commandant;
            this.organization = organization;
        }

    }
}
