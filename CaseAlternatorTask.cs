using System;
using System.Collections.Generic;

namespace Passwords
{
    public class CaseAlternatorTask
    {
        public static List<string> AlternateCharCases(string lowercaseWord)
        {
            var result = new List<string>();
            AlternateCharCases(lowercaseWord.ToCharArray(), 0, result);
            return result;
        }

        static void AlternateCharCases(char[] word, int startIndex, List<string> result)
        {
            if (startIndex == word.Length)
            {
                var completeWord = new string(word);
                if (!result.Contains(completeWord))
                    result.Add(completeWord);
                return;
            }

            if (Char.IsLetter(word[startIndex]))
            {
                word[startIndex] = Char.ToLower(word[startIndex]);
                AlternateCharCases(word, startIndex + 1, result);
                word[startIndex] = Char.ToUpper(word[startIndex]);
            }
            AlternateCharCases(word, startIndex + 1, result);
        }
    }
}