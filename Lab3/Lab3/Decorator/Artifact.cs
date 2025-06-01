using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Decorator
{
    public class Artifact : ImDecorator
    {
        public Artifact(Characters character) : base(character) { }

        public override string GetInfo()
        {
            return base.GetInfo() + " з артефактом";
        }

        public override int GetStrength()
        {
            return base.GetStrength() + 11;
        }
    }
}
