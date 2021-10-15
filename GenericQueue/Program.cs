using System;
using System.Collections.Generic;

namespace GenericQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> Obj = new Queue<string>();
            Obj.Enqueue("Hello1");
            Obj.Enqueue("Hello2");
            Obj.Enqueue("Hello3");

            foreach (string s in Obj)
            {
                Console.WriteLine(s + " ");
            }
            Obj.Dequeue();
            foreach (string s in Obj)
            {
                Console.WriteLine(s + " ");
            }
            Console.WriteLine(Obj.Peek());
        }
    }
}
