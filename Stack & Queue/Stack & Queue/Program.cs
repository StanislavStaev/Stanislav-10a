using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack___Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Stack<string> fruits = new Stack<string>();
            fruits.Push("Apple");
           fruits.Push("Banana");
             fruits.Push("Cherry");
            Console.WriteLine("ne6ta v obraten red ");
            while (fruits.Count > 0)
            {
             Console.WriteLine(fruits.Pop());
            } 
        }
    }
}
