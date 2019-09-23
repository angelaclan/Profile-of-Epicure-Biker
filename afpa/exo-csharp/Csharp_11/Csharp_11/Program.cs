using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre votre sex");
            string sex = Console.ReadLine();
            Console.WriteLine("Entre votre l'age");
            int age = int.Parse(Console.ReadLine());

            bool condition1 = true;
            condition1 = (sex == "homme" && age >= 21);
            bool condition2 = true;
            condition2 = (sex == "femme" && (age <18 && age >= 40));


            if (condition1 || condition2)
            {
                Console.WriteLine("taxable");
            }
            else
            {
                Console.WriteLine("non taxable");
            }

            Console.ReadLine();
        }
    }
}
