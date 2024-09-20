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

            Console.WriteLine($"The head of the sorted list is: {solution.val}. Thank you!");
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
            //Set up result - aka "dummy node"
            ListNode result = new ListNode(0);

            //Set up current node to built the new list
            ListNode current = result;

            //Loop while both lists are not null
            while (l1 != null && l2 != null)
            {

                //Find the lower number to set as the "val" of the result list.
                
                //Scenario 1 - l1 is less
                if (l1.val < l2.val)
                {
                    //Assign the lower number to current
                    current.next = l1;

                    //Since we used l1 we need to advance it
                    l1 = l1.next;
                }
                //Scenario 2 - l2 is less (or they are equal)
                else
                {
                    //Assign the lower number to current
                    current.next = l2;

                    //Since we used l2 we need to advance it
                    l2 = l2.next;
                }

                //Since we just made current.next in the above code,
                //we need to move current forward to get ready for next iteration of the loop 
                current = current.next;

            }

            //Append the remaining elements once the above loop has been broken out of
            if (l1 != null)
            {
                current.next = l1;
            }
            else
            {
                current.next = l2;
            }

            return result.next;
        }
        
    }
    
}
