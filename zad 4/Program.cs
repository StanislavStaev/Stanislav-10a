using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi glavni lat bukvi");
            string tekst = Console.ReadLine();

            string resultat = "";

            for (int i = 0; i < tekst.Length; i++)
            {
                char ascii = tekst[i];
                if (ascii >= 'A' && ascii <= 'Z')
                {
                    resultat += (char)(ascii + 32);
                }
                else
                {
                    resultat += ascii;
                }
            }
        }
    }
}
