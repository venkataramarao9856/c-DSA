using System;

namespace LinkedList // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Console.WriteLine("The following are the linked list operations that you can perform");

            while(true)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("1. Add element at start");
                Console.WriteLine("2. Add element at end");
                Console.WriteLine("3. Count the number of elements");
                Console.WriteLine("4. Display Elements");
                Console.WriteLine("5. InsertElementAt");
                Console.WriteLine("6. DeleteStart");
                Console.WriteLine("Enter your choice");
                     int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        list.AddElementAtStart();
                        break;
                    case 2:
                        list.AddElementAtEnd();
                        break;
                    case 3:
                        list.CountOfElements();
                        break;
                    case 4:
                        list.DisplayElements();
                        break;
                    case 5:
                        list.InsertElementAt();
                        break;
                    case 6:
                        list.DeleteStart();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}