using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace статични_и_динамични_методи_за_манипулация_др
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi tekst  ");
            string tekdt = Console.ReadLine();

            bool palindrom = true;

            for (int i = 0; i < tekdt.Length / 2; i++)
            {
                if (tekdt[i] != tekdt[tekdt.Length - 1 - i])
                {
                    palindrom = false;
                    break;
                }
            }

            if (palindrom)
                Console.WriteLine("palindrom");
            else
                Console.WriteLine("ne palindrom");
        }
    }
}
