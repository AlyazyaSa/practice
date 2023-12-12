using System.Net.Security;

namespace CoffeAssignment
{
    class Program
    {
        static void Main()

        {
            string[] menu = { "Lattte", "Cappcino", "amreicano" };
            double[] Prices = { 3.65, 2.35, 4 };
            string[] Sizes = { "Small", "Medium", "Large" };

            //double [] Prices = new int[3]{ 3.65, 2.35, 4};
            Console.WriteLine("Menu :");
            Console.WriteLine($"1.{menu[0]} -- {Prices[0]}$");
            Console.WriteLine($"2.{menu[1]} -- {Prices[1]}$");
            Console.WriteLine($"3.{menu[2]} -- {Prices[2]}$");
            Console.WriteLine("Please enter the desired Drink from (1-3)");
            int value = Convert.ToInt32(Console.ReadLine());

            string Drink;
            double price;
            string size;
            string MilkValue;
            string SugarValue;

            Drink = menu[value - 1];
            price = Prices[value - 1];
            Console.WriteLine("Choose the Size of the drink : \n 1.Small \n 2.Medium \n 3.Large \n \t Please choose the Size from (1-3) ");
            int userValue = Convert.ToInt32(Console.ReadLine());
            size = Sizes[userValue - 1];
            Console.WriteLine("Do You it with Milk :(Yes -NO) :");
            string val = Console.ReadLine();
            MilkValue = (val.ToLower() == "yes") ? "With Milk " : "Without Milk ";
            Console.WriteLine("Do You it with Sugar :(Yes -NO) :");
            val = Console.ReadLine();
            SugarValue = (val.ToLower() == "yes") ? "With Sugar" : "Without Sugar ";
            Console.WriteLine("******************************************");
            Console.WriteLine("\t\t\t\t\t Checkout ");
            Console.WriteLine($"your Drink is : {Drink} \n with Size : {size} , {SugarValue} , {MilkValue} \n Total Price is : {price}");

            Console.WriteLine("******************************************");
            
        }              
    }
}
