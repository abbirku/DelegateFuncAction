using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    public class Formatter
    {
        public string FormatLastName(Person person)
        {
            return $"Person last name is {person.LastName}";
        }

        public string FormatFirstName(Person person)
        {
            return $"Person first name is {person.FirstName}";
        }

        public string FormatFullName(Person person)
        {
            return $"Person full name is {person.FirstName} {person.LastName}";
        }
    }
}
