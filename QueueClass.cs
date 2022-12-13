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
     
        public void Dequeue()
        {
           
            if (this.head == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

          
            Node<T> temp = this.head;
            this.head = this.head.next;

            Console.WriteLine("\nItem deleted is {0}", temp.data);
        }

        public void DeQueueAll()
        {

            while (head != null)
                Dequeue();
        }
   
        public void Display()
        {
            Node<T> temp = this.head;
       
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
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