using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi tekst ");
            string tekst = Console.ReadLine();
            int dumi = 0;
            bool inWord = false;
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] != ' ' && !inWord)
                {
                    dumi++;
                    inWord = true;
                }
                else if (tekst[i] == ' ')
                {
                    inWord = false;
                }
            }
            Console.WriteLine("br dumi " + dumi);
        }
    }
}
