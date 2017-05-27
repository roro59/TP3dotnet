using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3Unity.Dbo;

namespace TP3Unity.DataAccess
{
    class MemoryData : IData
    {
        public List<Person> Persons { get; set; }
        public List<Person> GetListPerson()
        {
            return Persons;
        }

        public bool AddPerson(string nom, string prenom)
        {
            int count = Persons.Count;
            Persons.Add(new Person(nom, prenom));
            return count < Persons.Count;
        }
        public MemoryData()
        {
            Persons = new List<Person>();
            AddPerson("Dirk", "Pitt");
            AddPerson("Clive", "Cussler");
            AddPerson("Patricia", "Corwell");
        }
    }
}
