using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3Unity.Dbo
{
    public class Person
    {   
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Person(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public Person()
        {
        }
    }
}
