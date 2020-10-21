using System;

namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linked list program");
            LinkedList list = new LinkedList();
            list.AddInBeginning(70);
            list.AddInBeginning(30);
            list.AddInBeginning(56);
            list.Display();
        }
    }
}
