using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InformationZoo zoo = new InformationZoo();

            
            Animals rajah = new Animals("Sally", "Rajah");
            Animals melman = new Animals("Dumbo", "Melman");
            Bird.Bird1 thor = new Bird.Bird1("Tommy", "Thor", 0.8);

            zoo.AddAnimal(rajah);
            zoo.AddAnimal(melman);
            zoo.AddAnimal(thor);

           
            Enclosure largeEnclosure = new Enclosure("Savanna Enclosure", 140);
            Enclosure smallEnclosure = new Enclosure("Forest Enclosure", 40);

            zoo.AddEnclosure(largeEnclosure);
            zoo.AddEnclosure(smallEnclosure);

            
            Employee keeper = new Employee("Eren Eger", "Zookeeper");
            Employee veterinarian = new Employee("Levi Acerman", "Veterinarian");

            zoo.AddEmployee(keeper);
            zoo.AddEmployee(veterinarian);

            
            zoo.ShowZooInfo();
        }
    }
}
