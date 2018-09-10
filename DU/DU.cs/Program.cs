using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DU.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket program/uppgift vill du köra? (1-7)");
            int inputPr = Convert.ToInt32(Console.ReadLine());

            switch (inputPr)
            {
                case 1:
                    Console.WriteLine("\nMata in en mening:");
                    string inputC1 = Console.ReadLine();

                    Regex rxC1 = new Regex(@"[^\W\d](\w|[-']{1,2}(?=\w))*");
                    MatchCollection matchesC1 = rxC1.Matches(inputC1);

                    Console.WriteLine("Din inmatning består av {0} ord.\n",
                                      matchesC1.Count) ;

                    foreach (Match word in matchesC1)
                    {
                        Console.WriteLine("{0} - {1} tecken.", word, word.Length);
                    }
                    break;
            }

            Console.ReadLine();
        }
    }
}
