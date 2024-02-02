using System;
using System.Collections.Generic;
namespace uppgift4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv 3 ord");
            string[] ord = new string[3];
            for (int i = 0; i < ord.Length; i++)
            {
                ord[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.Write("Vilket tecken vill du söka efter i alla ord?: ");
            char tecken = Convert.ToChar(Console.ReadLine());
            if (FinnsTecknetIAllaSträngar(ord, tecken) == true)
            {
                Console.WriteLine("Alla ord innehåller detta tecken");
            }
            else
            {
                Console.WriteLine("Inte alla ord innehåller detta tecken");
            }
            Console.ReadKey();
        }
        static bool FinnsTecknetIAllaSträngar(string[] a, char b)
        {
            bool c = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Contains(b))
                {
                    c = true;
                }
                else
                {
                    c = false;
                    break;
                }
            }
            return c;
        }
    }
}