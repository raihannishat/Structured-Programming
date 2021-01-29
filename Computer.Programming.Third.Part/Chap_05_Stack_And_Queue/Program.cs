using System;

namespace Chap_05_Stack_And_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack my_stack = new Stack();

            //my_stack.Push(1);
            //my_stack.Push(2);
            //my_stack.Push(3);

            //Console.WriteLine(my_stack.Pop());
            //Console.WriteLine(my_stack.Pop());
            //Console.WriteLine(my_stack.Pop());
            //Console.WriteLine(my_stack.Pop());

            //Balanced balanced = new Balanced();

            //string input = Console.ReadLine();

            //if (Convert.ToBoolean(balanced.is_balanced(input.ToCharArray())))
            //{
            //    Console.WriteLine($"{input} is balanced");
            //}
            //else
            //{
            //    Console.WriteLine($"{input} is not balanced");
            //}

            //Bracket bracket = new Bracket();

            //var str = "[({})]";

            //if (bracket.IsBalanced(str))
            //{
            //    Console.WriteLine($"{str} is balanced");
            //}
            //else
            //{
            //    Console.WriteLine($"{str} is not balanced");
            //}

            Queue my_q = new Queue(5);

            my_q.Enqueue(1);
            Console.WriteLine($"tail = {my_q.tail}");
            
            my_q.Enqueue(2);
            Console.WriteLine($"tail = {my_q.tail}");
            
            my_q.Enqueue(3);
            Console.WriteLine($"tail = {my_q.tail}");
            
            my_q.Enqueue(4);
            Console.WriteLine($"tail = {my_q.tail}");
            
            my_q.Enqueue(5);
            Console.WriteLine($"tail = {my_q.tail}");

            my_q.Enqueue(6);
            Console.WriteLine($"tail = {my_q.tail}");

            my_q.Display();

            my_q.Dequeue();
            my_q.Head();

            my_q.Dequeue();
            my_q.Head();

            my_q.Dequeue();
            my_q.Head();

            my_q.Dequeue();
            my_q.Head();

            my_q.Dequeue();
            my_q.Head();

            my_q.Dequeue();
            my_q.Head();
        }
    }
}
