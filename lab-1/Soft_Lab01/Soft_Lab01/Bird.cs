using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Lab01
{
    internal class Bird
    {
        public class Bird1 : Animals
        {
            public double WingSpan { get; set; }

            public Bird1 (string name, string species, double wingSpan)
                : base(name, species)
            {
                WingSpan = wingSpan;
            }

            public override string GetInfo()
            {
                return base.GetInfo() + $", WingSpan: {WingSpan}m";
            }
        }

    }
}
