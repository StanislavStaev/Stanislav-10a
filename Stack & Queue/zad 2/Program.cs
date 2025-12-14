using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);
            Console.WriteLine("4isla ot opa6kata");
            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Dequeue());
            }
        }
    }
}
