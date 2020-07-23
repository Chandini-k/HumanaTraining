using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Implementation
{
    public class Wallet : IWallet
    {
        public double GetUserBalance(int userID)
        {
            Console.WriteLine("GetUserBalance");
            return 100;
        }
    }
}
