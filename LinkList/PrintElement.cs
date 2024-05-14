using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    internal class PrintElement
    {
        public void PrintValue(Node head)
        {
            if(head == null) Console.WriteLine("head is null");
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    Console.Write(temp.data+" ");
                    temp = temp.next;
                }
                Console.WriteLine(temp.data);
                Console.WriteLine("------------------------");
            }
        }
    }
}
