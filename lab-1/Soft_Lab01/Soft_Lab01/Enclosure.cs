using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Lab01
{
    internal class Enclosure
    {
        public double Size { get; set; }
        public string Type { get; set; }

        public Enclosure(string type, double size)
        {
            Type = type;
            Size = size;
        }

        public string GetInfo()
        {
            return $"Enclosure: {Type}, Size: {Size} sm";
        }
    }
}
