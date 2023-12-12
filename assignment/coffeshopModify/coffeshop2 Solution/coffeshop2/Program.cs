using System;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace coffeshop2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] menu = { "Latte", "Cappuccino", "Americano" };
            double[] prices = { 3.65, 2.35, 4 };
            string[] sizes = { "Small", "Medium", "Large" };

            Console.WriteLine("Menu:");
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{menu[i]} -- {prices[i]}$");
            }

            Console.WriteLine("Please enter the desired drink from (1-3)");
            int value = Convert.ToInt32(Console.ReadLine());

            string drink;
            double price;
            string size;
            string milkValue;
            string sugarValue;

            drink = menu[value - 1];
           
            price = prices[value - 1];
            Console.WriteLine("Choose the size of the drink: \n 1.Small \n 2.Medium \n 3.Large \n \t Please choose the size from (1-3)");
            int userValue = Convert.ToInt32(Console.ReadLine());
           
            size = sizes[userValue - 1];
            Console.WriteLine("Do you want it with milk? (Yes/No):");
            string val = Console.ReadLine();
            milkValue = (val.ToLower() == "yes") ? "With Milk" : "Without Milk";
            Console.WriteLine("Do you want it with sugar? (Yes/No):");
            val = Console.ReadLine();
            sugarValue = (val.ToLower() == "yes") ? "With Sugar" : "Without Sugar";
            Console.WriteLine("******************************************");
            Console.WriteLine("\t\t\t\t\t Checkout ");
            Console.WriteLine($"Your drink is: {drink} \n with size: {size}, {sugarValue}, {milkValue} \n Total price is: {price}$");
            Console.WriteLine("******************************************");

            double cost = price;
            if (size == "Medium")
            {
                cost += 0.5;
            }
            else if (size == "Large")
            {
                cost += 1;
            }

            Console.WriteLine($"The total cost of your order is: {cost}$");


            string [] orderDetails = { drink, size, price };
            return orderDetails;


            static void DisplayOrderSummary(string[] orderDetails, double totalCost)
            {
                Console.WriteLine("******************************************");
                Console.WriteLine("\t\t\t\t\t Order Summary ");
                Console.WriteLine($"Your drink is: {orderDetails[0]} \n with size: {orderDetails[1]}, {orderDetails[2]}, {orderDetails[3]} \n Total price is: {totalCost}$");
                Console.WriteLine("******************************************");


            }
    }
}