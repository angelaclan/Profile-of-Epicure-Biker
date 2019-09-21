using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Entry a number");
           int number = int.Parse(Console.ReadLine());

            while (number < 0 || number > 9) 
            {
                Console.WriteLine("Entry a number");
                number = int.Parse(Console.ReadLine());

            }


        }
    }
}
//et insiste tant que l’utilisateur ne tape pas un chiffre compris entre 0 et 9