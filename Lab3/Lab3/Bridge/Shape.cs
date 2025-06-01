using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Bridge
{
    public abstract class Shape
    {
        protected Render rend;

    protected Shape(Render rend)
    {
        this.rend = rend;
    }

    public abstract void Draw();
}
}
