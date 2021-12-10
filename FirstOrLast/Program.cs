using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada ees-ja perekonna nime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendest on pikkem, kas ees voi perekonnanimi

            Console.WriteLine("Sisestage oma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisestage oma perekonnanimi:");
            string lastName = Console.ReadLine();

            if(firstName.Length < lastName.Length)
            {
                Console.WriteLine($"Sinu eesnimi ({firstName.Length} sumbolit) on luhem kui perekonnanimi ({lastName.Length} sumbolit.");
            }
            
            else if(firstName.Length > lastName.Length)
            
            {
                Console.WriteLine($"Sinu eesnimi ({firstName.Length} sumbolit) on pikem kui perekonnanimi ({lastName.Length}) sumboliy.");


            }
        }
    }
}
