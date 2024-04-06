using System;

namespace Merge_Two_Sorted_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode();
            ListNode l2 = new ListNode();

            
            ListNode solution = MergeTwoLists(l1,l2);

            Console.WriteLine($"{solution.val}");
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
                result.next = l2;
            }

            

            return result;
        }
        
    }
    
}
