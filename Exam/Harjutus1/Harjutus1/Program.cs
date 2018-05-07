using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjutus1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta erinevaid nimesid ja programm koostab neist nimekirja.");
            Console.WriteLine("Lõpetamiseks siseta '-1'.");

            string input = " ";

            List<string> sõnad = new List<string>();


            while (input != "-1")
            {
                Console.Write("Sisesta nimi : ");
                input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    input = input.First().ToString().ToUpper() + input.Substring(1);
                }

                if (input != "-1" && input != "")
                {

                    sõnad.Add(input);
                }

            }

            Console.WriteLine();
            Console.WriteLine("Sisetatud nimed: ");

            Console.WriteLine(String.Join(" ,", sõnad));
            Console.WriteLine();


            Console.WriteLine("Väljumiseks vajuta suvalist klahvi.");
            Console.ReadKey();

        }
    }
}
