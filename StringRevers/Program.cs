using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRevers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab kasutaja eesnime tagurpidi

            Console.WriteLine("Sisestama oma eesnimi:");
            string firstName = Console.ReadLine();

            for(int i = firstName.Length - 1; i >= 0; i--)
            {
                Console.Write(firstName[i]);
            
            }
        }
        
    }
}
