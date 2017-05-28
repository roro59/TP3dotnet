using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3Unity.BusinessManagement;

namespace TP3Unity
{
    class Program
    {
        public static Container container = new Container();
        static void Main(string[] args)
        {
           
            container.Configure();
            Person.ListPerson();
            Console.Write("Nom ? :");
            var nom = Console.ReadLine();
            Console.Write("Prenom ? :");
            var prenom = Console.ReadLine();
            Person.Addperson(nom, prenom);
            Person.ListPerson();
            Console.ReadLine();

        }
    }
}
