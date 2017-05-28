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
        public static void ListPerson()
        {
            
            IData e = Program.container.Resolve<IData>();
            foreach (var a in e.GetListPerson())
            {
              Console.WriteLine(a.Nom + " " + a.Prenom);
            }
        }

        public static bool Addperson(string nom, string prenom)
        {
            
            IData e = Program.container.Resolve<IData>();
            return e.AddPerson(nom, prenom);
        }
    }

    
}
