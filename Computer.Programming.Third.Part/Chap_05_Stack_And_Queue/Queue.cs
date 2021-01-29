using System;
using System.Collections.Generic;
using System.Text;

namespace Chap_05_Stack_And_Queue
{
    public class Queue
    {
        public int head, tail, size;
        public int[] data;

        public Queue(int capacity)
        {
            head = tail = 0;
            size = capacity;
            data = new int[size];
        }

        public void Enqueue(int item)
        {
            if (size == tail)
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                data[tail] = item;
                tail++;
            }
        }

        public void Dequeue()
        {
            if (head == tail)
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                for (int i = 0; i < tail - 1; i++)
                {
                    data[i] = data[i + 1];
                }

                if (tail < size)
                {
                    data[tail] = 0;
                }

                tail--;
            }
        }

        public void Head()
        {
            if (head == tail)
            {
                Console.WriteLine("Queue is Empty");
            }

            Console.Write($"beginning head = {data[head]}\n");
        }

        public void Display()
        {
            if (head == tail)
            {
                Console.WriteLine("Queue is Empty");
            }

            for (int i = head; i < tail; i++)
            {
                Console.Write($"{data[i]} --> ");
            }

            Console.WriteLine();
        }
    }
}
