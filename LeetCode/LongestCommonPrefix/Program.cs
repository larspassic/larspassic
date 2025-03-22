using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = {"flower", "flow", "flight" };

            Console.WriteLine($"The strings we are evaluating are: ");
            strs.ToList().ForEach(Console.WriteLine);
            Console.WriteLine();

            string finalResult = LongestCommonPrefix(strs);

            Console.WriteLine($"The longest common prefix among those input words is: {finalResult}");


        }

        public static string LongestCommonPrefix(string[] strs)
        {
            string result = "";

            //Use Linq to sort the array of strings
            var sorted = strs.OrderBy(n => n.Length);

            //Use Linq to get the shortest one
            var shortest = sorted.FirstOrDefault();

            //Store boolean that controls if prefix is still common
            bool isCommon = true;

            //Outer loop is based on the number of letters of the shortest word in the input array.
            for (int i = 0; i < shortest.Length; i++)
            {
                //Store the first letter of the shortest word in strs
                char currentLetter = shortest[i];

                //Inner loop
                for (int j = 0; j < strs.Length; j++)
                {
                    if (currentLetter != strs[j][i])
                    {
                        isCommon = false;
                        break;
                    }

                }

                if (isCommon == true)
                {
                    result += currentLetter;
                }
                else
                {
                    break;
                }

            }

            return result;
        }
    }
}
