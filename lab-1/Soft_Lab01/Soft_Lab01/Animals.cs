using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Soft_Lab01
{
    internal class Animals
    {
        public string Name {  get; set; }
        public string Sort { get; set; }

        public Animals(string name, string sort) {

            Name = name;
            Sort = sort;
        }

        public virtual string GetInfo()
        {
            return $"Animal: {Name}, Species: {Sort}";
        }
    }
}
