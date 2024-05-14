using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    internal class SearchNode
    {
        public int SeachNode(Node head,int value)
        {
            int ind = 1;
            Node temp = head;
            while(temp != null)
            {
                if(temp.data== value)
                {
                    return ind;
                }
                else
                {
                    ind++;
                    temp = temp.next;
                    
                }
                
            }
            return -1;
        }
    }
}
