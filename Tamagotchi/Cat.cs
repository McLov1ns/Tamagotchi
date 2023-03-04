using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi
{
    struct Fruit
    {
        public string type;
        public int health;
    }
    
    
    class Cat
    {
        public string name;
        public int hunger = 100;
        public void Meow()
        {
            Console.WriteLine("meow! ");
        }
        public void Eat(Fruit f)
        {
            Console.WriteLine($"Cat eats {f.type}. {f.health} hp.\n");
        }
    }
}
