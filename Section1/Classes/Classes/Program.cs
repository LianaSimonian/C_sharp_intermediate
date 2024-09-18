
using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Jhon";
            person.Introduce("Mash");
            var person1 = Person.Parse("Alen");
            person1.Introduce("Mash");

        }
    }
}