using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace A_6_3_CallQueue
{
    internal class CustomerQueue<T>
    {
        private Node<T>? front;

        private Node<T>? back;
        
        private int count;

        //Constructor
        public CustomerQueue()
        {
            front = null;
            back = null;
            count = 0;
        }

        //Properties

        public int Count => count;
        public bool IsEmpty => front == null;

        public void Enqueue(T data)
        {
            // Create a new Node to hold the incoiming data (for customer)
            // Check if queue is currently empty. If empty then front and back will be the new Node
            // else, add to the back. back.next points to new node. New node becomes the new back. 
            // increase count

            Node<T> newNode = new Node<T>(data);
            

            if (IsEmpty)
            {
                front = newNode;
                back = newNode;
            }
            else
            {
                back!.Next = newNode;
                back = newNode;
            }

            count++;

            Console.WriteLine($"Enqueued: '{data}'  |  Queue Length: {count}");
        }


        public T Dequeue()
        {

            // Check if empty; cannot dequeue from empty queue
            // store the front into data; front.next = new front
            // If there was only one person in the queue and we dequeue => make sure back null also
            // Decrease count
            // return the stored data

            if (IsEmpty)
            {
                throw new InvalidOperationException("Cannot Dequeue from empty queue.");
            }
            T data = front!.Data;
            front = front.Next;
            if(front == null)
            {
                back = null;
            }

            count--;
            Console.WriteLine($"Dequeued: '{data}'  |  Queue Length: {count}");
            return data;
        }

        public void Display()
        {
            Console.WriteLine("\nQueue from front to back):\n");
            if (IsEmpty)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            else
            {
                Node<T>? current = front;

                Console.Write("<front>");

                while (current != null)
                {
                    Console.Write($"[{current.Data}]");

                    if (current.Next != null)
                    {
                        Console.Write("--->");
                    }

                    current = current.Next;

                }

                Console.WriteLine($"  (total: {count})\n\n");
            }
        }
    }
}
