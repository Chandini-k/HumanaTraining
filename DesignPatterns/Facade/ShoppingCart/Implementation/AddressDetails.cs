using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Implementation
{
    public class AddressDetails : IAddress
    {
        public Models.Address GetAddressDetails(int userID)
        {
            Console.WriteLine("Enter AddressDetails");
            Console.WriteLine("Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Phone no: ");
            string phno = Console.ReadLine();
            Console.WriteLine("Country: ");
            string country = Console.ReadLine();
            return new Models.Address();
        }

    }
}
