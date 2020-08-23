﻿using DesignPattern.DisignPattern.CreationalPattern;
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
            Console.WriteLine("Enter factory for Factory method.");
            Console.WriteLine("Enter prototype for Prototype method.");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");

            string str = Console.ReadLine();
            if (str.ToLower() == "abs")
            {
                AbstractFactory();
            }
            else if (str.ToLower() == "builder")
            {
                Builder();
            }
            else if (str.ToLower() == "factory")
            {
                Factory();
            }
            else if (str.ToLower() == "prototype")
            {
                Prototype();
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

        public static void Factory()
        {
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();

            foreach(var document in documents)
            {
                Console.WriteLine($"Create a documet for :{document.GetType().Name}");
                Console.WriteLine("-------------------------------------------------");
                foreach(var page in document.Pages)
                {
                    Console.WriteLine($"Added Section : {page.GetType().Name}");
                }
                Console.WriteLine($"******{document.GetType().Name} completed.***");
                Console.WriteLine();
            }
        }

        public static void Prototype()
        {
            ColorManager colorManager = new ColorManager();

            //Initiate basic color
            colorManager["Red"] = new Color(255, 0, 0);
            colorManager["Green"] = new Color(0, 255, 0);
            colorManager["Blue"] = new Color(0, 0, 255);

            colorManager["Angry"] = new Color(255, 54, 0);
            colorManager["Peace"] = new Color(128, 211, 128);
            colorManager["Flame"] = new Color(211, 34, 20);

            Color color1 = colorManager["Red"].clone() as Color;
            Color color2 = colorManager["Angry"].clone() as Color;
            Color color3 = colorManager["Flame"].clone() as Color;

        }
    }
}
