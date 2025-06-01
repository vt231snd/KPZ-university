using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Decorator
{
   public class ImDecorator : Characters
    {
        protected Characters character;

        public ImDecorator(Characters character)
        {
            this.character = character;
        }

        public virtual string GetInfo()
        {
            return character.GetInfo();
        }

        public virtual int GetStrength()
        {
            return character.GetStrength();
        }
    }
}
