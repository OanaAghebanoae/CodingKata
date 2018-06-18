using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static void WriteToFile(IEnumerable<string> lines, string filePath)
        {
            try
            {
                System.IO.File.WriteAllLines(filePath, lines);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
