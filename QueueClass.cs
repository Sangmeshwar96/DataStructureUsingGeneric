using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueDemo
{
    class QueueClass<T>
    {
        Node<T> head;

        public void Enqueue(T item)
        {
   
            Node<T> new_node = new Node<T>(item);
            if (this.head == null)
            {
                this.head = new_node;
            }

            else
            {
                Node<T> temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
            Console.WriteLine("inserted into list " + new_node.data);
        }
   
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("queue is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}