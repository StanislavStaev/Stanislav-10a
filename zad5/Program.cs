using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("S1 ");
            string s1 = Console.ReadLine();
            Console.Write("S2 ");
            string s2 = Console.ReadLine();
            Console.Write("Rezultat: ");
            for (int i = 0; i < s1.Length; i++)
            {
                char a = s1[i];
                if (a >= 'a' && a <= 'z')
                {
                    bool n = false;
                    for (int j = 0; j < s2.Length; j++)
                    {
                        if (a == s2[j])
                        {
                            n = true;
                            break;
                        }
                    }
                    if (!n)
                    {
                        Console.Write(a + " ");
                    }
                }
            }
        }
    }
}
