using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using TP3Unity.DataAccess;

namespace TP3Unity.BusinessManagement
{
    class Person : IDisposable
    {
        public IData data { get; set; }
        public void ListPerson()
        {
                foreach (var a in data.GetListPerson())
                {
                    Console.WriteLine(a.Nom + " " + a.Prenom);
                }
        }

        public bool Addperson(string nom, string prenom)
        {
        return data.AddPerson(nom, prenom);
    
        }

        public Person()
        {   
        }

        public void Dispose()
        {
            data.Dispose();
        }
    }

    
}
