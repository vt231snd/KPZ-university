﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.LightHTML.Node
{
    public abstract class LightNode
    {
        public abstract string OuterHTML { get; }
        public abstract string InnerHTML { get; }
    }
}
