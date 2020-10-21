using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureDemo
{
    public class LinkedList
    {
        internal Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }

        internal void AddInBeginning(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                head = node;
                node.next = temp;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }

        internal void Display()
        {
            Node temp = this.head;
            if(temp==null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while(temp.next!=null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }
            Console.WriteLine(temp.data);
        }

        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }

        internal void Delete()
        {
            if (head == null)
                Console.WriteLine("Nothing is there to be deleted");
            else
            {
                Console.WriteLine(head.data + " has been deleted");
                head = head.next;
            }
        }

        internal void DeleteEnd()
        {
            if (head == null)
                Console.WriteLine("Nothing is there to be deleted");
            else if(head.next==null)
            {
                Console.WriteLine(head.data + " has been deleted");
                head = null;
            }
            else
            {
                Node temp = head;
                while(temp.next.next!=null)
                {
                    temp = temp.next;
                }
                Console.WriteLine(temp.next.data + " has been deleted");
                temp.next = null;
            }
        }

        public bool Search(int input)
        {
            bool flag = false;
            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                while(temp!=null)
                {
                    if (temp.data == input)
                    {
                        Console.WriteLine("The element is present");
                        flag = true;
                        break;
                    }
                    temp = temp.next;
                }
                if (!flag)
                    Console.WriteLine("The Element is Absent");
            }
            return flag;
        }

        public bool InsertAfter(int data, int after)
        {
            bool flag = false;
            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == after)
                    {
                        Node newNode = new Node(data);
                        newNode.next = temp.next;
                        temp.next = newNode;
                        flag = true;
                        break;
                    }
                    temp = temp.next;
                }
                if (!flag)
                    Console.WriteLine("The Element is Absent");
            }
            return flag;
        }

        public bool DeleteAny(int data)
        {
            bool flag = false;
            int count = 0;

            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                Node previousNode = null;
                while (temp != null)
                {
                    count++;
                    if (temp.data == data)
                    {
                        if(count==1)
                        {
                            head = temp.next;
                        }
                        else
                        {
                            previousNode.next = temp.next;
                        }
                        flag = true;
                        break;
                    }
                    previousNode = temp;
                    temp = temp.next;
                }
                if (!flag)
                    Console.WriteLine("The Element is Absent");
            }

            return flag;
        }

        public int Size()
        {
            int count = 0;

            Node temp = head;
            while(temp!=null)
            {
                temp = temp.next;
                count++;
            }

            return count;
        }

    }
}