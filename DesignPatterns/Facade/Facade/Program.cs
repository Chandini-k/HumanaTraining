using ShoppingCart.Interfaces;
using ShoppingCart.Models;
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserOrder userOrder = new UserOrder();
            Console.WriteLine("Shopping Products");
            Console.WriteLine(new string('-',40));
            int cartID = userOrder.AddToCart(10, 1);
            int userID = 1234;
            Console.WriteLine(new string('-', 40));
            int orderID = userOrder.PlaceOrder(cartID, userID);
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Order Placed:CartID = {0}, OrderID = {1}",cartID, orderID);
            Console.ReadLine();
        }
    }
}
