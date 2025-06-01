using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Bridge
{
    public class Vector: Render
    {
        public void Rend(string shape)
        {
            Console.WriteLine($"Drawing {shape} as vector graphics.");
        }
    }

  
}
