using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class PersonValidator
    {

        public static bool Validate(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessage.DisplayValidationError("first name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessage.DisplayValidationError("last name");
                return false;
            }

            return true;
        }
    }
}
