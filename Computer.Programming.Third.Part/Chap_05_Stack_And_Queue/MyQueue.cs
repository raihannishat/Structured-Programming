using System;
using System.Collections.Generic;
using System.Text;

namespace Chap_05_Stack_And_Queue
{
    public class MyQueue
    {
        public const int qSize = 6;

        public void Enqueue(Queue queue, int item)
        {
            if ((queue.Tail + 1) % (qSize + 1) == queue.Head)
            {
                Console.WriteLine("Queue is full!");
                return;
            }

            queue.Data[queue.Tail] = item;
            queue.Tail = (queue.Tail + 1) % (qSize + 1);
        }

        public int Dequeue(Queue queue)
        {
            int item;

            if (queue.Tail == queue.Head)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }

            item = queue.Data[queue.Head];
            queue.Head = (queue.Head + 1) % (qSize + 1);

            return item;
        }
    }
}
