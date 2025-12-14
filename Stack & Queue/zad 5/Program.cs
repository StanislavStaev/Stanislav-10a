using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> opa6ka = new Queue<int>();
             opa6ka.Enqueue(1);
           opa6ka.Enqueue(2);
            opa6ka.Enqueue(3);
            Oburnato(opa6ka);
        }
        static void Oburnato(Queue<int> q)
        {
            Stack<int> stack = new Stack<int>();
            while (q.Count > 0)
            {
                stack.Push(q.Dequeue());
            }
            Console.WriteLine("obratno  ");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
