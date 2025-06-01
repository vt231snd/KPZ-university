using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Bridge
{
    public class Square : Shape
    {
        public Square(Render rend) : base(rend) { }

        public override void Draw()
        {
            rend.Rend("Square");
        }
    }
}
