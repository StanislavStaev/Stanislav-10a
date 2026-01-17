using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("S1 ");
            string S1 = Console.ReadLine();
            Console.Write("S2 ");
            string S2 = Console.ReadLine();
            int br = 0;
            for (int i = 0; i <= S1.Length - S2.Length; i++)
            {
                if (S1.Substring(i, S2.Length) == S2)
                {
                    br++;
                }
            }
            Console.WriteLine("br povtoreniq " + br);
        }
    }
}
