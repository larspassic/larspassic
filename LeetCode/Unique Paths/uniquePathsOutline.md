Instructions
===
https://leetcode.com/problems/unique-paths/


Outline
===
## Approach 1

Example: Assume a 4 x 4 grid

1. Count every possibility while increasing the x-axis by 1 each time.
    - Down down down right right right
    - Right down down down right right
    - Right Right down down down right
    - right right right down down down
1. Count every possibility while increasing the y-axis by 1 each time.
    - Right right right down down down
    - Down right right right down down
    - Down down right right right down
    - Down down down right right right
1. Count every possibility while alternating increasing the x-axis and y-axis by 1, each time.
    - Down right down right down right
    - ???
1. Remove any duplicates from the entire list of possibilities.

## Approach 2
1. Randomly alternate between down and right.