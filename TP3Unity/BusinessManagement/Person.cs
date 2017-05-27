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
            Container container = new Container();
            IData e = container.Resolve<IData>();
            foreach (var a in e.GetListPerson())
            {
                          
            }
            
            
        }
    }
}
