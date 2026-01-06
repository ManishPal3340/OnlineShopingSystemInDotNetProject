using OnlineShopingSystem.Services;
//using OnlineShopingSystem.service;
using System;

namespace ShopingSystem
{
    class Program
    {
        static void Main()
        {
            ShoppingService shop = new ShoppingService();
            int choice;

            do
            {
                Console.WriteLine("\n==== ONLINE SHOPPING SYSTEM ====");
                Console.WriteLine("1. View Products");
                Console.WriteLine("2. Add to Cart");
                Console.WriteLine("3. Remove from Cart");
                Console.WriteLine("4. View Cart");
                Console.WriteLine("5. Place Order");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                    choice = -1;
                }

                switch (choice)
                {
                    case 1: shop.ShowProducts(); break;
                    case 2: shop.AddToCart(); break;
                    case 3: shop.RemoveFromCart(); break;
                    case 4: shop.ViewCart(); break;
                    case 5: shop.PlaceOrder(); break;
                    case 0: Console.WriteLine("Thank you for shopping!"); break;
                    default: Console.WriteLine("Invalid choice"); break;
                }

            } while (choice != 0);
        }
    }
}
