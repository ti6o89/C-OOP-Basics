using System;


namespace Problem_5.Pizza_Calories
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    var tokens = command.Split();

                    switch (tokens[0])
                    {
                        case "Pizza":
                            PrintPizzaIngo(tokens);
                            break;
                        case "Dough":
                            PrintDoughInfo(tokens);
                            break;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                
            }

            //var doughInfo = Console.ReadLine().Split();
            //var toppingInfo = Console.ReadLine().Split();
            //try
            //{               
            //    var dough = new Dough(doughInfo[1], doughInfo[2], int.Parse(doughInfo[3]));
            //    var topping = new Topping(toppingInfo[1], int.Parse(toppingInfo[2]));
            //    Console.WriteLine(dough.CalculateCalories());
            //    Console.WriteLine(topping.CalculateCalories());
            //}
            //catch (Exception ex)
            //{
            //
            //    Console.WriteLine(ex.Message);
            //}
            
        }

        private static void PrintDoughInfo(string[] tokens)
        {
            var dough = new Dough(tokens[1], tokens[2], int.Parse(tokens[3]));
            Console.WriteLine($"{dough.CalculateCalories():f2}");
        }

        private static void PrintPizzaIngo(string[] tokens)
        {
            var pizza = new Pizza(tokens[1], int.Parse(tokens[2]));

            var doughInfo = Console.ReadLine().Split();
            var dough = new Dough(doughInfo[1], doughInfo[2], int.Parse(doughInfo[3]));
            pizza.Dough = dough;

            for (int i = 0; i < pizza.ToppingsCount; i++)
            {
                var toppingInfo = Console.ReadLine().Split();
                var topping = new Topping(toppingInfo[1], int.Parse(toppingInfo[2]));
                pizza.AddTopping(topping);
            }

            Console.WriteLine(pizza.ToString());
        }
    }
}
