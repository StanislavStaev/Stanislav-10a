using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace стек
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> dumi = new Stack<string>();
            dumi.Push("машинки");
           dumi.Push("маламашка");
           dumi.Push("носталгично кебабче");
            Console.WriteLine("добавени елементи");
            foreach (var а in dumi)
            {
                Console.WriteLine(а);
            }
            Console.WriteLine("последна дума " + dumi.Peek());
            Console.WriteLine("махане на елемент " + dumi.Pop());
            foreach (var б in dumi)
            {
                Console.WriteLine(б);
            }
            Console.WriteLine("брой думи " + dumi.Count);
        }
    }
}
