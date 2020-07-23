using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Implementation
{
    public class Tax : ITax
    {
        public void ApplyTax(int cartID, double taxPercent)
        {
            Console.WriteLine("ApplyTax");
        }
        public double GetTaxByState(string state)
        {
            Console.WriteLine("GetTaxByState");
            return 10;
        }
    }

}
