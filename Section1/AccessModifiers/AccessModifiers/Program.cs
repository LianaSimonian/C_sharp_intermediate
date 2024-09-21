using System;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(DateTime.Now);
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
