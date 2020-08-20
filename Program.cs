using DesignPattern.DisignPattern.CreationalPattern;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Design Pattern Name");
            Console.WriteLine("Enter abs for Abstract Factory Method.");
            string str = Console.ReadLine();
            if (str.ToLower() == "abs")
            {
                AbstractContinentFactory continentFactory = new AfricaFactory();
                AnimalWorld animalWorld = new AnimalWorld(continentFactory);
                animalWorld.RunFoodChain();

                AbstractContinentFactory continentFactory1 = new AmericaFactory();
                AnimalWorld animalWorld1 = new AnimalWorld(continentFactory1);
                animalWorld1.RunFoodChain();
            }
            Console.ReadKey();
        }
    }
}
