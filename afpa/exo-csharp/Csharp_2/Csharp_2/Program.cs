using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("entre oui ou non svp");
            String OBJ = Console.ReadLine();

            while (OBJ.Equals("oui")!=true  && OBJ.Equals("non")!=true)
            {
                OBJ = Console.ReadLine();
            }



            Console.WriteLine($"object:{OBJ}" );
            
        }
    }
}
