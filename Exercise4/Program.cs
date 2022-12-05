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
        public void Display()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack empty");
                return;
            }
            else
            {
                Console.WriteLine("Elements in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(diva[i]);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\nSTACK MENU\n");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your choice:");
                string Input = Console.ReadLine();
                char ch = Convert.ToChar(Input == "" ? "0" : Input);
                switch (ch)
                {
                    case '1':
                        Console.Write("\nEnter a number :");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.Push(num);
                        break;
                    case '2':
                        if (s.Empty())
                        {
                            Console.WriteLine("\nStack empty");
                            break;
                        }
                        s.Pop();
                        break;
                    case '3':
                        s.Display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }
            }
        }
    }
}