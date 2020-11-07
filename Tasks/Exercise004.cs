using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

// Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
// Leave punctuation marks untouched.

namespace TechReturners.Tasks
{
    public class Exercise004
    {
        public static string PigIt(string str)
        {
            List<string> words = new List<string>();
            foreach (string word in str.Split(' ')) {
                string removePunctuation = Regex.Replace(word, @"[^\w\s]", "");
                string newWord = word.Replace(removePunctuation, string.Join("", removePunctuation.Skip(1)) + removePunctuation[0] + "ay");
                words.Add(newWord);
            }
            return string.Join(" ", words);
        }
    }
}

