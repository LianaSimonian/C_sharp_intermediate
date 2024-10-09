using System;


namespace Classes
{
    internal class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, i'm {1}", to, Name);

        }
        public static Person Parse(string s)
        {
            {
                var person = new Person();
                person.Name = s;
                return person;

            }
        }
    }
}
