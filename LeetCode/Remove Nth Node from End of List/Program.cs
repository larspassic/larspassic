using System;

namespace Remove_Nth_Node_from_End_of_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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

    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode result = null;

            return result;
        }
    }
}
