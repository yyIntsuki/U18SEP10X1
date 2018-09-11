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
            int active = 0;
            do
            {
                Console.WriteLine("----------------------------------------------------------------\n" +
                    " Vilket program/uppgift vill du köra? (1-7) (0 för att avsluta)\n" +
                    "----------------------------------------------------------------");
                int inputPr = Convert.ToInt32(Console.ReadLine());

                switch (inputPr)
                {
                    case 1:
                        Console.WriteLine("\n Mata in en mening:");
                        string inputC1 = Console.ReadLine();

                        Regex rxC1 = new Regex(@"[^\W\d](\w|[-']{1,2}(?=\w))*");
                        MatchCollection matchesC1 = rxC1.Matches(inputC1);

                        Console.WriteLine("\n Din inmatning består av {0} ord.\n",
                                          matchesC1.Count);

                        foreach (Match matchC1 in matchesC1)
                        {
                            Console.WriteLine(" {0} - {1} tecken.", matchC1, matchC1.Length);
                        }
                        Console.WriteLine();

                        active = 0;
                        break;

                    case 2:
                        Console.WriteLine("\n Mata in en mening:");
                        string inputC2 = Console.ReadLine();

                        Regex rxC2 = new Regex(@"[^\W\d](\w|[-']{1,2}(?=\w))*");
                        MatchCollection matchesC2 = rxC2.Matches(inputC2);

                        string[] matches_arrayC2 = new string[matchesC2.Count];
                        int indexC2 = 0;
                        foreach (Match match in matchesC2)
                        {
                            matches_arrayC2[indexC2++] = match.ToString();
                        }

                        Array.Sort(matches_arrayC2, (x, y) => x.Length.CompareTo(y.Length));
                        
                        Console.WriteLine("\n Orden i storleksordning:\n");
                        foreach (string sC2 in matches_arrayC2)
                        {
                            Console.WriteLine(" " + sC2);
                        }
                        Console.WriteLine();

                        Array.Sort(matches_arrayC2, (y, x) => x.Length.CompareTo(y.Length));

                        Console.WriteLine("\n Orden i bakvänd orning:\n");
                        foreach (string sC2 in matches_arrayC2)
                        {
                            Console.WriteLine(" " + sC2);
                        }
                        Console.WriteLine();

                        active = 0;
                        break;

                    case 3:
                        Console.WriteLine("\n Mata in en mening:");
                        string inputC3 = Console.ReadLine();

                        string[] matchesC3 = inputC3.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
                        var selectionC3 = (from string word in matchesC3 orderby word select word).Distinct();
                        int countC3 = selectionC3.Count();
                        string[] resultC3 = selectionC3.ToArray();

                        int[] CountC3 = new int[countC3]; 

                        for (int i = 0; i < countC3; i++)
                        {
                            int count = TextTool.CountStringOccurrences(inputC3, resultC3[i]);
                            CountC3[i] = count;
                        }

                        Array.Sort(CountC3, resultC3);
                        Array.Reverse(resultC3);

                        for (int i = 0; i < countC3; i++)
                        {
                            int count = TextTool.CountStringOccurrences(inputC3, resultC3[i]);
                            Console.WriteLine(resultC3[i] + "(" + count + ")" );
                        }

                        active = 0;
                        break;

                    case 4:
                        Console.WriteLine("\n Mata in en mening:");
                        string inputC4 = Console.ReadLine();

                        string[] matchesC4 = inputC4.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
                        char[] wordSplitC4 = string.Join(string.Empty, matchesC4).ToCharArray();
                        var selectionC4 = (from char word in wordSplitC4 orderby word select word).Distinct();
                        int countC4 = selectionC4.Count();

                        int[] CountC4 = new int[countC4];
                        char[] resultC4 = selectionC4.ToArray();

                        foreach (char chC4 in resultC4)
                        {
                            int count = inputC4.Count(f => f == chC4);
                            Console.WriteLine(chC4 + "(" + count + ")");
                        }


                        active = 0;
                        break;

                    case 5:
                        string inputC5;
                        string outputC5 = "";

                        while (true)
                        {
                            while (true)
                            {
                                Console.WriteLine("\nSkriv ett ord. Avsluta med 'avsluta'.");
                                inputC5 = Console.ReadLine();

                                if (inputC5 == "")
                                {
                                    Console.WriteLine("\nBlankt inmatning, försök igen.");
                                }
                                else
                                {
                                    break;
                                }
                            }

                            if (inputC5 == "avsluta")
                            {
                                break;
                            }
                            outputC5 += " " + inputC5.Trim();

                        }

                        Console.WriteLine("\nSkriver ut inmatade ord.\n {0}", outputC5);

                        active = 0;
                        break;


                    case 6:
                        Console.WriteLine("\n Gissa ett tal mellan 1-21.");
                        int inputC6 = Convert.ToInt32(Console.ReadLine());

                        Random randC6 = new Random();
                        int answerC6 = randC6.Next(1, 22);

                        if(inputC6 == answerC6)
                        {
                            Console.WriteLine(" Du gissade rätt! ({0})\n", answerC6);
                        }
                        else
                        {
                            Console.WriteLine(" Du gissade fel! ({0})\n", answerC6);
                        }

                        active = 0;
                        break;

                    case 7:
                        Console.WriteLine("\n Mata in en mening på engelska i stora bokstäver:");
                        string inputC7 = Console.ReadLine();

                        Dictionary<string, string> leetDic = new Dictionary<string, string>
                        {
                            { "A", @"/-\" },
                            { "B", @"|3" },
                            { "C", @"(" },
                            { "D", @"|)" },
                            { "E", @"3" },
                            { "F", @"|=" },
                            { "G", @"(" },
                            { "H", @"|-|" },
                            { "I", @"l" },
                            { "J", @"    _|" },
                            { "K", @"|<" },
                            { "L", @"|_" },
                            { "M", @"|\/|" },
                            { "N", @"|\|" },
                            { "O", @"0" },
                            { "P", @"|2" },
                            { "Q", @"(,)" },
                            { "R", @"|2" },
                            { "S", @"5" },
                            { "T", @"+" },
                            { "U", @"|_|" },
                            { "V", @"    |/" },
                            { "W", @"\/\/" },
                            { "X", @"><" },
                            { "Y", @"`/" },
                            { "Z", @"2" }
                        };

                        foreach (KeyValuePair<string, string> letter in leetDic)
                        {
                            inputC7 = inputC7.Replace(letter.Key, letter.Value);
                        }
                        Console.WriteLine("Your sentence in leet is: " + inputC7);
                        break;

                    case 0:
                        active = 1;
                        break;

                }
            }
            while (active != 1);
        }
    }

    public static class TextTool
    {
        public static int CountStringOccurrences(string text, string pattern)
        {
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return count;
        }
    }
}
