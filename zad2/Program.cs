using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi simvoli");
            string tekst = Console.ReadLine();

            int exclamation = 0;
            int question = 0;
            int comma = 0;
            int dot = 0;
            int colon = 0;

            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] == '!')
                    exclamation++;
                else if (tekst[i] == '?')
                    question++;
                else if (tekst[i] == ',')
                    comma++;
                else if (tekst[i] == '.')
                    dot++;
                else if (tekst[i] == ':')
                    colon++;
            }
            Console.WriteLine("! => " + exclamation);
            Console.WriteLine("? => " + question);
            Console.WriteLine(", => " + comma);
            Console.WriteLine(". => " + dot);
            Console.WriteLine(": => " + colon);
        }

    }
}
