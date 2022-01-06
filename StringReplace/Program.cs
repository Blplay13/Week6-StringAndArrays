using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab koik 'o' tahed lauses "Hello World!" tarniga*

            string helloW = "Hello World!";

            /* for(int i = 0; i < helloW.Length; i++)
             
            {
            helloW[i] = '*';//sonad on muutumatu
            }*/

            helloW = helloW.Replace('o', '*');
            helloW = helloW.Replace('!', '1');
            Console.WriteLine(helloW);
        }
    }
}
