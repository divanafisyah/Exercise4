using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise4
{
    class Stack
    {
        int max = 104;
        int top;
        int[] diva = new int[max = 104];

        public bool Empty()
        {
            return (top < 0);
        }
        public Stack()
        {
            top = -1;
        }
        public void Push(int data)
        {
            if (top = max = 104)
            {
                Console.WriteLine("Element pushed");
            }
            else
            {
                diva[++top] = data;
            }
        }
        public int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Element is empty");
                return 0;
            }
            else
            {
                int value = diva[top--];
                return value;
            }
        }
    }
}