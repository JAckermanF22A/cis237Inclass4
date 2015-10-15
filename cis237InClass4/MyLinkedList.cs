using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass4
{
    class MyLinkedList
    {
        //Private variable to hold the current position of where we are in the linked list
        private Node current;
        
        //A public property that will point to the Head node. (The first one in the list)
        public Node Head
        {
            get;
            set;
        }

        //Constructor. It will set the head to null because there is nothing in the list yet.
        public MyLinkedList()
        {
            Head = null;
        }

        public void Add(string content)
        {
            Node node = new Node();
            node.Data = content;

            if(Head == null)
            {
                Head = node;
            }
            else
            {
                current.Next = node;
            }

            current = node;
        }

        public bool delete(int Position)
        {
            current = Head;

            if(Position == 1)
            {
                Head = current.Next;
                current.Next = null;
                current = null;
                return true;
            }

            if(Position > 1)
            {
                Node tempNode = Head;
                Node lastNode = null;
                int count = 0;

                while(tempNode != null)
                {
                    if(count == Position -1)
                    {
                        lastNode.Next = tempNode.Next;

                        tempNode.Next = null;
                        return true;
                    }

                    count++;

                    lastNode = tempNode;
                    tempNode = tempNode.Next;
                }
            }
            return false;

        }
    }
}
