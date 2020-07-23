using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Interfaces
{
    public interface IUserOrder
    {
        int AddToCart(int itemId, int qty);
        int PlaceOrder(int cartID, int userID);
    }
}
