using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number one : ");
            string num1 = Console.ReadLine();
            Console.Write("Enter number two : ");
            string num2 = Console.ReadLine();

            Random rnd = new Random();

            
            Console.Write("The random number :" + rnd);
            Console.WriteLine();
        }
    }
}
