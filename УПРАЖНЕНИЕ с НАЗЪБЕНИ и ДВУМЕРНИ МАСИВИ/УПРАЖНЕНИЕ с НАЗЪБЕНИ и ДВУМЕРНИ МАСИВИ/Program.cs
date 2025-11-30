using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УПРАЖНЕНИЕ_с_НАЗЪБЕНИ_и_ДВУМЕРНИ_МАСИВИ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("br igra4i  ");
            int ibr = int.Parse(Console.ReadLine());
            Console.Write("br igri  ");
            int gbr = int.Parse(Console.ReadLine());
            string[] ime = new string[ibr];
            int[][] t = new int[ibr][];
            for (int i = 0; i < ibr; i++)
            {
                Console.WriteLine("igra4 "+ (i + 1) );
                Console.Write("ime ");
                ime[i] = Console.ReadLine();
                t[i] = new int [gbr];
                Console.Write("to4ki  ");
                for (int j = 0; j < gbr; j++)
                {
                   t[i][j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("rezultat  ");
            int naj_t = -1;
            string dobur_igr = " ";
            for (int i = 0; i < ibr; i++)
            {
                int sum = 0;
                for (int j = 0; j < gbr; j++)
                {
                    sum += t[i][j];
                }
                Console.WriteLine(ime[i]+ "ob6to  "+ sum);
                if (sum > naj_t)
                {
                    naj_t = sum;
                    dobur_igr = ime[i];
                }
            }
            Console.WriteLine("igra4  " +dobur_igr+ naj_t);
        }
    }
}
