using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Proxi
{
    public class SmartTextReader
    {
        public virtual char[][] ReadFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File not found.", filePath);
            }

            string[] lines = File.ReadAllLines(filePath);
            char[][] charArray = new char[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                charArray[i] = lines[i].ToCharArray();
            }

            return charArray;
        }
    }
}
