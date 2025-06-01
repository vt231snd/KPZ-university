using Lab_2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class EducationalSubscription : TotSubscription
    {
        public string Name => "Освітня підписка";
        public double MonthFee => 7.99;
        public int MinPeriod => 2;
        public List<string> Channels { get; } = new List<string> { "Руйнівники міфів", "Історія", "Світ навиворіт" };

        public string GetSubscriptionInfo()
        {
            return $"{Name}: ${MonthFee}/місяць, {MinPeriod} місяці мінімальний період, Канали: {string.Join(", ", Channels)}";
        }
    }
}
