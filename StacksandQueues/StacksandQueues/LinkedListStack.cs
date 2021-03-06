using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksandQueues
{
    internal class LinkedListStack
    {
        public Node top;
       
        public void push(int newData)
        {
            //creating a link between newnode and where node is pointing
            //then pointing top towards the new node
            //new node is inserted on the top
            Node newNode = new Node(newData);
            if(this.top != null)
            {
                newNode.next = this.top;

            }
            this .top = newNode;//new node will hold the address of top element
            Console.WriteLine("New node {0} is added", newNode.data);

        }
        //displaying the values in stack
        public void Display()
        {
            //checking if stack is not empty
            //printing values till emp point towards null i.e. end of stack
            Node temp = this.top;
            if(temp==null)
            {
                Console.WriteLine("no values to display,empty");
                return;

            }
            while(temp!= null)
            {
                Console.WriteLine("value in the stack :" +temp.data);
                temp = temp.next;

            }
        }
        //Displaying the top element
        //uc2
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("no element present to peek");
                return;

            }
            Console.WriteLine("Top most element "+ this.top.data);
            
        }
        
        
        
    
        //Displaying the top element
        //uc2
        public void Pop()
        {
            if (this.top==null)
            {
                Console.WriteLine("no element present to Pop");
                return;


            }
            else
            {
                //peek();
                int deletedNode=this.top.data;
                this.top = top.next;
                Console.WriteLine("{0} is deleted from the stack",deletedNode);

            }
        }

        public bool isEmpty()
        {
            while(this.top != null)
            {
                Peek();
                Pop();
            }
            return true;
        }
       


        }
        

    }

    

