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
            Console.WriteLine("Enter builder for Builder method.");
            string str = Console.ReadLine();
            if (str.ToLower() == "abs")
            {
                AbstractFactory();
            }
            else if(str.ToLower() == "builder")
            {
                Builder();
            }
            Console.ReadKey();
        }

        private static void AbstractFactory()
        {
            AbstractContinentFactory continentFactory = new AfricaFactory();
            AnimalWorld animalWorld = new AnimalWorld(continentFactory);
            animalWorld.RunFoodChain();

            AbstractContinentFactory continentFactory1 = new AmericaFactory();
            AnimalWorld animalWorld1 = new AnimalWorld(continentFactory1);
            animalWorld1.RunFoodChain();
        }

        public static void Builder()
        {
            VehicleBuilder vehicleBuilder;
               
            Shop shop = new Shop();
            vehicleBuilder = new MotorCycleBuilder();
            shop.Construct(vehicleBuilder);
            vehicleBuilder.Vehicle.Show();

            vehicleBuilder = new CarBuiilder();
            shop.Construct(vehicleBuilder);
            vehicleBuilder.Vehicle.Show();

            
        }
    }
}
