using System;

namespace People
{
    class Person
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public Person (string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}