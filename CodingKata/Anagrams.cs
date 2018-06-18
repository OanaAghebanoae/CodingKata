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
        public void FindAnagrams()
        {
            var wordsList = TextFileOperations.ReadAllLines(@"../../Resources/anagrams.txt");
            Console.ReadLine();
        }
    }
}
