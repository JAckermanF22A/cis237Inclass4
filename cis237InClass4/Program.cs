using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.Add("first");
            myLinkedList.Add("second");
            myLinkedList.Add("third");
            myLinkedList.Add("fourth");

            for(Node x = myLinkedList.Head; x !=null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }
            Console.WriteLine();
            Console.WriteLine();

            myLinkedList.delete(2);
            myLinkedList.delete(2);

            for (Node x = myLinkedList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
