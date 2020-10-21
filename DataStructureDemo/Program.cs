using Microsoft.VisualBasic.FileIO;
using System;
using System.Net;

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

            Console.WriteLine("Deleting 40");
            list.DeleteAny(40);
            list.Display();
            Console.WriteLine("Linked List size is: " + list.Size());
        }
    }
}
