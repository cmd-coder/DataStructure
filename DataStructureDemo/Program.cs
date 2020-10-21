using System;

namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linked list program");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(70);
            list.InsertAtParticularPosition(2, 30);
            list.Display();
        }
    }
}
