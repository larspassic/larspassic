Instructions
===
https://leetcode.com/problems/subsets/

Outline
===
1. First, I will need to use the integer array to build a new array with every possible subset, including duplicates. (The "super set" ?)
    - Create a list object variable **superSet** to hold the super set
    - Loop through the provided list and add subsets to the "super set"
		- A subset will consist of the index [i] as the first number, and [i+1] as the second number ([i], [i+1]), ([i], [i+2]), etc.
		- Add each subset to the **superSet** list object
        - The result will be a ballooned extremely huge list of every possible combination

1. Once I have the "super set" I will then remove duplicates from it.
    - Loop through the **superSet** list object
        - Read subset A (perhaps use the index [i] to find it?)
        - Read subset B (perhaps [i+1])
        - Compare the two objects to see if they are the same
            - If first number of subset A is equal to first number of subset B
            - And if second number of subset B is equal to first number of subset B
            - Then these two subsets are the same
            - Remove subset B
    - How will I keep track of the index if I'm constantly removing objects from the super set? The indexes will keep changing.
        - Perhaps I have an entirely separate set? Or just add only the unique values to the **resultSet** aka The "Power Set" ?

1. Submit the final result (The "Power set")