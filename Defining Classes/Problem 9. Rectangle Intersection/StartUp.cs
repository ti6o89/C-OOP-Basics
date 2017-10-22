using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_9.Rectangle_Intersection
{
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rectangles = new List<Rectangle>();

            for (int i = 0; i < input[0]; i++)
            {
                var rectangleInfo = Console.ReadLine().Split();

                var id = rectangleInfo[0];
                var width = double.Parse(rectangleInfo[1]);
                var height = double.Parse(rectangleInfo[2]);
                var topLeftX = double.Parse(rectangleInfo[3]);
                var topLeftY = double.Parse(rectangleInfo[4]);

                var rectangle = new Rectangle(id, width, height, topLeftX, topLeftY);
                rectangles.Add(rectangle);
            }

            for (int i = 0; i < input[1]; i++)
            {
                var tokens = Console.ReadLine().Split();
                var firstId = tokens[0];
                var secondId = tokens[1];
                var firstRectangle = rectangles.Where(r => r.Id == firstId).FirstOrDefault();
                var secondRectangle = rectangles.Where(s => s.Id == secondId).FirstOrDefault();

                Console.WriteLine(firstRectangle.IsIntersection(secondRectangle) ? "true" : "false");
            }
        }
    }
}
