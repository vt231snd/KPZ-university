using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Factory
{
    public class DomesticSubscription : TotSubscription
    {
        public string Name => "Домашня підписка";
        public double MonthFee => 9.99;
        public int MinPeriod => 1;
        public List<string> Channels { get; } = new List<string> { "Спорт", "Новини", "Шоу" };

        public string GetSubscriptionInfo()
        {
            return $"{Name}: ${MonthFee}/місяць, {MinPeriod} місяці мінімальний період, Канали: {string.Join(", ", Channels)}";
        }
    }
   
}
