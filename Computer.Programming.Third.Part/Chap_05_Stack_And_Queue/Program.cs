using System;

namespace Chap_05_Stack_And_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Stack
            /*
            MyStack stack = new MyStack();
            Stack myStack = new Stack();
            int item;

            myStack.top = 0;

            stack.Push(myStack, 1);
            stack.Push(myStack, 2);
            stack.Push(myStack, 3);

            item = stack.Pop(myStack);
            Console.WriteLine($"{item}");

            item = stack.Pop(myStack);
            Console.WriteLine($"{item}");

            item = stack.Pop(myStack);
            Console.WriteLine($"{item}");
            */
            #endregion

            #region IsBalanced
            /*
            string input = Console.ReadLine();

            MyStack stack = new MyStack();

            if (Convert.ToBoolean(stack.IsBalanced(input.ToCharArray())))
            {
                Console.WriteLine($"{input} is balanced");
            }
            else
            {
                Console.WriteLine($"{input} is not balanced");
            }
            */
            #endregion

            #region BracketIsBalanced
            /*
            MyStack stack = new MyStack();
            var str = "{{([])}}";

            if (stack.BracketIsBalanced(str))
            {
                Console.WriteLine($"{str} is balanced");
            }
            else
            {
                Console.WriteLine($"{str} is not balanced");
            }
            */
            #endregion

            #region Browser
            /*
            Browser browser = new Browser();

            browser.Browse("https://www.google.com");
            browser.Browse("https://www.facebook.com");
            browser.Browse("https://www.youtube.com");
            browser.Browse("https://www.github.com");

            Console.WriteLine(browser.Back());

            browser.Browse("https://www.bing.com");
            browser.Browse("https://www.wikipedia.org");

            Console.WriteLine(browser.Back());
            Console.WriteLine(browser.Forword());
            */
            #endregion

            #region Queue
            /*
            MyQueue queue = new MyQueue();
            Queue myQueue = new Queue();
            int item;

            myQueue.Head = 0;
            myQueue.Tail = 0;

            queue.Enqueue(myQueue, 1);
            Console.WriteLine($"tail = {myQueue.Tail}");

            queue.Enqueue(myQueue, 2);
            Console.WriteLine($"tail = {myQueue.Tail}");

            queue.Enqueue(myQueue, 3);
            Console.WriteLine($"tail = {myQueue.Tail}");

            queue.Enqueue(myQueue, 4);
            Console.WriteLine($"tail = {myQueue.Tail}");

            queue.Enqueue(myQueue, 5);
            Console.WriteLine($"tail = {myQueue.Tail}");

            queue.Enqueue(myQueue, 6);
            Console.WriteLine($"tail = {myQueue.Tail}");

            Console.WriteLine($"beginning head = {myQueue.Head}");

            item = queue.Dequeue(myQueue);
            Console.WriteLine($"item = {item}, head = {myQueue.Head}");

            item = queue.Dequeue(myQueue);
            Console.WriteLine($"item = {item}, head = {myQueue.Head}");

            item = queue.Dequeue(myQueue);
            Console.WriteLine($"item = {item}, head = {myQueue.Head}");

            item = queue.Dequeue(myQueue);
            Console.WriteLine($"item = {item}, head = {myQueue.Head}");

            item = queue.Dequeue(myQueue);
            Console.WriteLine($"item = {item}, head = {myQueue.Head}");

            item = queue.Dequeue(myQueue);
            Console.WriteLine($"item = {item}, head = {myQueue.Head}");
            */
            #endregion
        }
    }
}
