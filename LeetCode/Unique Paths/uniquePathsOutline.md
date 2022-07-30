Instructions
===
https://leetcode.com/problems/unique-paths/


Outline
===
Trying to imagine the solution visually

Example: Assume a 4 x 4 grid

| | 1 | 2 | 3 | 4 |
| - | - | - | - | - |
| 1 | ⏹️ | ⏹️ | ⏹️ | ⏹️ | 
| 2 | ⏹️ | ⏹️ | ⏹️ | ⏹️ | 
| 3 | ⏹️ | ⏹️ | ⏹️ | ⏹️ | 
| 4 | ⏹️ | ⏹️ | ⏹️ | ⏹️ | 

Each solution will always be **six steps/moves**:
| | 1 | 2 | 3 | 4 |
| - | - | - | - | - |
| 1 | 🟩 | ⏹️ | ⏹️ | ⏹️ | 
| 2 | 1️⃣ | ⏹️ | ⏹️ | ⏹️ | 
| 3 | 2️⃣ | ⏹️ | ⏹️ | ⏹️ | 
| 4 | 3️⃣ | 4️⃣ | 5️⃣ | 6️⃣ | 

No matter the path, always **six steps/moves**:
| | 1 | 2 | 3 | 4 |
| - | - | - | - | - |
| 1 | 🟩 | ⏹️ | ⏹️ | ⏹️ | 
| 2 | 1️⃣ | 2️⃣ | ⏹️ | ⏹️ | 
| 3 | ⏹️ | 3️⃣ | 4️⃣ | ⏹️ | 
| 4 | ⏹️ | ⏹️ | 5️⃣ | 6️⃣ | 

## Approach 1
> Notes: This approach seems like it will mostly result in straight lines. Not sure how to alternate multiple times, ie. "down, right, down, right, right, down"
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
> Notes: This approach seems like it could theoretically work but it could take a million years to randomly/accidentally eventually get all of the combinations correct.
1. Randomly alternate between down and right.
    - Randomly choose to move down or right first
    - Then alternate after that
1. Randomly choose how many spaces to move.

## Approach 3
> Notes: Need to be able to dynamically alternate (right/down) while also being able to dynamically alternate how many squares to move in a row.
1. ??