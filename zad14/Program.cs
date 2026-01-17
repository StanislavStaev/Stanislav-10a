using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedi duma na angliski");
            string duma = Console.ReadLine();           
            string a = "";
            for (int i = 0; i < duma.Length; i++)
            {
                if (i == 0)
                {
                    a = duma[0].ToString();
                }
                else if (i == 1)
                {
                    a = duma[0].ToString() + duma[1] + duma[0];
                }
                else
                {
                    a = a + duma[i] +a;
                }
            }
            Console.WriteLine(a);
        }
    }
}
