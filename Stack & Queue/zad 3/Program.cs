using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi skovi");
            string a = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool b = true;
            foreach (char ch in a)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == ']' || ch == '}')
                {
                    if (stack.Count == 0)
                    {
                        b = false;
                        break;
                    }
                    char open = stack.Pop();
                    if ((open == '(' && ch != ')') ||(open == '[' && ch != ']') ||(open == '{' && ch != '}'))
                    {
                        b = false;
                        break;
                    }
                }
            }
            if (stack.Count != 0) b = false;
            if (b) Console.WriteLine("balansirani");
            else Console.WriteLine("ne balansirani");
        }
    }
}
