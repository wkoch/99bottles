using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _99Bottles
{
    class Wall
    {
        public List<Bottle> bottles = new List<Bottle>();

        public void Buy()
        {
            for (int i = 0; i < 99; i++)
            {
                bottles.Add(new Bottle());
            }
        }

        List<Bottle> AvailableBottles() {
            var availableBottles = from bottle in bottles
                             where bottle.taken == false
                             select bottle;
            return availableBottles.ToList();
        }

        int CountAvailableBottles() {
            return AvailableBottles().Count();
        }

        public string CheckWall()
        {
            if (CountAvailableBottles() > 1)
                return $"{CountAvailableBottles()} bottles of beer on the wall, {CountAvailableBottles()} bottles of beer.";
            else if (CountAvailableBottles() == 1)
                return $"{CountAvailableBottles()} bottle of beer on the wall, {CountAvailableBottles()} bottle of beer.";
            else
                return $"No more bottles of beer on the wall, no more bottles of beer.";
        }

        public string TakeOne()
        {
            AvailableBottles().FirstOrDefault().taken = true;
            if (CountAvailableBottles() > 1) {
                return $"Take one down and pass it around, {CountAvailableBottles()} bottles of beer on the wall.";
            }
            else if (CountAvailableBottles() == 1) {
                return $"Take one down and pass it around, {CountAvailableBottles()} bottle of beer on the wall.";
            }
            else {
                return $"Take one down and pass it around, no more bottles of beer on the wall.";
            }
        }
    }
}
