using OnlineShopingSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopingSystem.Services
{
    class ShoppingService
    {
        private List<Product> products = new List<Product>();
        private List<Product> cart = new List<Product>();

        public ShoppingService()
        {
            products.Add(new Product(1, "Mobile", 15000));
            products.Add(new Product(2, "Laptop", 55000));
            products.Add(new Product(3, "Headphones", 2500));
            products.Add(new Product(4, "Keyboard", 1200));
        }

        public void ShowProducts()
        {
            Console.WriteLine("\n--- Available Products ---");
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Id}. {p.Name} - ₹{p.Price}");
            }
        }

        public void AddToCart()
        {
            try
            {
                Console.Write("Enter Product ID: ");
                int id = int.Parse(Console.ReadLine());

                Product product = products.Find(p => p.Id == id);

                if (product == null)
                    throw new Exception("Product not found");

                cart.Add(product);
                Console.WriteLine("Product added to cart");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Enter numbers only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RemoveFromCart()
        {
            try
            {
                Console.Write("Enter Product ID to remove: ");
                int id = int.Parse(Console.ReadLine());

                Product product = cart.Find(p => p.Id == id);

                if (product == null)
                    throw new Exception("Product not found in cart");

                cart.Remove(product);
                Console.WriteLine("Product removed from cart");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ViewCart()
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is empty");
                return;
            }

            int total = 0;
            Console.WriteLine("\n--- Cart Items ---");
            foreach (var p in cart)
            {
                Console.WriteLine($"{p.Name} - ₹{p.Price}");
                total += p.Price;
            }

            Console.WriteLine("Total Amount: ₹" + total);
        }

        public void PlaceOrder()
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is empty. Cannot place order.");
                return;
            }

            cart.Clear();
            Console.WriteLine("Order placed successfully!");
        }
    }
}