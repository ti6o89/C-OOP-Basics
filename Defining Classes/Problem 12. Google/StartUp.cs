using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_12.Google
{
    class StartUp
    {
        static void Main()
        {
            var people = new List<Person>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split();

                var personName = tokens[0];

                if (!people.Any(p => p.Name == personName))
                {
                    var person = new Person(personName);
                    people.Add(person);
                }

                if (tokens[1] == "company")
                {
                    var name = tokens[2];
                    var department = tokens[3];
                    var salary = decimal.Parse(tokens[4]);
                    var company = new Company(name, department, salary);

                    people.Where(p => p.Name == personName).First().Company = company;
                }
                else if (tokens[1] == "pokemon")
                {
                    var name = tokens[2];
                    var type = tokens[3];
                    var pokemon = new Pokemon(name, type);

                    people.Where(p => p.Name == personName).First().Pokemons.Add(pokemon);
                }
                else if (tokens[1] == "parents")
                {
                    var name = tokens[2];
                    var birthday = tokens[3];
                    var parent = new Parent(name, birthday);

                    people.Where(p => p.Name == personName).First().Parents.Add(parent);
                }
                else if (tokens[1] == "children")
                {
                    var name = tokens[2];
                    var birthday = tokens[3];
                    var children = new Childern(name, birthday);

                    people.Where(p => p.Name == personName).First().Children.Add(children);
                }
                else if (tokens[1] == "car")
                {
                    var model = tokens[2];
                    var speed = int.Parse(tokens[3]);
                    var car = new Car(model, speed);

                    people.Where(p => p.Name == personName).First().Car = car;
                }
            }

            var personInfo = Console.ReadLine();
            var currentPerson = people.Where(p => p.Name == personInfo).FirstOrDefault();

            Console.WriteLine(personInfo);
            Console.WriteLine("Company:");
            if (currentPerson.Company != null)
            {
                Console.WriteLine($"{currentPerson.Company.Name} {currentPerson.Company.Department} {currentPerson.Company.Salary:f2}");
            }

            Console.WriteLine("Car:");
            if (currentPerson.Car != null)
            {
                Console.WriteLine($"{currentPerson.Car.Model} {currentPerson.Car.Speed}");
            }

            Console.WriteLine("Pokemon:");
            if (currentPerson.Pokemons.Count > 0)
            {
                foreach (var pok in currentPerson.Pokemons)
                {
                    Console.WriteLine($"{pok.PokemonName} {pok.PokemonType}");
                }
            }

            Console.WriteLine("Parents:");
            if (currentPerson.Parents.Count > 0)
            {
                foreach (var par in currentPerson.Parents)
                {
                    Console.WriteLine($"{par.Name} {par.Birthday}");
                }
            }

            Console.WriteLine("Children:");
            if (currentPerson.Children.Count > 0)
            {
                foreach (var child in currentPerson.Children)
                {
                    Console.WriteLine($"{child.Name} {child.Birthday}");
                }
            }
        }
    }
}
