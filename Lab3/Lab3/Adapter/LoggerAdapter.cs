using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class LoggerAdapter
    {
        private FileWriter _fileWriter;

        public LoggerAdapter(FileWriter fileWriter)
        {
            _fileWriter = fileWriter;
        }

        public void Log(string message)
        {
            _fileWriter.WriteLine($"[LOG]: {message}");
        }

        public void Error(string message)
        {
            _fileWriter.WriteLine($"[ERROR]: {message}");
        }

        public void Warn(string message)
        {
            _fileWriter.WriteLine($"[WARN]: {message}");
        }
    }
}
