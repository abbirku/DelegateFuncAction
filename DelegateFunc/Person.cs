﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateFunc
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return "Default person string";
        }

        /// <summary>
        /// The following method makes person class follow 'Open Close Principle'.
        /// Because for other ToString formatter, we don't have to create any new method inside this class.
        /// </summary>
        public string ToString(Func<Person, string> formatter)
        {
            if (formatter == null)
                return ToString();

            return formatter(this);
        }

        public string ToString(Func<Person, string, string> formatter, string info)
        {
            if (formatter == null)
                return ToString();

            return formatter(this, info);
        }
    }
}
