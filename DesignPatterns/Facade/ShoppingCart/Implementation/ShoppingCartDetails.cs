using ShoppingCart.Interfaces;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Implementation
{
    public class ShoppingCartDetails : ICart
    {
        public ShoppingCartDetails()
        {
        }
        public int AddItemToCart(int itemID, int Quantity)
        {
            Console.WriteLine("AddItemToCart");
            return 15;
        }
        public bool CheckItemAvailability(Product product)
        {
            Console.WriteLine("CheckItemAvailability");
            return true;
        }

        public double GetCartPrice(int cartID)
        {
            Console.WriteLine("GetCartPrice");
            return 15;
        }
        public Product GetItemDetails(int itemID)
        {
            Console.WriteLine("GetItemDetails");
            return new Product();
        }
        public bool LockItemInStock(int itemID, int quantity)
        {
            Console.WriteLine("LockItemInStock");
            return true;
        }
    }
}
