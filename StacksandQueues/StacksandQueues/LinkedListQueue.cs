using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksandQueues
{
    internal class LinkedListQueue
    {
        public Node head;
        public void Enqueue(int item)
        {
            Node new_node = new Node(item);
            if (this.head == null)
            {
                this.head = new_node;

            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;


            }
            Console.WriteLine("{0} is inserted into Queue", new_node.data);

        }





        public void Dequeue()
        {
            //if queue is empty,return null
            if (this.head == null)
            {
                Console.WriteLine("The Queue is empty");
                return;

            }
            //store previous head and move head pointer one step a head to delete the current element
            int deletedNode = this.head.data;
            this.head = this.head.next;
            Console.WriteLine("\n{0} is deleted from queue", deletedNode);
        }
    }

}

       
            
        
    









