using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab3
{
    class FileWriter
    {
        private string _filee;

        public FileWriter(string filename)
        {
            _filee = filename;
        }

        public void Write(string message)
        {
            File.AppendAllText(_filee, message);
        }

        public void WriteLine(string message)
        {
            Write(message + "\n");
        }


    }
}
