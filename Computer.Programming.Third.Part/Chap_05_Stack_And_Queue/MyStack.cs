using System;
using System.Collections.Generic;
using System.Text;

namespace Chap_05_Stack_And_Queue
{
    public class MyStack
    {
        public const int stackMax = 100;
        private char[] stack = new char[100];
        private char last_char;
        public int top;

        public void Push(Stack stack, int item)
        {
            if (stack.top < stackMax)
            {
                stack.data[stack.top] = item;
                stack.top = stack.top + 1;
            }
            else
            {
                Console.WriteLine("Stack is full!");
            }
        }

        public int Pop(Stack stack)
        {
            int item;

            if (stack.top == 0)
            {
                Console.WriteLine("Stack is empty!");
                return -1;
            }
            else
            {
                stack.top = stack.top - 1;
                item = stack.data[stack.top];
            }

            return item;
        }

        public int IsBalanced(char[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack[top] = '(';
                    top++;
                }
                else if (input[i] == ')')
                {
                    if (top == 0)
                    {
                        return 0;
                    }

                    top--;

                    last_char = stack[top];

                    if (last_char != '(')
                    {
                        return 0;
                    }
                }
            }

            if (top == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public bool BracketIsBalanced(string bracket)
        {
            Stack<char> stack = new Stack<char>();
            char[] chars = bracket.ToCharArray();

            foreach (var item in chars)
            {
                if (stack.Count == 0)
                {
                    stack.Push(item);
                }
                else
                {
                    char peek = stack.Peek();

                    if (peek == '(' && item == ')')
                    {
                        stack.Pop();
                    }
                    else if (peek == '{' && item == '}')
                    {
                        stack.Pop();
                    }
                    else if (peek == '[' && item == ']')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(item);
                    }
                }
            }

            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
