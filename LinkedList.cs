using System;
using System.Security.Cryptography.X509Certificates;

namespace LinkedList
{
    public class LinkedList
    {
        private Node? _head;
        public LinkedList()
        {
             _head=null;
        }
        public void DisplayElements()
        {
            if (_head == null)
            {
                Console.WriteLine("There are no elements in the linked list");
            }
            else
            {
                Console.WriteLine("The elements in the list are : ");
                Node? temp = new Node();
                temp = _head;
                while (temp != null)
                {
                    Console.WriteLine(temp.Data + " ");
                    temp = temp.Next;
                }
            }
        }
        public void AddElementAtStart()
        {
            Node newNode = new Node();
            Console.WriteLine("Enter the value of Node");
            int val = Convert.ToInt32(Console.ReadLine());
            newNode.Data = val;
            if(_head==null)
            {
                _head = newNode;
            }
            else
            {
                newNode.Next = _head;
                _head = newNode;
            }
            DisplayElements();
        }
        public void AddElementAtEnd()
        {
            Node newNode = new Node();
            Console.WriteLine("Enter the value of Node");
            int val = Convert.ToInt32(Console.ReadLine());
            newNode.Data = val;
            newNode.Next = null;
            if(_head==null)
            {
                _head=newNode;
            }
            else
            {
                Node temp = new Node();
                temp = _head;
                while(temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode; 
            }
            DisplayElements();
        }
        public void CountOfElements()
        {
            int count = 1;
            if(_head==null)
            {
                Console.WriteLine("There are no elements :");
            }
            else
            {
                Node temp = _head;
                while(temp.Next!=null)
                {
                    count++;
                    temp= temp.Next;
                }
                Console.WriteLine("The number of elements in the list are : "+count);
            }
        }
        public void InsertElementAt()
        {
            Node newNode = new Node();
            Console.WriteLine("Enter the position where element needs to be inserted : ");
            int position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of Node");
            int val = Convert.ToInt32(Console.ReadLine());
            newNode.Data = val;
            if(position<1)
            {
                Console.WriteLine("Please neter a valid input");
            }
            else if(position ==1)
            {
                _head = newNode;
            }
            else
            {
                Node? temp = new Node();
                temp = _head;
                for(int i=1;i<position-1;i++)
                {
                    if(temp!=null)
                    {
                        temp = temp.Next;
                    }
                }
                if(temp!=null)
                {
                    newNode.Next=temp.Next;
                    temp.Next = newNode;
                    DisplayElements();
                }
                else
                {
                    Console.WriteLine("The previous node is null");
                }
            }
        }

        public void DeleteStart()
        {
            if(_head==null)
            {
                Console.WriteLine("There are no elements in the linked list");
            }
            else
            {
                Node? temp = new Node();
                temp = _head;
                _head = _head.Next;
                temp = null;
                DisplayElements();
            }
        }
    }
}
