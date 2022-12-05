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
    }
}