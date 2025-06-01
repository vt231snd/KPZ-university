using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Decorator
{
    public class Weapon : ImDecorator
    {
        public Weapon(Characters character) : base(character) { }

        public override string GetInfo()
        {
            return base.GetInfo() + " зі зброєю";
        }

        public override int GetStrength()
        {
            return base.GetStrength() + 10;
        }
    }
}
