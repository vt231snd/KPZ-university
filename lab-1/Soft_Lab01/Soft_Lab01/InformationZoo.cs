using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Lab01
{
    internal class InformationZoo
    {
        private List<Animals> animals = new List<Animals>();
        private List<Employee> employees = new List<Employee>();
        private List<Enclosure> enclosures = new List<Enclosure>();

        public void AddAnimal(Animals animal)
        {
            animals.Add(animal);
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void AddEnclosure(Enclosure enclosure)
        {
            enclosures.Add(enclosure);
        }

        public void ShowZooInfo()
        {
            Console.WriteLine("Zoo Inventory:");
            Console.WriteLine("Animals:");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetInfo());
            }
            Console.WriteLine("Enclosures:");
            foreach (var enclosure in enclosures)
            {
                Console.WriteLine(enclosure.GetInfo());
            }
            Console.WriteLine("Employees:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.GetInfo());
            }
            
        }
    }
}
