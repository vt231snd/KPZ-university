    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace Lab3.LightHTML.Node
{
    public class LightTextNode : LightNode
    {
        public string Content { get; }

        public LightTextNode(string content)
        {
            Content = content;
        }

        public override string OuterHTML => Content;
        public override string InnerHTML => Content;
    }
}
