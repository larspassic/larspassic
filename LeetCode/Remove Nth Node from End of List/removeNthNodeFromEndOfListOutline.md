Instructions
===
https://leetcode.com/problems/remove-nth-node-from-end-of-list/

Outline
===
Inputs are the list, as well as the n number of nodes from the end of the list.

Example: head = [1,2,3,4,5], n = 2

1. First I will find out how many nodes in the list there are.
    - Find the "length" of the list? (Length = 5 in the example)
1. Next I will subtract the total number of nodes by the nth node from the input.
    - Take nth number and subtract 1 from it. This will account for the last node in the list. (so n -1 = 1)
    - Take the new value of n and subtract it from the length of the list. (From example: 5 (length) - 1 (new value for n))
    - Result is 4, so we will be removing node 4.
1. Use new value for n to remove node[n] from the list.