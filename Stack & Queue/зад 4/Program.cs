using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace зад_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vyvedi 4islo  ");
            int n = int.Parse(Console.ReadLine());
            Stack<int> s = new Stack<int>();
            while (n > 0)
            {
                s.Push(n % 2);
                n /= 2;
            }
   Console.Write("dvoi4no ");
            while (s.Count > 0)
             
                Console.Write(s.Pop() );
        }
    }
}
