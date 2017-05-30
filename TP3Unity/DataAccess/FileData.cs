using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity.ObjectBuilder;
using TP3Unity.Dbo;

namespace TP3Unity.DataAccess
{
    class FileData : IData 
    {
        public StreamWriter Writer { get; set; }
        public List<Person> Persons { get; set; }

        public List<Person> GetListPerson()
        {
            return Persons;
        }

        public bool AddPerson(string nom, string prenom)
        {
            int count = Persons.Count;
            Person person = new Person("Txt_" + nom, "Txt_" + prenom);
            Persons.Add(person);
            Writer.WriteLine(person.Nom + " " + person.Prenom);

            return count < Persons.Count;
        }

        public FileData()
        {   Persons = new List<Person>();
            Writer = new StreamWriter("out.txt");

            AddPerson("Dirk", "Pitt");
            AddPerson("Clive", "Cussler");
            AddPerson("Patricia", "Corwell");
        }

        public void Dispose()
        {
            Writer.Dispose();
        }
    }
}
