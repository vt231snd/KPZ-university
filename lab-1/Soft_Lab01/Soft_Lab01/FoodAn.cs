using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Soft_Lab01
    {
        internal class FoodAn
        {
            public string Name { get; set; }
            public string Type { get; set; }

            public FoodAn(string name, string type)
            {
                Name = name;
                Type = type;
            }

            public string GetInfo()
            {
                return $"Food: {Name}, Type: {Type}";
            }
        }
    }
