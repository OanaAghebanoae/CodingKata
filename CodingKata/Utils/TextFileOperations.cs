using System;
using System.Collections.Generic;
using System.IO;

namespace CodingKata.Utils
{
    public class TextFileOperations
    {
        public static IEnumerable<string> ReadAllLines(string filePath)
        {
            IEnumerable<string> lines = new List<string>();

            try
            {
                lines = System.IO.File.ReadAllLines(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return lines;
        }

        public static void WriteToFile(Dictionary<string, List<string>> lines, string filePath)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filePath);
                if (!File.Exists(filePath))
                {
                    sw = File.CreateText(filePath);
                }

                using (sw)
                {
                    foreach (var word in lines)
                    {
                        if (word.Value.Count > 1)
                        {
                            foreach (var w in word.Value)
                            {
                                sw.Write(w + " ");
                            }

                            sw.WriteLine();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
