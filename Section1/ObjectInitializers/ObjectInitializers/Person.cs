using System;

namespace ObjectInitializers
{
    public class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public DateTime Birthdate;

        public Person()
        {
            
        }
        public Person(int id)
        {
            Id = id;   
        }
        public Person(int id, string firstName)
        {
            Id=id;
            FirstName = firstName;
        }
        public Person(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        public Person(int id, DateTime birthdate)
        {
            Id = id;
            Birthdate = birthdate;
        }
    }
}
