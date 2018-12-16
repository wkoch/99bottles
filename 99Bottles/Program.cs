using System;

namespace _99Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            var wall = new Wall();
            wall.Buy();
            var bottles = wall.bottles;
            foreach (var bottle in bottles)
            {
                Console.WriteLine(wall.CheckWall());
                Console.WriteLine(wall.TakeOne());
            }
            Console.WriteLine(wall.CheckWall());
        }
    }
}
