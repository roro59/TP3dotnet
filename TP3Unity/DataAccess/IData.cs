using System;
using System.Collections.Generic;
using TP3Unity.Dbo;

namespace TP3Unity.DataAccess
{
    public interface IData : IDisposable
    {
        List<Person> Persons { get; set; }
        List<Person> GetListPerson();
        bool AddPerson(string nom, string prenom);
    } 
}
