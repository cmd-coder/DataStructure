using Microsoft.VisualBasic.FileIO;
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
            Console.WriteLine("Initial Linked List");
            list.Display();

            Console.WriteLine("Inserting 40 after 30");
            list.InsertAfter(40, 30);
            list.Display();
        }
    }
}
