using System;
using System.Collections.Generic;

namespace Animals
{
    class StartUp
    {
        static void Main()
        {
            var factory = new AnimalFactory();
            var animals = new List<Animal>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Beast!")
            {
                var animalInfo = Console.ReadLine().Split();

                var name = animalInfo[0];
                var age = int.Parse(animalInfo[1]);
                var gender = animalInfo[2];

                try
                {
                    var animal = factory.GetAnimal(inputLine, name, age, gender);
                    animals.Add(animal);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }                
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(string.Join(Environment.NewLine, animal));
            }
        }
    }
}
