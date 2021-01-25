using System;
using System.Collections.Generic;
using System.Text;

namespace Chap_05_Stack_And_Queue
{
    public class Bracket
    {
        public bool IsBalanced(string bracket)
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
