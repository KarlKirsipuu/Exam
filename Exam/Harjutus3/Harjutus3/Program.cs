using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjutus3
{
    class Program
    {
        static void Main(string[] args)
        {
            int minYear;
            int maxYear;
            int timesToGenerate;
            string userInput;

            do
            {
                Console.Write("Minimaalne aasta: ");
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput, out minYear));

            do
            {
                Console.Write("Maksimaalne aasta: ");
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput, out maxYear));

            do
            {
                Console.Write("Genereeritavate andmete hulk: ");
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput, out timesToGenerate));

            Date dateGenerator = new Date(maxYear, minYear);
            for (int i = 0; i < timesToGenerate; i++)
            {
                Console.WriteLine(dateGenerator.GenerateRandomDay());
            }

            Console.WriteLine();
            Console.WriteLine("Väljumiks vajuta suvalist nuppu.");
            Console.ReadKey();
        }


    }



}


