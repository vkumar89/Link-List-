using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    internal class DeleteNode
    {
        public Node DeleteFromBeginning(Node head)
        {
            if (head == null) return head;
            else
            {
                head = head.next;
                return head;
            }
        }

        public Node DeleteFromEnd(Node head)
        {
            if (head == null||head.next==null) return head;
            else
            {
                Node cru = head;
                while(cru.next.next != null){
                    cru = cru.next;
                }
                cru.next = null;
                return head;
            }
        }

    }
}
