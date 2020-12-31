using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList dataList = new LinkedList();
            dataList.insertHead(10);
            dataList.insertHead(20);
            dataList.insertHead(30);
            dataList.insertHead(40);
            dataList.insertHead(50);
            dataList.displayList();
            dataList.removeHead();
            dataList.displayList();
            dataList.insertTail(100);
            dataList.insertTail(5000);
            dataList.displayList();
            
            
        }
    }
    public class LinkedList
    {
        private Node head;
        public bool isEmpty()
        {
            return (head == null);
        }
        public void insertHead(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = head;
            head = newNode;
        }
        public Node removeHead()
        {
            Node temp = head;
            head = head.next;
            return temp;
        }
        public void insertTail(int data)
        {
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }
        public void displayList()
        {
            Console.WriteLine("List (first -- last)");
            Node current = head;
            while(current != null)
            {
                current.displayNode();
                current = current.next;
            }
            Console.WriteLine();
        }
    }
    public class Node
    {
        public int data;
        public Node next;

        public void displayNode()
        {
            Console.WriteLine("<" + data + ">");
        }
    }
}
