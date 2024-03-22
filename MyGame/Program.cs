using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int array_length = int.Parse(args[0]);
            Enemy [] enemies = new Enemy [array_length];

            for(int x = 0; x < array_length; x++)
            {
                Console.Write($"Nome do inimigo {x + 1}: ");
                string name = Console.ReadLine();
                Enemy enemy = new Enemy(name);
                enemies[x] = enemy;
            }
            for(int x = 0; x < array_length; x++)
            {
                Console.WriteLine($"{enemies[x].GetName()} " +
                $"{enemies[x].GetHealth()} {enemies[x].GetShield()}");
            }

        }
    }
}
