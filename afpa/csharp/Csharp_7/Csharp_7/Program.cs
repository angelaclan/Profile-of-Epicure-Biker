using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("La date d'aujourd'hui :");
            int today =  int.Parse( DateTime.Now.ToString ("yyyyMMdd"));
            Console.WriteLine(today);
            Console.WriteLine("Entrez votre date de la naissance : yyyymmdd");
            string birthday = Console.ReadLine();
            int dob = int.Parse(birthday);
            int age = (today - dob)/10000;
            Console.WriteLine("Vous avez " +age+ " ans");
            Console.ReadLine();

        }
    }
}
