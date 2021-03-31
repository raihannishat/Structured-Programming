using System;
using System.Collections.Generic;
using System.Text;

namespace Chap_05_Stack_And_Queue
{
    public class Browser
    {
        public Stack<string> BackStack { get; set; }
        public Stack<string> ForwordStack { get; set; }

        public Browser()
        {
            BackStack = new Stack<string>();
            ForwordStack = new Stack<string>();
        }

        public void Browse(string url)
        {
            if (ForwordStack.Count != 0)
            {
                ForwordStack.Clear();
            }

            BackStack.Push(url);
        }

        public string Back()
        {
            if (BackStack.Count == 0)
            {
                return null;
            }

            ForwordStack.Push(BackStack.Pop());

            if (BackStack.Count == 0)
            {
                return null;
            }

            return BackStack.Peek();
        }

        public string Forword()
        {
            if (ForwordStack.Count == 0)
            {
                return null;
            }

            BackStack.Push(ForwordStack.Peek());

            return ForwordStack.Pop();
        }
    }
}
