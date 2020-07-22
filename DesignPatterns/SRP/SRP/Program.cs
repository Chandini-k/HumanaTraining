using System;

namespace SRP
{
    class Program
    {
        //Single Responsibility Priciple
        static void Main(string[] args)
        {
            StandardMessage.WelcomeMessage();

            Person user = PersonDataCapture.CaptureDetails();

            bool isUserValid = PersonValidator.Validate(user);

            if (isUserValid == false)
            {
                StandardMessage.EndApplication();
                return;
            }

            AccountGenerator.CreateAccount(user);

            StandardMessage.EndApplication();
        }
    }
}
