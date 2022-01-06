using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWorldReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello, World!" tagurpidi;

            string HelloWorld = "Hello, World!";

            for (int i = HelloWorld.Length - 1; i >= 0; i--)

            {
                Console.Write(HelloWorld[i]);
            }
        }
    }
}
