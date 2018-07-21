using Neudesic.PizzaDelivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neudesic.PizzaDelivery
{
    public class Menu
    {
        private MexicanGreenWave mexicanGreenWaveObject = new MexicanGreenWave();
        private CheeseBurst cheeseBurstObject = new CheeseBurst();
        private ChickenSausage chickenSausageObject = new ChickenSausage();
        private ChickenTikka chickenTikkaObject = new ChickenTikka();
        public List<string> ordersList = new List<string>();
        public delegate int OrderGiven();
        public event OrderGiven Order;
        private int TotalPrizeOfPurchases { get; set; } = 0;
        static void Main(string[] args)
        {
            Menu menuObject = new Menu();
            string selectedOption = "";
            bool continueInPizzaMenu = true;
            bool continueInMainMenu = true;
                while (continueInMainMenu)
                {
                        Console.WriteLine("Menu");
                        Console.WriteLine("1) Pizza");
                        Console.WriteLine("2) Beverages");
                        Console.Write("Enter the option : ");
                        selectedOption = Console.ReadLine();
                        while (continueInPizzaMenu)
                        {
                            switch (selectedOption)
                            {
                                case "1":
                                    Console.WriteLine("1) Veg Pizza");
                                    Console.WriteLine("2) Non-Veg Pizza");
                                    Console.WriteLine("Enter the type of Pizza to choose:");
                                    selectedOption = Console.ReadLine();
                                    switch (selectedOption)
                                    {
                                        case "1":
                                            menuObject.VegMenuDisplay();
                                            Console.WriteLine("Do you want to buy another Pizza(y/n)?");
                                            string continueInPizzaMenuInput = Console.ReadLine();
                                            if (continueInPizzaMenuInput == "n")
                                            {
                                                continueInPizzaMenu = false;
                                            }
                                            break;

                                        case "2":
                                            menuObject.NonVegMenuDisplay();
                                            Console.WriteLine("Do you want to buy another Pizza (y/n)?");
                                            continueInPizzaMenuInput = Console.ReadLine();
                                            if (continueInPizzaMenuInput == "n")
                                            {
                                                continueInPizzaMenu = false;
                                            }
                                            break;
                                    }
                                    break;

                                case "2":
                                    break;
                            }
                        
                        }

                        Console.Write
                }



            

        }

        public void VegMenuDisplay()
        {
            string selectedOption = "";
            Console.WriteLine("1) Mexican Green Wave | Rs " + mexicanGreenWaveObject.PriceOfMexicanGreenWave);
            Console.WriteLine("2) Cheese Burst | Rs " + cheeseBurstObject.PriceOfCheeseBurst);
            Console.Write("Enter the option: ");
            selectedOption = Console.ReadLine();
            if (selectedOption == "1")
            {
                TotalPrizeOfPurchases += OrderMexicanGreenWavePizza();
            }
            else
            {
                TotalPrizeOfPurchases += OrderCheeseBurstPizza();
            }
        }

        public void NonVegMenuDisplay()
        {
            string selectedOption = "";
            Console.WriteLine("1) Chicken Tikka - Rs " + chickenTikkaObject.PriceOfChickenTikka);
            Console.WriteLine("2) Chicken Sausage - Rs " +  chickenSausageObject.PriceOfChickenSausage);
            selectedOption= Console.ReadLine();
            if (selectedOption == "1")
            {
                TotalPrizeOfPurchases += OrderChickenTikkaPizza() ;
            }
            else
            {
                TotalPrizeOfPurchases += OrderChickenSausagePizza();
            }
        }

        public int OrderMexicanGreenWavePizza()
        {
            MexicanGreenWave mexicanGreenWave = new MexicanGreenWave();
            mexicanGreenWave.TotalPrizeOfPizza = mexicanGreenWave.PriceOfMexicanGreenWave;
            string selectedOption = "";
            Console.WriteLine("Select Size of Piza : ");
            Console.WriteLine("1) Small - Rs " + mexicanGreenWave.SmallPrize + "\n 2) Medium - Rs " + mexicanGreenWave.MediumPrize + "\n 3) Large - Rs " + mexicanGreenWave.LargePrize);
            Console.Write("Enter the Option");
            selectedOption = Console.ReadLine();
            if (selectedOption == "1")
            {
                mexicanGreenWave.TotalPrizeOfPizza += mexicanGreenWave.SmallPrize;
            }
            else if (selectedOption == "2")
            {
                mexicanGreenWave.TotalPrizeOfPizza += mexicanGreenWave.MediumPrize;
            }
            else
            {
                mexicanGreenWave.TotalPrizeOfPizza += mexicanGreenWave.LargePrize;
            }
            Console.WriteLine("Select Cheese :");
            Console.WriteLine("1) Cheesy- " + mexicanGreenWave.CheesyPrize + " 2) Extra Cheesy-" + mexicanGreenWave.ExtraCheesyPrize);
            selectedOption = Console.ReadLine();
            if (selectedOption == "1")
            {
                mexicanGreenWave.TotalPrizeOfPizza += mexicanGreenWave.CheesyPrize;
            }
            else
            {
                mexicanGreenWave.TotalPrizeOfPizza += mexicanGreenWave.ExtraCheesyPrize;
            }

            ordersList.Add(mexicanGreenWave.PizzaName);
            return mexicanGreenWave.TotalPrizeOfPizza;
        }

        public int OrderCheeseBurstPizza()
        {
            CheeseBurst cheeseBurst = new CheeseBurst();
            cheeseBurst.TotalPrizeOfPizza = cheeseBurst.PriceOfCheeseBurst;
            string selectedOption = "";
            Console.WriteLine("Select Size of Piza : ");
            Console.WriteLine("1) Small - Rs " + cheeseBurst.SmallPrize + "\n 2) Medium - Rs " + cheeseBurst.MediumPrize + "\n 3) Large - Rs " + cheeseBurst.LargePrize);
            Console.Write("Enter the Option");
            selectedOption = Console.ReadLine();
            if (selectedOption == "1")
            {
                cheeseBurst.TotalPrizeOfPizza += cheeseBurst.SmallPrize;
            }
            else if (selectedOption == "2")
            {
                cheeseBurst.TotalPrizeOfPizza += cheeseBurst.MediumPrize;
            }
            else
            {
                cheeseBurst.TotalPrizeOfPizza += cheeseBurst.LargePrize;
            }
            Console.WriteLine("Select Cheese :");
            Console.WriteLine("1) Cheesy- " + cheeseBurst.CheesyPrize + " 2) Extra Cheesy-" + cheeseBurst.ExtraCheesyPrize);
            selectedOption = Console.ReadLine();
            if (selectedOption == "1")
            {
                cheeseBurst.TotalPrizeOfPizza += cheeseBurst.CheesyPrize;
            }
            else
            {
                cheeseBurst.TotalPrizeOfPizza += cheeseBurst.ExtraCheesyPrize;
            }

            ordersList.Add(cheeseBurst.PizzaName);
            return cheeseBurst.TotalPrizeOfPizza;
        }

        public int OrderChickenTikkaPizza()
        {
            ChickenTikka chickenTikka = new ChickenTikka();
            chickenTikka.TotalPrizeOfPizza = chickenTikka.PriceOfChickenTikka;
            string selectedOption = "";
            Console.WriteLine("Select Size of Piza : ");
            Console.WriteLine("1) Small - Rs " + chickenTikka.SmallPrize + "\n 2) Medium - Rs " + chickenTikka.MediumPrize + "\n 3) Large - Rs " + chickenTikka.LargePrize);
            Console.Write("Enter the Option");
            selectedOption = Console.ReadLine();
            if (selectedOption == "1")
            {
                chickenTikka.TotalPrizeOfPizza += chickenTikka.SmallPrize;
            }
            else if (selectedOption == "2")
            {
                chickenTikka.TotalPrizeOfPizza += chickenTikka.MediumPrize;
            }
            else
            {
                chickenTikka.TotalPrizeOfPizza += chickenTikka.LargePrize;
            }
            Console.WriteLine("Select Cheese :");
            Console.WriteLine("1) Chicken Toppings- " + chickenTikka.ChickenToppingsPrize + " 2) Extra Chicken Toppings-" + chickenTikka.ExtraChickenTopingsPrize);
            selectedOption = Console.ReadLine();
            if (selectedOption == "1")
            {
                chickenTikka.TotalPrizeOfPizza += chickenTikka.ChickenToppingsPrize;
            }
            else
            {
                chickenTikka.TotalPrizeOfPizza += chickenTikka.ExtraChickenTopingsPrize;
            }

            ordersList.Add(chickenTikka.PizzaName);
            return chickenTikka.TotalPrizeOfPizza;
        }

        public int OrderChickenSausagePizza()
        {
            ChickenSausage chickenSausage = new ChickenSausage();
            chickenSausage.TotalPrizeOfPizza = chickenSausage.PriceOfChickenSausage;
            string selectedOption = "";
            Console.WriteLine("Select Size of Piza : ");
            Console.WriteLine("1) Small - Rs " + chickenSausage.SmallPrize + "\n 2) Medium - Rs " + chickenSausage.MediumPrize + "\n 3) Large - Rs " + chickenSausage.LargePrize);
            Console.Write("Enter the Option");
            selectedOption = Console.ReadLine();
            if (selectedOption == "1")
            {
                chickenSausage.TotalPrizeOfPizza += chickenSausage.SmallPrize;
            }
            else if (selectedOption == "2")
            {
                chickenSausage.TotalPrizeOfPizza += chickenSausage.MediumPrize;
            }
            else
            {
                chickenSausage.TotalPrizeOfPizza += chickenSausage.LargePrize;
            }
            Console.WriteLine("Select Cheese :");
            Console.WriteLine("1) Chicken Toppings- " + chickenSausage.ChickenToppingsPrize + " 2) Extra Chicken Toppings-" + chickenSausage.ExtraChickenTopingsPrize);
            selectedOption = Console.ReadLine();
            if (selectedOption == "1")
            {
                chickenSausage.TotalPrizeOfPizza += chickenSausage.ChickenToppingsPrize;
            }
            else
            {
                chickenSausage.TotalPrizeOfPizza += chickenSausage.ExtraChickenTopingsPrize;
            }

            ordersList.Add(chickenSausage.PizzaName);
            return chickenSausage.TotalPrizeOfPizza;
        }

        public void GenerateBill(int totalPrize, List<string> ordersList)
        {
            Console.WriteLine("------------------------------------");
            for (int index = 0; index < ordersList.Count; index++)
            {
                Console.WriteLine(ordersList[index]);
            }
            Console.WriteLine(totalPrize);
            Console.WriteLine("------------------------------------");
            Console.ReadLine();
        }
    }
}
