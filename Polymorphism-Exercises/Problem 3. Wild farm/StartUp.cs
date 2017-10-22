using System;

namespace Problem_3.Wild_farm
{
    class StartUp
    {
        static void Main()
        {
            var animalFactory = new AnimalFactory();
            var foodFactory = new FoodFActory();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var animalInfo = input.Split(new[] { '\t', ' ', '\n'}, StringSplitOptions.RemoveEmptyEntries);
                var animal = animalFactory.GetAnimal(animalInfo);

                var foodInfo = Console.ReadLine().Split(new[] { '\t', ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                var food = foodFactory.GetFood(foodInfo);

                Console.WriteLine(animal.MakeSound());

                try
                {
                    animal.Eat(food);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine(animal);
            }                            
        }
    }
}
