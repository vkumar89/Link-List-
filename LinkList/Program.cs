namespace LinkList
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region instances
            AddElement addElement = new AddElement();
            PrintElement printElement = new PrintElement();
            DeleteNode deleteNode = new DeleteNode();
            SearchNode searchNode = new SearchNode();
            #endregion

            //add elements in linklist
            Node head = addElement.AddNode();
            printElement.PrintValue(head);

            ////add elements in linklist at bignning
            //head = addElement.InsertInBegnning(head, 50);
            //printElement.PrintValue(head);

            ////add elements in linklist at end
            //head = addElement.InsertInEnd(head, 70);
            //printElement.PrintValue(head);

            ////add elements in linklist at Given position
            //head = addElement.InsertAtGivenPos(head, 80, 2);
            //printElement.PrintValue(head);

            ////Delete Node from Beginning
            //head = deleteNode.DeleteFromBeginning(head);
            //printElement.PrintValue(head);

            ////Delete Node from End
            //head = deleteNode.DeleteFromEnd(head);
            //printElement.PrintValue(head);


            //search Node in LinkList
            Console.WriteLine(searchNode.SeachNode(head,5));


        }
    }
}
