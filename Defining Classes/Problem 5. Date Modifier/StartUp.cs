using System;

namespace Problem_5.Date_Modifier
{
    public class StartUp
    {
        static void Main()
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            var difference = DateModifier.GetDifference(firstDate, secondDate);
            Console.WriteLine(difference);
        }
    }
}
