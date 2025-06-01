using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Decorator
{
     public class Outfit : ImDecorator
    {
        public Outfit(Characters character) : base(character) { }

        public override string GetInfo()
        {
            return base.GetInfo() + " у броні";
        }

        public override int GetStrength()
        {
            return base.GetStrength() + 6;
        }
    }
}
