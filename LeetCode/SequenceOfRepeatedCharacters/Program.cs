
namespace SequenceOfRepeatedCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputSequence = "AAAABBB1111CCCDD";

            Console.WriteLine($"The input string sequence is: {inputSequence}");
            Console.WriteLine();

            string resultSequence = Compress(inputSequence);

            Console.WriteLine($"The compressed string is: {resultSequence}");
            Console.WriteLine();

            string decompressedString = Decompress(resultSequence);

            Console.WriteLine($"The decompressed string is  : {decompressedString}");
        }



        public static string Compress(string uncompressedString)
        {
            char currentChar = uncompressedString[0];
            int currentCharCount = 0;
            string compressedString = string.Empty;

            for (int i = 0; i < uncompressedString.Length; i++)
            {
                //If the current char was found at index i
                if (uncompressedString[i] == currentChar)
                {
                    //Then increase currentCharCount
                    currentCharCount++;
                }
                else
                {
                    
                    //If the character doesn't match the repeated character, commit progress to the compressed string
                    compressedString += (currentCharCount.ToString() + currentChar.ToString());
                    
                    //Change to the new char
                    currentChar = uncompressedString[i];
                    currentCharCount = 1;

                }

            }
            
            compressedString += (currentCharCount.ToString() + currentChar.ToString());

            return compressedString;
        }

        private static string Decompress(string resultSequence)
        {
            
            string decompressedString = string.Empty;

            for (int i = 0; i < resultSequence.Length; i++)
            {
                //If i is odd, do this
                if (i == 0 || (i % 2) == 0)
                {
                    int currentCharCount = (resultSequence[i])-'0';
                    char currentChar = resultSequence[i+1];

                    while (currentCharCount != 0)
                    {
                        decompressedString += currentChar.ToString();
                        currentCharCount--;
                    }
                }

            }

            return decompressedString;
        }

    }



}
