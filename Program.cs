using System;
using System.Collections.Generic;

namespace LinkedListAppp
{
    class Program
    {

        public class Node
        {
            public int data;
            public Node next;

            public Node(int datas)
            {
                data = datas;
                next = null;
            }
        }



        public class NodeImplementation
        {
            Node head = null;

            public void PrintList()
            {
                Node current = head;

                while (current != null)
                {
                    Console.Write(current.data + " -> ");
                    current = current.next;
                }
                Console.Write("null");
                Console.WriteLine("");
            }


            public void CountList()
            {
                int count = 0;
                Node current = head;
                while (current != null)
                {
                    count++;
                    current = current.next;
                }
                Console.WriteLine("No. of nodes : " + count);
            }


            private void AddFirst(int val)
            {
                Node node = new Node(val);
                head = node;

            }


            public void AddToTop(int val)
            {
                if (head != null)
                {
                    Node node = new Node(val);
                    node.next = head;
                    head = node;
                }
            }


            public void Add(int val)
            {
                if (head == null)
                {
                    AddFirst(val);
                }
                else
                {
                    Node node = new Node(val);
                    Node current = head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = node;
                }

            }


            public void AddAfter(int nodeVal, int newNode)
            {
                Node node = new Node(newNode);
                Node current = head;

                while (current != null)
                {
                    if (current.data == nodeVal)
                    {
                        break;
                    }
                    current = current.next;
                }

                node.next = current.next;
                current.next = node;
            }


            public void AddBefore(int nodeVal, int newNode)
            {
                Node node = new Node(newNode);
                Node current = head;

                while (current.next != null)
                {
                    if (current.next.data == nodeVal)
                    {
                        break;
                    }
                    current = current.next;
                }

                node.next = current.next;
                current.next = node;

            }


            public void AddBeforePosition(int position, int newNode)
            {
                Node node = new Node(newNode);
                Node current = head;

                for (int i = 1; i < position - 1 && current != null; i++)
                {
                    current = current.next;
                }

                node.next = current.next;
                current.next = node;
            }


            public void AddAfterPosition(int position, int newNode)
            {
                Node node = new Node(newNode);
                Node current = head;

                for (int i = 1; i < position + 1 && current != null; i++)
                {
                    current = current.next;
                }

                node.next = current.next;
                current.next = node;
            }


            public void Find(int nodeVal)
            {
                int position = 1;
                bool found = false;
                Node current = head;

                while (current != null)
                {
                    if (current.data == nodeVal)
                    {
                        found = true;
                        Console.WriteLine("Found node at position : " + position);
                        break;
                    }
                    position++;
                    current = current.next;
                }

                if (!found)
                {
                    Console.WriteLine(nodeVal + " was not found.");
                }
            }


            public void FindAtPosistion(int position)
            {
                Node current = head;

                for (int i = 1; i < position && current != null; i++)
                {
                    current = current.next;
                }

                Console.WriteLine("Found node " + current.data);
            }


            public void FindLast()
            {
                Node current = head;

                while (current.next != null)
                {
                    current = current.next;
                }
                Console.WriteLine("The last node value is : " + current.data);
            }


            public void FindBefore(int nodeVal)
            {
                bool found = false;
                Node current = head;
                while (current.next != null)
                {
                    if (current.next.data == nodeVal)
                    {
                        found = true;
                        Console.WriteLine("Node value before " + nodeVal + " is " + current.data);
                        break;
                    }
                    current = current.next;
                }
                if (!found)
                {
                    Console.WriteLine("Node after " + nodeVal + " was not found.");
                }
            }


            public void FindAfter(int nodeVal)
            {
                bool found = false;
                Node current = head;
                while (current != null)
                {
                    if (current.data == nodeVal)
                    {
                        found = true;
                        Console.WriteLine("Node value after " + nodeVal + " is " + current.next.data);
                        break;
                    }
                    current = current.next;
                }

                if (!found)
                {
                    Console.WriteLine("Node after " + nodeVal + " was not found.");
                }
            }



            public void DeleteNode(int nodeVal)
            {
                Node current = head;

                while(current != null)
                {
                    if(current.next.data == nodeVal)
                    {
                        break;
                    }
                    current = current.next;
                }
                current.next = current.next.next;
            }


            public void DeleteFirst()
            {
                head = head.next;
            }


            public void DeleteLast()
            {
                Node current = head;
                while(current.next.next != null)
                {
                    current = current.next;
                }

                current.next = null;
            }
        }





        static void Main(string[] args)
        {
            NodeImplementation nodes = new NodeImplementation();


            int[] num = { 1, 2, 3, 4, 5 };


            nodes.Add(12);
            nodes.Add(5);
            nodes.Add(6);
            nodes.Add(7);
            nodes.Add(8);

            nodes.AddToTop(90);
            nodes.AddAfter(90, 13);
            nodes.AddBefore(5, 83);
            nodes.AddBeforePosition(4, 70);
            nodes.AddAfterPosition(4, 16);

            nodes.DeleteNode(6);
            nodes.DeleteFirst();
            nodes.DeleteLast();


            nodes.PrintList();
            nodes.CountList();

            nodes.Find(12);
            nodes.FindLast();
            nodes.FindAtPosistion(4);
            nodes.FindBefore(16);
            nodes.FindAfter(83);


        }
    }
}
