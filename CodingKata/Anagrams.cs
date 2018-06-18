using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingKata.Utils;

namespace CodingKata
{
    // http://codekata.com/kata/kata06-anagrams/
    public class Anagrams
    {
        public void FindAnagrams(string filePath)
        {
            var wordsList = TextFileOperations.ReadAllLines(filePath);
            Dictionary<string, string> words = new Dictionary<string, string>();

            foreach (var word in wordsList)
            {
                words.Add(word.Trim(), OrderedLetters(word));
            }

            Dictionary<string, List<string>> anagramsList = words.GroupBy(w => w.Value)
                .ToDictionary(t => t.Key, t => t.Select(w => w.Key).ToList());
           
            Console.ReadLine();
        }

        private string OrderedLetters(string word)
        {
            return new string(word.Trim().OrderBy(c => c).ToArray());
        }
    }
}
