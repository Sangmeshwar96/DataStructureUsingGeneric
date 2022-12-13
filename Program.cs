using System;

namespace StackQueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            QueueClass<int> queueClass = new QueueClass<int>();
            queueClass.Enqueue(56);
            queueClass.Enqueue(30);
            queueClass.Enqueue(70);
          
            queueClass.Display();
            queueClass.DeQueueAll();
            queueClass.Display();


        }
    }
}