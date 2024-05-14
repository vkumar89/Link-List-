using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LinkList
{
    internal class AddElement
    {

        public Node AddNode()
        {
            Node head = new Node(10);
            head.next = new Node(5);
            head.next.next = new Node(20);
            head.next.next.next = new Node(15);

            return head;
        }
        public Node InsertInBegnning(Node head, int data)
        {

            if (head == null) { head.data = data; head.next = null; return head; }
            else
            {
                Node temp = new Node(data);
                temp.next = head;
                return temp;

            }

        }
        public Node InsertInEnd(Node head, int data)
        {
            Node temp = new Node(data);

            if (head == null) { return temp; }
            else
            {
                Node cru = head;
                while (cru.next != null)
                {
                    cru = cru.next;
                }
                cru.next = temp;
                return head;
            }


        }

        public Node InsertAtGivenPos(Node head,int data,int ind)
        {
            Node temp = new Node(data);
            if (ind == 1)
            {
                temp.next = head;
                return temp;
            }

            Node cru = head;
            for (int i = 1; i <= ind - 2 && cru != null; i++){
                cru = cru.next;
            }
            if (cru == null) return head;
            temp.next = cru.next;
            cru.next = temp;
            return head;
        }
    }
}
