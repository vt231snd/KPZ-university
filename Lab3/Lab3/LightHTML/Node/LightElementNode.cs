using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab3.LightHTML.Node
{
    public enum ViewType
    {
        Block,
        Inline
    }

    public enum CloseType
    {
        Normal,
        SelfClosing
    }

    public class LightElementNode : LightNode
    {
        public string Tag { get; }
        public ViewType Display { get; }
        public CloseType Closing { get; }

        public List<string> CssClasses { get; }
        public List<LightNode> Children { get; }

        public LightElementNode(string tag, ViewType display, CloseType closing)
        {
            Tag = tag;
            Display = display;
            Closing = closing;
            CssClasses = new List<string>();
            Children = new List<LightNode>();
        }

        public void AddClass(string className) => CssClasses.Add(className);
        public void RemoveClass(string className) => CssClasses.Remove(className);
        public void AddChild(LightNode child) => Children.Add(child);

        public int ChildrenCount => Children.Count;

        public override string InnerHTML => string.Join("", Children.Select(child => child.OuterHTML));

        public override string OuterHTML
        {
            get
            {
                var classAttr = CssClasses.Any() ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";

                if (Closing == CloseType.SelfClosing)
                    return $"<{Tag}{classAttr} />";

                return $"<{Tag}{classAttr}>{InnerHTML}</{Tag}>";
            }
        }

        public override string ToString() => OuterHTML;
    }
}
