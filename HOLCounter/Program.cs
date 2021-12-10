using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis mittu 'h','o' ja 'l' tahte on lauses "Hallo World!"

            Console.WriteLine("Hello World!");
            Console.WriteLine("Kui mitu 'h', ''o' ja 'l' tahte on selles lauses?");
            string HelloWorld = "Hellow World!".ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < HelloWorld.Length; i++)
            {
                if (HelloWorld [i] == 'h')
                {
                    hCounter++;
                }
            }

            if (hCounter == 1)
            {
                Console.WriteLine($"Lauses on {hCounter} 'h' taht.");
            }
            else
            {
                Console.WriteLine($"Lauses on {hCounter} 'h' tahhte.");
            }

            for (int i = 0; i < HelloWorld.Length; i++)
            {
                if (HelloWorld[i] == '0')
                {
                    oCounter++;
                }
                if (oCounter == 1)
                {
                    Console.WriteLine($"Lauses on {oCounter} 'o' taht");
                }
                else
                {
                    Console.WriteLine($"Lauses on {oCounter} 'o' tahte");
                }

                for (int i = 0; i < HelloWorld.Length; i++)

                {     
                    if (HelloWorld[i] == 'l')
                    {
                        lCounter++;
                    }

                }

                if (lCounter == 1)

                    
                {
                        Console.WriteLine($"Lauses on {lCounter} 'l' taht. ");
                    }
                    else
                    {
                        Console.WriteLine($"Lauses on {lCounter} 'l' tahte.");
                    }

                }
            }

        }
    }
 
