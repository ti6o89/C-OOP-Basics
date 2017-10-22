using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4.Opinion_Poll
{
    class StartUp
    {
        static void Main()
        {
            var numbersOfPeople = int.Parse(Console.ReadLine());
            var people = new List<Person>();
            for (int i = 0; i < numbersOfPeople; i++)
            {
                var personInfo = Console.ReadLine().Split();

                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);

                Person person = new Person(name, age);
                people.Add(person);
            }
            var orderedResult = people
                .Where(a => a.Age > 30)
                .OrderBy(n => n.Name);

            foreach (var person in orderedResult)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
