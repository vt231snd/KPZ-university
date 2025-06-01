using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Decorator
{
    public class Warrior : Characters
    {
        public string GetInfo()
        {
            return "Воїн";
        }

        public int GetStrength()
        {
            return 45;
        }
    }
}
