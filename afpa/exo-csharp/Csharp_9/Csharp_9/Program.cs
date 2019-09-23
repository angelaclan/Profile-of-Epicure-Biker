using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Csharp_9
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string mail = "santiago@brqgqgnolol.com";


            bool validMail = Regex.IsMatch(mail, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);


        

            Console.WriteLine("Mail valid: " + validMail.ToString());
            Console.ReadLine();

        }
    }
}
