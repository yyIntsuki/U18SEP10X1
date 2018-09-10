using System;
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
            Console.WriteLine("Vilket program/uppgift vill du köra?");
            int inputPr = Convert.ToInt32(Console.ReadLine());

            switch (inputPr)
            {
                case 1:
                    Console.WriteLine("Skriv ut antal ord:");
                    break;

                case 2:
                    break;

            }

            Console.ReadLine();
        }
    }
}
