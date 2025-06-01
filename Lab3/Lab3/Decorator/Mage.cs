using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Decorator
{
    public class Mage : Characters
    {
        public string GetInfo()
        {
            return "Маг";
        }

        public int GetStrength()
        {
            return 28;
        }
    }
}
