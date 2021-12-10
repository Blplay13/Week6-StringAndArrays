using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada ees- ja perekonnanime;
            //programm kuvab, minu 'a' tahte kasutaja ees ja perekonnanimes kokku

            Console.WriteLine("Palun sisesta oma eesnimi:");
            string fistName = Console.ReadLine();
            Console.WriteLine("Palun sisesta oma perekonnanimi");
            string lastName = Console.ReadLine();

            string fullName = ("${firstname}{lastname}".ToLower()
                );

            Console.WriteLine(fullName);

            int aCounter = 0;

            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'a')
                {
                    aCounter++;

                }

                if (aCounter == 1)
                {
                    Console.WriteLine($"Sinu taisnimes on {aCounter} 'a' taht");
                }
                else
                {
                    Console.WriteLine($"Sinu taisnimes on {aCounter} 'a' tahte.");
                }
            }
        }
    }
}
