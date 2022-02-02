using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksandQueues
{
    internal class CustomLinkedList
    {

        public Node head;
        public void AddLast(int data)
        {
            Node new_node = new Node(data);
            if (this.head == null)
            {
                this.head = new_node;

            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;

            }
            Console.WriteLine("{0} Node inserted into linkedlist ", new_node.data);


        }
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;


        }

        public void Display()
        {
            Console.WriteLine("Displaying Nodes");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data + "");
                    temp = temp.next;
                }
                //console.Write ("  "+temp.data);

            }
        }

    }
}
