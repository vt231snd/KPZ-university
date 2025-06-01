using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Abstract
{
    class Balaxy : Brands
    {
        public Devices CreateDevices() => new Netbook();
    }
}
