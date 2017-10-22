using System;

namespace Mordor_s_Cruelty_Plan
{
    class StartUp
    {
        static void Main()
        {
            var inputFood = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var foodFactory = new FoodFactory();
            var moodFactory = new MoodFactory();
            var gandalf = new Gandalf();

            foreach (var food in inputFood)
            {
                var foodToEat = foodFactory.GetFood(food);
                gandalf.Eat(foodToEat);
            }
            var totalHappinessPoints = gandalf.GetHappinessPoints();
            var mood = moodFactory.GetMood(totalHappinessPoints);

            Console.WriteLine(totalHappinessPoints);
            Console.WriteLine(mood);
        }
    }
}
