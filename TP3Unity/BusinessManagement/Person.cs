using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using TP3Unity.DataAccess;

namespace TP3Unity.BusinessManagement
{
    class Person
    {
        public IData Data { get; set; }
        public void ListPerson()
        {
            foreach (var a in Data.GetListPerson())
            {
                Console.WriteLine(a.Nom + " " + a.Prenom);
            }
        }

        public bool Addperson(string nom, string prenom)
        {
        return Data.AddPerson(nom, prenom);
    
        }

        public Person()
        {   
        }
    }

    
}
