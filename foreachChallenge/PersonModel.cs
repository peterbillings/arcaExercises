using System;

namespace foreachChallenge
{
    class PersonModel
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public PersonModel(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}