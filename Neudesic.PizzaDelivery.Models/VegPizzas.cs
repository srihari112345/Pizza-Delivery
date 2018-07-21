using System;
using System.Collections.Generic;
using System.Text;

namespace Neudesic.PizzaDelivery.Models
{
    public class VegPizzas: Pizza
    {
        public int CheesyPrize { get; set; } = 25;
        public int ExtraCheesyPrize { get; set; } = 50;
        
    }

    public class MexicanGreenWave: VegPizzas
    {
        public string PizzaName { get; set; } = "Mexican Green Wave";
        public int PriceOfMexicanGreenWave { get; set; } = 250;
        
    }

    public class CheeseBurst: VegPizzas
    {
        public string PizzaName { get; set; } = "Cheese Burst";
        public int PriceOfCheeseBurst { get; set; } = 120;
    }
    
}
