using System;

namespace Remove_Nth_Node_from_End_of_List
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3); 
            //head.next.next.next = new ListNode(4); 
            //head.next.next.next.next = new ListNode(5);

            int n = 3;

            ListNode displayResult = RemoveNthFromEnd(head, n);
        }

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            //Set up the result
            ListNode result = head;

            //Create a ListNode object that will be used to walk the list (listWalker?)
            ListNode listWalker = result;

            //Create a ListNode object that will be used to represent the new tail
            //when we remove the n object from the list (newTail?)
            ListNode newTail = null;

            //Find the length of the list
            int listNodeSize = 1;
            ListNode listNodeCounter = head;

            //Loop that will traverse the list and count the listNodeSize
            while (listNodeCounter.next != null)
            {
                listNodeSize++;
                listNodeCounter = listNodeCounter.next;
            }

            //Now that we know the size of the ListNode, only do this work if it's larger than 2
            if (listNodeSize == n)
            {
                //If the size of the list and n are the same
                //That means, remove the head of the list. So put this case first.
                result = result.next;
            }
            else if (listNodeSize > 2)
            {
                //Move through the ListNode object until we reach size minus n,
                //to find the node prior to the one that needs to be removed.
                for (int i = 1; i < (listNodeSize - n); i++)
                {
                    //Is this how I walk a list??
                    listWalker = listWalker.next;
                }

                //Go forward in the list two times (.next.next?)
                //which will be where the list picks up after n is removed.
                newTail = listWalker.next.next;

                //Set listWalker.next to be equal to newTail. Now we have removed n.
                listWalker.next = newTail;

            }
            //Special section to remove last number
            else if (listNodeSize == 2 && n == 1)
            {
                listWalker.next = null;
            }




            return result;
        }

    }
    
    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}
