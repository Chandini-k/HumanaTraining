using ShoppingCart.Implementation;
using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Models
{
    public class UserOrder : IUserOrder
    {
        public int AddToCart(int itemId, int qty)
        {
            Console.WriteLine("Adding items to cart");
            ICart userCart = new ShoppingCartDetails();
            int cartID = 0;
            //GetItem
            Product product = userCart.GetItemDetails(itemId);
            //Check Availability
            if (userCart.CheckItemAvailability(product))
            {
                //Lock Item in the Stock
                userCart.LockItemInStock(itemId, qty);
                //Add Item to the cart
                cartID = userCart.AddItemToCart(itemId, qty);
            }
            Console.WriteLine("Add to cart");
            return cartID;
        }

        public int PlaceOrder(int cartID, int userID)
        {
            Console.WriteLine("Start PlaceOrderDetails");
            int orderID = -1;
            IWallet wallet = new Wallet();
            ITax tax = new Tax();
            ICart userCart = new ShoppingCartDetails();
            IAddress address = new AddressDetails();
            IOrder order = new Order();
            //Get Tax percentage by State
            double stateTax = tax.GetTaxByState("AndhraPradesh");
            //Apply Tax on the Cart Items
            tax.ApplyTax(cartID, stateTax);
            //Get user Wallet balance
            double userWalletBalance = wallet.GetUserBalance(userID);
            //Get the cart items price
            double cartPrice = userCart.GetCartPrice(cartID);
            //Compare the balance and price
            if (userWalletBalance > cartPrice)
            {
                //Get user Address and set to cart
                Address userAddress = address.GetAddressDetails(userID);
                //Place the order
                orderID = order.PlaceOrderDetails(cartID, userAddress.AddressID);

            }
            Console.WriteLine("Completed PlaceOrderDetails");
            return orderID;
        }
    }
}
