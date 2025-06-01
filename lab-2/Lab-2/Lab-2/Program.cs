using Lab_2.Abstract;
using Lab_2.Alone;
using Lab_2.Builder;
using Lab_2.Factory;
using Lab_2.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1");
            Console.OutputEncoding = Encoding.UTF8;  

            TotSubscription domestic = new DomesticSubscription();
            TotSubscription educational = new EducationalSubscription();
            TotSubscription premium = new PremiumSubscription();

            Console.WriteLine(domestic.GetSubscriptionInfo());
            Console.WriteLine(educational.GetSubscriptionInfo());
            Console.WriteLine(premium.GetSubscriptionInfo());
            Console.WriteLine();

            Console.WriteLine("2");
            Brands iproneBrand = new IProne();
            Brands kiaomiBrand = new Kiaomi();
            Brands balaxyBrand = new Balaxy();

            
            Devices iproneDevice = iproneBrand.CreateDevices();
            Devices kiaomiDevice = kiaomiBrand.CreateDevices();
            Devices balaxyDevice = balaxyBrand.CreateDevices();

            
            Console.WriteLine($"IProne Device: {iproneDevice.GetName()}");
            Console.WriteLine($"Kiaomi Device: {kiaomiDevice.GetName()}");
            Console.WriteLine($"Balaxy Device: {balaxyDevice.GetName()}");
            Console.WriteLine();

            Console.WriteLine("3");
            Authenticator authenticator = Authenticator.GetInstance();
            authenticator.Authenticate();
            Console.WriteLine();

            Console.WriteLine("4");
            var parentVirus = new Virus(1.5, 25, "ParentVirus", "A");
            var childVirus1 = new Virus(0.5, 6, "ChildVirus1", "B");
            var childVirus2 = new Virus(0.7, 4, "ChildVirus2", "C");

            parentVirus.Children.Add(childVirus1);
            parentVirus.Children.Add(childVirus2);

            var clonedVirus = (Virus)parentVirus.Clone();
            clonedVirus.Info();
            Console.WriteLine();

            Console.WriteLine("5");
            var director = new CharacterInfoBuilder();
           
            var heroBuilder = new HeroBuilder();
            var heroine = director.CreateHeroine(heroBuilder);
            Console.WriteLine("Heroine:");
            heroine.DisplayInfo();

            Console.WriteLine();

            
            var enemyBuilder = new EnemyBuilder();
            var enemy = director.CreateEnemy(enemyBuilder);
            Console.WriteLine("Enemy:");
            enemy.DisplayInfo();
        }
    }
}
