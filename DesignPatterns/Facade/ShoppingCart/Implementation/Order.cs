using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Implementation
{
    public class Order : IOrder
    {
        public int PlaceOrderDetails(int cartID, int shippingAddressID)
        {
            Console.WriteLine("PlaceOrderDetails");
            return 10;
        }
    }
}
