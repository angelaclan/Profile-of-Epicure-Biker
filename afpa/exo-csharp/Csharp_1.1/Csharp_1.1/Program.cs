using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1._1
{
    class Program
    {
        static void Main(string[] args)
        
            //1) on demande le nom et le prénom
            Console.WriteLine("Entrer le prenom : ");
        String prenom = Console.ReadLine();

        Console.WriteLine("Entrer le nom : ");
            String nom = Console.ReadLine();

        // on force les 1ere lettres du prénom en majuscule et le reste en minuscule
        string[] tabPrenom = prenom.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        prenom = "";
            foreach(string part in tabPrenom)
            {
                prenom += part.Substring(0,1).ToUpper()+part.Substring(1).ToLower() + "-";
            }
    //retrait du dernier '-'
    prenom = prenom.Substring(0, prenom.Length - 1);
            
            //résultat
            Console.WriteLine("Résultat aprés formatage : ");
            Console.WriteLine(prenom + " " + nom.ToUpper());
        }
    }
        }
    }
}
