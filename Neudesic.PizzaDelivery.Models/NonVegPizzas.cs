using System;
using System.Collections.Generic;
using System.Text;

namespace Neudesic.PizzaDelivery.Models
{
    public class NonVegPizzas : Pizza
    {
        public int ChickenToppingsPrize = 50;
        public int ExtraChickenTopingsPrize = 100;
        public int TotalPrizeWithTopings { get; set; }
    }

    public class ChickenTikka : NonVegPizzas
    {
        public string PizzaName { get; set; } = "Chicken Tikka";
        public int PriceOfChickenTikka = 250;     
    }

    public class ChickenSausage : NonVegPizzas
    {
        public string PizzaName { get; set; } = "Chicken Sausage";
        public int PriceOfChickenSausage = 100;
    }
}
