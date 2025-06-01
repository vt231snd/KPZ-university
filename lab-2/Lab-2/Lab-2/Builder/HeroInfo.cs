using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Builder
{
    public class HeroInfo
    {
        public string Height { get; set; }
        public string Name { get; set; }
        public string Stature { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothes { get; set; }
        public List<string> Inventory { get; set; } = new List<string>();
        public List<string> Acting { get; set; } = new List<string>();

        public void DisplayInfo()
        {
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Build: {Stature}");
            Console.WriteLine($"Hair Color: {HairColor}");
            Console.WriteLine($"Eye Color: {EyeColor}");
            Console.WriteLine($"Clothes: {Clothes}");
            Console.WriteLine("Inventory: " + string.Join(", ", Inventory));
            Console.WriteLine("Deeds: " + string.Join(", ", Acting));
        }
    }
}
