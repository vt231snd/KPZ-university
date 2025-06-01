using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab3.Proxi
{
    public class SmartTextReaderLocker : SmartTextReader
    {
        private readonly string _lockerPattern;

        public SmartTextReaderLocker(string lockPattern)
        {
            _lockerPattern = lockPattern;
        }

        public override char[][] ReadFile(string filePath)
        {
            if (Regex.IsMatch(filePath, _lockerPattern))
            {
                Console.WriteLine("Access denied!");
                return null;
            }

            return base.ReadFile(filePath);
        }
    }
}
