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
            throw new NotImplementedException();
        }

        public bool AddPerson()
        {
            throw new NotImplementedException();
        }
    }
}
