using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var formatter = new Formatter();
            var person = new Person
            { 
                FirstName = "Shams",
                LastName = "Wadud"
            };

            Console.WriteLine(person.ToString(formatter.FormatFirstName));
            Console.WriteLine(person.ToString(formatter.FormatLastName));
            Console.WriteLine(person.ToString(formatter.FormatFullName));
        }
    }
}
