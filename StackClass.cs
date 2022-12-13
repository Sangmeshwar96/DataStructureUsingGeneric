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

        public void Peek()
        {
            if (this.top == null)
                Console.WriteLine("\nNothing to display, stack is empty");
            else
                Console.WriteLine("\nTopmost element: " + top.data);
        }

        public void Pop()
        {
            if (this.top == null)
                Console.WriteLine("\nNothing to pop, the stack is empty");
            Console.WriteLine("\nValue popped is {0}", top.data);
         
            this.top = this.top.next;
        }

        public void PopAll()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}