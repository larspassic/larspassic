using System;

namespace Merge_Two_Sorted_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create list1 by walking through each node
            ListNode list1 = new ListNode(1);
            list1.next = new ListNode(2);
            list1.next.next = new ListNode(4);

            //Create list2 by walking through each node
            ListNode list2 = new ListNode(1);
            list2.next = new ListNode(3);
            list2.next.next = new ListNode(4);

            
            ListNode solution = MergeTwoLists(list1,list2);

            Console.WriteLine($"{solution.val}");
        }


        //Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            
            //This is the constructor
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();

            //Find the lower number to set as the "val" of the result list.
            if (l1.val < l2.val)
            {
                result.val = l1.val;
            }
            else if (l1.val > l2.val)
            {
                result.val = l2.val;
            }
            else if(l1.val == l2.val)
            {
                result.val = l1.val;
                result.next = l2.next;
            }

            

            return result;
        }
        
    }
    
}
