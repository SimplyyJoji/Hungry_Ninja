using System;
using System.Collections.Generic;

namespace Hungry
{
    public class Ninja
{
    private int calorieIntake;
    
    public List<Food> FoodHistory;
    
     
    // add a constructor
    
     public Ninja ()
    {
        calorieIntake = 0;
        
        FoodHistory = new List<Food>();
    }
     

    // add a public "getter" property called "IsFull"
    // build out the Eat method
    public bool IsFull 
    //We use the get and not set because we can do a conditional inside the get and still set a value. 
        {
            get
            {
                if (calorieIntake > 1200) 
                {
                    return true;
                }
                return false;
            }
        }
    public void Eat(Food item)
    {
        //Check if food
        if (IsFull)
        {
            Console.WriteLine("I am not hungry");
        }
        else
        {
            this.calorieIntake += item.Calories;
            FoodHistory.Add(item);
            Console.WriteLine($"The Ninja ate {item.Name} is went to his thighs! The calories were {item.Calories}");
        }
        //if the calorieIntake is above 1200 console full
        //else eat more add to calorie 
    
    }
}


}