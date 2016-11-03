using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest1
{
    class Program
    {
        static void Main(string[] args)
        {



            Count();

            PrintSomeText();
            //Kommentar

        }

        private static void Count()
        {
            Console.WriteLine("Lägg ihop två tal!");
            Console.WriteLine("Skriv in tal 1!");
            string strnr1 = Console.ReadLine();
            int nr1 = Convert.ToInt32(strnr1);
            Console.WriteLine("Skriv in tal 2!");

            string strnr2 = Console.ReadLine();
            int nr2 = Convert.ToInt32(strnr2);

            /*Korrigerade - till + så att uträkningen fungerar som den ska
              - Kristoffer
            */ 
            int sum = nr1 + nr2;
            Console.WriteLine("Summan är: " + sum);

            //För att ställa till det
            //För att ställa till det

        }

        private static void PrintSomeText()
        {
            Console.WriteLine("NuNu får du nååååt att bita i Johan");  //Ny kommentar lkjlkjlkjlkjafdfasdfadf
        }

    }
}
