using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> a = new Queue<int>();

            a.Enqueue(1);
            a.Enqueue(2);
            a.Enqueue(3);
            a.Enqueue(4);

            Console.WriteLine("");
            P(a);

            L(a);
            Console.WriteLine("lqva r ");
            P(a);

            D(a);
            Console.WriteLine("dqsna r");
            P(a);
        }
        static void L(Queue<int> q)
        {
            int first = q.Dequeue();
            q.Enqueue(first);
        }
        static void D(Queue<int> q)
        {
            int last = 0;

            for (int i = 0; i < q.Count; i++)
            {
                int x = q.Dequeue();
                if (i == q.Count)
                    last = x;
                q.Enqueue(x);
            }

            q.Enqueue(last);
        }

        static void P(Queue<int> q)
        {
            foreach (int x in q)
                Console.Write(x + " ");
            Console.WriteLine();
        }
    }
}
