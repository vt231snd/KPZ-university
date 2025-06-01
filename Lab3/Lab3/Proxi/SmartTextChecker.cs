using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Proxi
{
    public class SmartTextChecker : SmartTextReader
    {
        private readonly SmartTextReader _smartTextReader;

        public SmartTextChecker(SmartTextReader smartTextReader)
        {
            _smartTextReader = smartTextReader;
        }

        public override char[][] ReadFile(string filePath)
        {
            Console.WriteLine("Opening file...");
            char[][] result;

            try
            {
                result = _smartTextReader.ReadFile(filePath);
                Console.WriteLine("File read successfully.");

                int totalLines = result.Length;
                int totalChars = 0;

                foreach (var line in result)
                {
                    totalChars += line.Length;
                }

                Console.WriteLine($"Total lines: {totalLines}, Total characters: {totalChars}");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return null;
            }

            Console.WriteLine("Closing file...");
            return result;
        }
    }
}
