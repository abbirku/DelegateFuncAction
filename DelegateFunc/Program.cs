using System;

namespace DelegateFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "Shams",
                LastName = "Wadud"
            };
            var personInfoText = "He works at SolutionArt.";

            //By using Func we can use the power of lamda expression. For this very reason we don't have to declare any formatter class.
            Console.WriteLine(person.ToString(person => $"Person last name is {person.LastName}"));
            Console.WriteLine(person.ToString(persong => $"Person first name is {person.FirstName}"));
            Console.WriteLine(person.ToString(person => $"Person full name is {person.FirstName} {person.LastName}"));
            Console.WriteLine(person.ToString((person, info) => $"Person full name is {person.FirstName} {person.LastName}. {info}", personInfoText));
        }
    }
}
