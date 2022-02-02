using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksandQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPlease choose program number to execute ");
            Console.WriteLine("1:LinkedList\n2:stack\n3:Queue\n4:Exit\n5:copying elements from queue into stack\n6:Splitting Array");
            int input=Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:

                    Console.WriteLine("Builtin");
                    LinkedList<int> list = new LinkedList<int>();
                    list.AddLast(10);
                    list.AddLast(20);
                    list.AddLast(30);

                    foreach (int element in list)
                    {
                        Console.WriteLine(element);
                    }
                    list.RemoveFirst();
                    foreach (int element in list)
                    {
                        Console.WriteLine(element);
                    }
                    Console.WriteLine();
                    Console.WriteLine("After removing 1st node");
                    list.RemoveFirst();
                    foreach (int element in list)
                    {
                        Console.WriteLine("element");
                    }
                    Console.WriteLine("custom");
                    CustomLinkedList linkedList = new CustomLinkedList();
                    // linkedList.AddLast(56);
                    // linkedList.AddLast(30);
                    // linkedList.AddLast(70);
                    // linkedList.AddFirst(70);
                    //linkedList.AddFirst(30);
                    //linkedList.AddFirst(56);
                    //linkedList.Display();
                    // linkedList.Append();
                    //linkedlist.Append(56);
                    //  linkedlist.Append(30);
                    // linkedlist.Append(70);
                    // LinWkedlist.Display();
                    //int res = linkedList.DeleteFirstNode();
                    //if (res != 0)
                    //    Console.WriteLine("\n{0} is deleted from linkedList", res);
                    linkedList.Display();


                    //  linkedList.DeleteLastNode();
                    Console.WriteLine();
                   // int searchData = linkedList.search(30);
                   //if (searchData != 0)
                       // Console.WriteLine("\n{0} is present in the linked list", searchData);
                    break;
                case 2:

                    Console.WriteLine("Builtin stack operation");
                    Stack<int> stack = new Stack<int>();
                    stack.Push(10); 
                    stack.Push(40);
                    stack.Push(30);
                    foreach (int element in stack)
                    {
                        Console.WriteLine(element);

                    }
                    Console.WriteLine("custom stack class operations using Linkedlist");
                    LinkedListStack linkedStack = new LinkedListStack();
                    linkedStack.push(70);
                    linkedStack.push(30);
                    linkedStack.push(56);


                    break;

                    Console.ReadLine();


            }

        }
    }
}
