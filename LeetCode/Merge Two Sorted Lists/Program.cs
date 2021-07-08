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

            Console.WriteLine($"{solution}");
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

            return result;
        }
        
    }
    
}
