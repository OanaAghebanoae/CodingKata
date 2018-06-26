using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CodingKata.Utils;

namespace CodingKata
{
    // http://codekata.com/kata/kata06-anagrams/
    public class Anagrams
    {
        public void FindAnagrams(string sourceFilePath, string resultFilePath)
        {
            var wordsList = TextFileOperations.ReadAllLines(sourceFilePath);
            Dictionary<string, string> wordsKeys = new Dictionary<string, string>();

            foreach (var word in wordsList)
            {
                wordsKeys.Add(word.Trim(), OrderedLetters(word));
            }

            Dictionary<string, List<string>> anagramsList = wordsKeys.GroupBy(w => w.Value)
                .ToDictionary(t => t.Key, t => t.Select(w => w.Key).ToList());

            TextFileOperations.WriteToFile(anagramsList, resultFilePath);

            Console.ReadLine();
        }

        private string OrderedLetters(string word)
        {
            return new string(word.Trim().OrderBy(c => c).ToArray());
        }
    }
}
