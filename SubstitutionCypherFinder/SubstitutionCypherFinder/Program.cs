using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string encryptedText = "zmobppf fxu tvbws bo mjjvoqv rxxt kdmwv bq kbpp bq fxu fxu iuqs mk xivo bor avsxpr xov pbqk kvttmzfmog qmgsk";
        List<string> commonWords = new List<string> { "the", "you", "and", "is", "it", "an", "as" };

        foreach (var permutation in GetPermutations("abcdefghijklmnopqrstuvwxyz", 26))
        {
            string decryptedText = Decrypt(encryptedText, permutation);
            if (ContainsCommonWords(decryptedText, commonWords))
            {
                Console.WriteLine($"Possible solution with permutation: {new string(permutation)}");
                Console.WriteLine(decryptedText);
            }
        }
    }

    static IEnumerable<char[]> GetPermutations(string characters, int length)
    {
        if (length == 1)
            return characters.Select(t => new char[] { t });

        return GetPermutations(characters, length - 1)
            .SelectMany(t => characters, (t1, t2) => t1.Concat(new char[] { t2 }).ToArray());
    }

    static string Decrypt(string encryptedText, char[] substitution)
    {
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        Dictionary<char, char> cipher = new Dictionary<char, char>();
        for (int i = 0; i < alphabet.Length; i++)
        {
            cipher[alphabet[i]] = substitution[i];
        }

        char[] decrypted = encryptedText.Select(c => cipher.ContainsKey(c) ? cipher[c] : c).ToArray();
        return new string(decrypted);
    }

    static bool ContainsCommonWords(string text, List<string> commonWords)
    {
        return commonWords.Any(word => text.Contains(word));
    }
}
