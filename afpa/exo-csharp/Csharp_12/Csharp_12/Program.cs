using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int age, permis, accident, loyalty;

            bool condition1 = age < 25 == true;
            bool condition2 = (permis < 2) == true;
            bool condition3 = (accident < 1) == true;
            bool condition4 = (loyalty <= 5) == true;

            if (condition1 && condition2 && condition3) || (!condition1&&condition2&&!condition3) || (!condition1&&!condition2&&!condition3)
            {
                Console.WriteLine("tarif rouge");
            }
            else (condition1 && !condition2)||(!condition1 && condition2 && !condition3)
            {
                Console.WriteLine("tarif orang");
            }
            else (!condition1 && !condition2 && condition3)
            {
                Console.WriteLine("tarif vert");
            }
        }

        private static bool NewMethod()
        {
            return true;
        }
    }
}
