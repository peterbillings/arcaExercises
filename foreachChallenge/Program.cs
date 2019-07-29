using System;
using System.Collections.Generic;

namespace foreachChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel johnDoe = new PersonModel("John", "Doe");
            PersonModel janeDoe = new PersonModel("Jane", "Doe");
            PersonModel dillDough = new PersonModel("Dill", "Dough");

            //List<string> nameList = new List<string>{"Peter", "Alyx", "Hannah", "MrPossum"};

            List<PersonModel> personList = new List<PersonModel>();

            personList.Add(johnDoe);
            personList.Add(janeDoe);
            personList.Add(dillDough);

            foreach (PersonModel person in personList)
            {
                Console.WriteLine($"Hello, {person.FirstName} {person.LastName}");
            }

            



            //nameList.Add("MrSloth");

            // foreach (string name in nameList)
            // {
            //     Console.WriteLine(name);
            // }
        }
    }
}
