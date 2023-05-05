using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    
        public class Podrozdelenie
        {
            public string Name { get; }
            public Sotrudnik Rycovoditel { get; }

            public Organization Organization { get; }
            public Podrozdelenie(string name, Sotrudnik rycovoditel, Organization organization)
            {
                Name = name;
                Rycovoditel = rycovoditel;
                Organization = organization;
            }
        }
    
}
