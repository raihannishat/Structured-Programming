using System;
using System.Collections.Generic;
using System.Text;

namespace Chap_05_Stack_And_Queue
{
    public class Balanced
    {
        private char[] stack;
        private char last_char;
        public int top;

        public Balanced()
        {
            top = 0;
            stack = new char[100];
        }

        public int is_balanced(char[] input)
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
    }
}
