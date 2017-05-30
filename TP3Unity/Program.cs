using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using TP3Unity.BusinessManagement;
using TP3Unity.DataAccess;

namespace TP3Unity
{
    class Program
    {
        static void Main(string[] args)
        {
            Container container = new Container();
            container.Configure();
            Person e = new Person();
            e.data = container.Resolve<IData>();
            string line = "y";
            using (e)
            {

                do
                {
                    e.ListPerson();
                    Console.Write("Nom ? :");
                    var nom = Console.ReadLine();
                    Console.Write("Prenom ? :");
                    var prenom = Console.ReadLine();
                    e.Addperson(nom, prenom);
                    e.ListPerson();
                    Console.WriteLine("leave ? [y,n]");
                    line = Console.ReadLine();
                } while (line == "y" || line == "Y");

            }
        }
    }
}
