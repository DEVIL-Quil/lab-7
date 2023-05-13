using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
// https://docs.google.com/document/d/13_TXjBoKn0TzKMcWP9A6jX2vyQEgcxBc4vY1CfJn9ps/edit

namespace ClassLibrary
{
    public class Korpus
    {
        public string Name { get; }
        public string Address { get; }
        public Sotrudnik Commandant { get; }
        public Organization Organization { get; }

        public Korpus(string name, string address, Sotrudnik commandant, Organization organization)
        {
            this.Name = name;
            this.Address = address;
            this.Commandant = commandant;
            this.Organization = organization;
        }

    }
}
