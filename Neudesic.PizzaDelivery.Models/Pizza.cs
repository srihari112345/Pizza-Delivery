using System;

namespace Neudesic.PizzaDelivery.Models
{
    public class Pizza
    {
        public int SmallPrize { get; set; } = 50;
        public int MediumPrize { get; set; } = 100;
        public int LargePrize { get; set; } = 200;
        public int TotalPrizeOfPizza { get; set; }
    }
}
