using System.Collections.Generic;
using System;

namespace Hungry
{
    public class Buffet
{
    public List<Food> Menu;
     
    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Apple", 10, true, true),
            new Food("Pear", 30, false, false),
            new Food("Peach", 50, false, true),
            new Food("DragonFruit", 150, true, false),
            new Food("PalmFruit", 1000, false, true),
            new Food("Hydromelon", 100, true, false),
            new Food("Durian", 200, true, true)
        };
    }
        public Food Serve()
        {
            Random rand = new Random();
            int randInt = rand.Next(0,6);
            
            Console.WriteLine(Menu[randInt]);

            return Menu[randInt];
        }
     
}


}