using System;

namespace ObjectInitializers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "Mosh",
                LastName = "Hamedani",
                Birthdate = new DateTime(2000, 9, 9)
            };
            Console.WriteLine("id : {0}, first name : {1},last name : {2}, birthdate : {3} ", person.Id, person.FirstName, person.LastName, person.Birthdate);
        }
    }
}
