using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exCheck = true;
            bool inCheck = true;
            do
            {
                ShoppingCart s1 = new ShoppingCart();
                Console.Write("Please enter your username: ");
                s1.Username = Console.ReadLine();
                Console.Write("Please enter your password: ");
                s1.Password = Console.ReadLine();
                do
                {
                    Console.WriteLine("What would you like to add: ");
                    s1.Cart.Add(Console.ReadLine());
                    Console.WriteLine("How much was it: $");
                    s1.CartTotal += double.Parse(Console.ReadLine());

                } while (inCheck);
                Console.WriteLine("Would you like to try again? (y/n): ");
                string input = Console.ReadLine().ToLower();
                if (input == "n")
                {
                    inCheck = false;
                }

            } while (inCheck);
        }
    }
    class ShoppingCart
    {
        private string username;
        private string password;
        private List<string> cart;
        private double cartTotal;

        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public List<string> Cart { get { return cart; } set { cart = value; } }      
        public double CartTotal()
        {
            return 0;
        }
    }
}
