namespace LengthOfLongestSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "bbbbb";

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
                //In each iteration, start the bool over
                bool repeatedChars = false;
                
                //First check to see if this char exists in the existing substring
                for (int j = 0; j < substring.Length; j++)
                {
                    //If we find a match then we need to start the substring over.
                    if (substring[j] == s[i])
                    {
                        //Rebuild the substring
                        for (int k = j+1; k < substring.Length; k++)
                        {
                            
                        }
                    }
                }

                //Only add to the substring if there were no repeated chars
                if (repeatedChars == false)
                {
                    //Concatenate the next char in to the substring
                    substring += (s[i].ToString());
                }

                //If we found a repeated character, start the substring over at this char minus one.
                if (repeatedChars == true)
                {
                    if (s[i-1] != s[i])
                    {
                        //Start the substring over at i minus one
                        substring = s[i - 1].ToString();

                        //Add the char at i
                        substring += s[i];
                    }
                    else
                    {
                        substring = s[i].ToString();
                    }
                }


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
