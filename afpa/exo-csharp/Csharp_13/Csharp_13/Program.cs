using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_13
{

    class Swallow
    {
        Int64 energy = 0;

        public Int64 howMuchEnergyYouHave ()
        {
            return this.energy;
        }

        public void eat(Int64 grammes) {
            this.energy = this.energy  + 10 * grammes;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Swallow pepita = new Swallow();
            pepita.eat(200);

            Console.WriteLine("Pepitas energy is:"+ pepita.howMuchEnergyYouHave().ToString());


            Console.Write("Entry number at choice");
            string num = Console.ReadLine();
           
            Object[] myArray = new object[Convert.ToInt32(num)];


        }
    }
}
