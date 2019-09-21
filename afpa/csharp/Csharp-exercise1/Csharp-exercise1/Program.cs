using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("saisir le prenom:");
            String prenom = Console.ReadLine();
            Console.WriteLine("saisir le nom:");
            String nom = Console.ReadLine();
            Console.WriteLine($"prenom : {prenom}, nom: {nom}");
        }
    }
}
