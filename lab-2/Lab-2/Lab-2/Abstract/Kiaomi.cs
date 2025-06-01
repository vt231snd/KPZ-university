using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Abstract
{
    class Kiaomi : Brands
    {
        //public Devices CreateDevices() => new Laptop();
        public Devices CreateDevices() => new EBook();
    }
}
