namespace LengthOfLongestSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "ghgg";

            int displayResult = LengthOfLongestSubstring(s);

            Console.WriteLine("Hello, World!");
            Console.WriteLine($"The length of the longest substring is: {displayResult}");
        }

        public static int LengthOfLongestSubstring(string s)
        {
            //Variable to hold largest substring length
            int result = 0;

            string substring = "";

            //Outer loop that goes through string s
            for (int i = 0; i < s.Length; i++)
            {
                
                //Loop to check if this char exists in the existing substring
                for (int j = 0; j < substring.Length; j++)
                {
                    //If we find a match then we need to start the substring over
                    if (substring[j] == s[i])
                    {
                        //Make a new substring
                        string newSubstring = "";

                        //Rebuild the substring by starting at position j+1 which is the position after the dupe was found
                        for (int k = j + 1; k < substring.Length; k++)
                        {
                            //Add each letter
                            newSubstring += substring[k].ToString();
                        }

                        //Replace substring with newSubstring
                        substring = newSubstring;
                    }
                }

                //Concatenate the next char in to the substring
                substring += (s[i].ToString());


                //Store the length of the substring as result
                if (substring.Length > result)
                {
                    result = substring.Length;
                }
                
            }

            return result;
        }
    }
}
