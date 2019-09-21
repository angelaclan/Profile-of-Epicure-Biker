using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_8
{
    class Program
    {
        struct Duration {
            public int years;
            public int months;
            public int days;
        };
        
        static void Main(string[] args)
        {
            DateTime birthdate;
            Console.WriteLine("Please enter your birthdate, then press enter.");
            birthdate = Convert.ToDateTime(Console.ReadLine());
            Duration timeOnEarth = CalculateDurationBetween(birthdate,DateTime.Now) ;
            Console.Write("You have " + timeOnEarth.years + " years " + timeOnEarth.months + " months " + timeOnEarth.days + " days old") ;
            Console.ReadLine();
        }

       static Duration CalculateDurationBetween(DateTime from, DateTime to)
        {
            Duration value = new Duration();
            value.years = to.Year - from.Year;
            value.months = to.Month - from.Month;
            value.days = to.Day - from.Day;


            if (to.Month < from.Month) 
            {
                value.years = value.years - 1;
                value.months = (to.Month - from.Month) + 12;
            }

            if (to.Day < from.Day)
            {
                value.months = value.months - 1;
                value.days = (to.Day - from.Day) + 30;
            }      
            
            return value;
        }
    }




}