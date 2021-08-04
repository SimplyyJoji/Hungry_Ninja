using System;

namespace Hungry
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja ninja1 = new Ninja();
            Buffet buffet1 = new Buffet();
            
            while (!ninja1.IsFull)
            {
                ninja1.Eat(buffet1.Serve());
            }

        }
    }
}
