using DesignPattern.DisignPattern.CreationalPattern;
using DesignPattern.DisignPattern.StructuralDesignPattern;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Design Pattern Name");
            Console.WriteLine("********Creational Design Pattern**********************");
            Console.WriteLine("Enter abs for Abstract Factory Method.");
            Console.WriteLine("Enter builder for Builder method.");
            Console.WriteLine("Enter factory for Factory method.");
            Console.WriteLine("Enter prototype for Prototype method.");
            Console.WriteLine("Enter singleton for Singleton pattern");
            Console.WriteLine("********Structural Design Pattern**********************");
            Console.WriteLine("Enter adapter for Adpater desing pattern.");
            Console.WriteLine("Enter bridge for Bridge desing pattern.");
            Console.WriteLine("Enter composite for Composite desing pattern.");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");

            string str = Console.ReadLine();
            Console.WriteLine($"Output of {str}\n");
            switch (str.ToLower())
            {
                case "abs": AbstractFactory();
                    break;

                case "builder": Builder();
                    break;

                case "factory": Factory();
                    break;

                case "prototype":Prototype();
                    break;

                case "singleton": Singleton();
                    break;

                case "adapter":Adapter();
                    break;

                case "bridge":
                    Bridge();
                    break;

                case "composite":
                    Composite();
                    break;

                default: 
                    break;
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
            PrototypeMain prototypeMain = new PrototypeMain();
            prototypeMain.GetProtoTypeMain();

        }

        public static void Singleton()
        {
            SingletonMain singletonMain = new SingletonMain();
            singletonMain.CallSingleton();
        }

        public static void Adapter()
        {
            AdapterMain adapter = new AdapterMain();
            adapter.GetAdapter();
        }

        public static void Bridge()
        {
            BridgeMain bridgeMain = new BridgeMain();
            bridgeMain.GetBridgeMain();
        }

        public static void Composite()
        {
            CompositeMain compositeMain = new CompositeMain();
            compositeMain.GetCompositeMain();
        }
    }
}
