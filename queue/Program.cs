using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a new queue
            MyQueue myQueue = new MyQueue();

            // Adding elements to the queue
            myQueue.Add(1);
            myQueue.Add(2);
            myQueue.Add(3);

            // Removing and displaying elements from the queue
            Console.WriteLine("Removed element: " + myQueue.Remove());
            Console.WriteLine("Removed element: " + myQueue.Remove());
            Console.WriteLine("Removed element: " + myQueue.Remove());

            // Trying to remove from an empty queue
            Console.WriteLine("Removed element: " + myQueue.Remove()); // This will print an error message

            Console.ReadLine();
        }
    }

    class MyQueue
    {
        private Queue<int> queue;

        public MyQueue()
        {
            queue = new Queue<int>();
        }

        public void Add(int element)
        {
            queue.Enqueue(element);
            Console.WriteLine("Added element: " + element);
        }

        public int Remove()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Queue is empty. Cannot remove.");
                return -1; // You can choose to throw an exception or handle this case differently based on your needs.
            }

            int removedElement = queue.Dequeue();
            Console.WriteLine("Removed element: " + removedElement);
            return removedElement;
        }
    }
}