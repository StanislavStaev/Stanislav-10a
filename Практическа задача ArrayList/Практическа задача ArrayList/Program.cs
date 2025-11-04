using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Практическа_задача_ArrayList.ArrayList;

namespace Практическа_задача_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList books = new ArrayList();

            Console.WriteLine($"Nachalen br element {books.Length} kapacitet {books.Capacity}");
            Console.Write("kolko knigi");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < /*books.Length*/ /*n*/ /* 6*/; i++)
            {
                Console.Write($"vuvedi kniga {i + 1} ");
                string name = Console.ReadLine();
                books.Add(name);
            }
            books.Print();
            Console.WriteLine($"br element {books.Length} kapacitet {books.Capacity}");
            Console.Write("vuvedi index za premahvane ");
            int index = int.Parse(Console.ReadLine());
            books.RemoveAt(index);
            books.Print();
            Console.WriteLine($"br element {books.Length} kapacitet {books.Capacity}");
            Console.Write("index za smqna ");
            int idx = int.Parse(Console.ReadLine());
            Console.Write("novo zaglavie");
            string novoz = Console.ReadLine();
            books.Set(idx, novoz);
            books.Print();
            Console.Write("index za pokazvane ");
            int Indexpokaz = int.Parse(Console.ReadLine());
            string found = books.Get(Indexpokaz);
            Console.WriteLine($"element na pozicia {Indexpokaz} e {found}");
        }
    }
}
