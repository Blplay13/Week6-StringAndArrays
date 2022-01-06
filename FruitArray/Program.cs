using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis puuvilja kasutaja soob

            //string[] fruit = new string[5];
            string[] fruit = new string[5] { "an apple", "a banana", "a lemon", "an avacado", "an orange" };

            //Console.WriteLine(fruit[0]);
            //Console.WtiteLine(fruit[1]);
            //...

            //Console.WriteLine("enter a number from 0 to 4:");
            //int userName = Convert.ToInt32(Console.Readline());
            Random rnd = new Random();
            int userNumber = rnd.Next(0, fruit.Length);

            Console.WriteLine($"Today you will have fruit{fruit[userNumber]}.");
        }
    }
}
