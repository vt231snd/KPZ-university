using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Decorator
{
    public class Palladin : Characters
    {
        public string GetInfo()
        {
            return "Рицар";
        }

        public int GetStrength()
        {
            return 20;
        }
    }
}
