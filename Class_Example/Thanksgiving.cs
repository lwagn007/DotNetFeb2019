using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Example
{
    public enum FoodType { Appetizer, Entree, Dessert}

    public class Thanksgiving
    {

        public string Name { get; set; }
        public bool PlayGame { get; set; }
        public string Location { get; set; }
        public int GuestCount { get; set; }
        public double CookTime { get; set; }
        public FoodType Type { get; set; }

        public Thanksgiving(string name, bool playGame, string location, int guestCount, double cookTime, FoodType type)
        {
            Name = name;
            PlayGame = playGame;
            Location = location;
            GuestCount = guestCount;
            CookTime = cookTime;
            Type = type;
        }

        public Thanksgiving(string name)
        {
            Name = name;
        }

        public Thanksgiving()
        {

        }
    }
}
