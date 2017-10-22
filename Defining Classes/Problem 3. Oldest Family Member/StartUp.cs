using System;

namespace Problem_3.Oldest_Family_Member
{
    public class StartUp
    {
        static void Main()
        {
            var numbersOfMembers = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < numbersOfMembers; i++)
            {
                var memberInfo = Console.ReadLine().Split();
                var personName = memberInfo[0];
                var personAge = int.Parse(memberInfo[1]);
                Person person = new Person(personName, personAge);
                family.AddMember(person);
            }
            var oldestPerson = family.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
