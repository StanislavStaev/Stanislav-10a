using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическа_задача_ArrayList
{
    public class ArrayList
    {
        private const int INITIAL_SIZE = 2;
        private string[] items;
        private int length;
        private int capacity;
        public int Length => length;
        public int Capacity => capacity;
        public ArrayList(int size = INITIAL_SIZE)
        {
            capacity = size;
            length = 0;
            items = new string[size];
        }
        public void Add(string item)
        {
            if (length == capacity)
            {
                capacity *= 2;
                string[] temp = new string[capacity];
                for (int i = 0; i < length; i++)
                    temp[i] = items[i];
                items = temp;
            }
            items[length] = item;
            length++;
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= length)
            {
                Console.WriteLine("Nevaliden index");
                return;
            }
            Console.WriteLine($"Remove from list element {items[index]}");
            for (int i = index; i < length - 1; i++)
            {
                items[i] = items[i + 1];
            }
            length--;
        }
        public void Set(int index, string newItem)
        {
            if (index < 0 || index >= length)
            {
                Console.WriteLine("nevaliden index");
                return;
            }
            items[index] = newItem;
        }
        public string Get(int index)
        {
            if (index < 0 || index >= length)
            {
                Console.WriteLine("nevaliden index");
                return null;
            }
            return items[index];
        }
        public void Print()
        {
            Console.WriteLine("sudurjanie");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i]}");
            }
        }
    }
}

