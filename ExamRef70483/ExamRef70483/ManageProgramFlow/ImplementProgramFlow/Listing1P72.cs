using System.Collections.Generic;

namespace ExamRef70483.ManageProgramFlow.ImplementProgramFlow
{
    public class Listing1P72
    {
        public static void CannotChangeForeachIterationVariable()
        {
            var people = new List<Person>()
            {
                new Person() {FirstName = "Jhon", LastName = "Doe"},
                new Person() {FirstName = "Jane", LastName = "Doe"}
            };

            foreach (var person in people)
            {
                person.LastName = "Changed";
                //person = new Person(); This is Not Allowed
            }
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}