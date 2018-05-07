using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjutus2
{
    class Program
    {
        static readonly List<string> nimed = new List<string> { "Kaur", "Mattias", "Kristel", "Heleri", "Trevor", "Kristjan", "Kelli", "Kevin", "Maarika", "Laura" };
        static void Main(string[] args)
        {
            /*  Sul on programmis defineeritud massiiv järgnevate nimedega: Kaur, Mattias, Kristel, Heleri, Trevor, Kristjan, Kelli, Kevin, Maarika, Laura.
                Programm küsib kasutaja käest sisendit.Sisendiks võib olla üks sõna, lause või miks mitte ka 10 lauset.Ülesanne on kasutajale programmi lõpus kuvada tema sisestatud sisend, aga nii, et kõik nimed oleks kindlasti suure algustähega.
                Näiteks kui kasutaja sisestab teksti: „kevin ja heleri mängisid koos liivakastis. trevor vaatas pealt ning kristel kiikus.“ siis tulemuseks peab olema: „Kevin ja Heleri mängisid koos liivakastis. Trevor vaatas pealt ning Kristel kiikus.“
            */

            Console.WriteLine("Sisesta lause ja programm muudab nimed suurteks tahtedeks.");

            Console.WriteLine();

            Console.Write("Sisend: ");
            string input = Console.ReadLine().Trim();

            Console.WriteLine();

            Console.WriteLine("Valjund: " + MakeNamesCapital(input));

            Console.WriteLine();
            Console.WriteLine("Valjumiseks vajuta suvalist nuppu.");
            Console.ReadKey();


        }
        static string MakeNamesCapital(string input)
        {
            string outputString = "";
            List<string> inputList = new List<string>(input.Split(' '));
            List<string> outputList = new List<string>();

            foreach (string sona in inputList)
            {
                if (sona.Length > 1)
                {
                    string word = char.ToUpper(sona[0]) + sona.Substring(1).ToLower();

                    if (nimed.Contains(word))
                    {
                        outputList.Add(word);
                    }
                    else
                    {
                        outputList.Add(sona);
                    }
                }
                else
                {
                    outputList.Add(sona);
                }
            }

            foreach (string sona in outputList)
            {
                if (sona != "." && sona != "," && sona != "!" && sona != "?")
                {
                    outputString += sona + " ";
                }
                else
                {
                    outputString += sona;
                }
            }

            return outputString;
        }
    }
}
