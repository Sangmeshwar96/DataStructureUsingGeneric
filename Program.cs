using System;


namespace StackQueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
    
            StackClass<int> stackClass = new StackClass<int>();
            stackClass.Push(70);
            stackClass.Push(30);
            stackClass.Push(56);
      
            stackClass.Display();

            stackClass.PopAll();
            stackClass.Display();

        }
    }
}