using System;
using System.Collections.Generic;
using System.Text;

namespace Chap_05_Stack_And_Queue
{
    public class Stack
    {
        private const int STACK_MAX = 100;
        private int top;
        private int[] data;

        public Stack()
        {
            top = 0;
            data = new int[STACK_MAX];
        }

        public void Push(int item)
        {
            if (top < STACK_MAX)
            {
                data[top] = item;
                top++;
            }
            else
            {
                Console.WriteLine("Stack is full!");
            }
        }

        public int Pop()
        {
            if (top == 0)
            {
                Console.WriteLine("Stack is empty!");
                return -1;
            }
            else
            {
                top--;
                return data[top];
            }
        }
    }
}
