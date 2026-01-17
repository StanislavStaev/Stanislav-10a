using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuedi tekst s glavni bukvi ");
            string tekst = Console.ReadLine();

            bool razlika = true;

            for (int i = 0; i < tekst.Length; i++)
            {
                for (int j = i + 1; j < tekst.Length; j++)
                {
                    if (tekst[i] == tekst[j])
                    {
                        razlika = false;
                        break;
                    }
                }
            }
            if (razlika)
                Console.WriteLine("ima razli4ni bukvi");
            else
                Console.WriteLine("ima povtarq6ti bukvi");
        }
    }
}
