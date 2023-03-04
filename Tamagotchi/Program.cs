using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat { name = "Pushok", hunger = 5 };
            cat.Meow();
            Fruit fruitApple = new Fruit {type = "apple", health = 10 };
            cat.Eat(fruitApple);
            Fruit fruitOrange = new Fruit {type = "apple", health = 5 };
            cat.Eat(fruitOrange);
            DoMeal(cat, fruitApple);
            DoMeal(cat, fruitApple);
            DoMeal(cat, fruitOrange);
        }
        static void DoMeal(Cat c, Fruit f)
        {
            c.Eat(f);
        }
    }
}
