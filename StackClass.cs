using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueDemo
{
    public class StackClass<T>
    {
    
        public Node<T> top;
       
        public void Push(T value)
        {
            
            Node<T> new_node = new Node<T>(value);
           
            if (this.top != null)
                new_node.next = this.top;
        
            this.top = new_node;
            Console.WriteLine("Value inserted into the stack " + value);
        }
 
        public void Display()
        {
            Node<T> temp = this.top;
            
            if (temp == null)
            {
                Console.WriteLine("Stack is empty");
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