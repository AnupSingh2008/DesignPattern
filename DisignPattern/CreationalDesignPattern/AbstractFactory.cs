using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DesignPattern.DisignPattern.CreationalPattern
{
    abstract class AbstractContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }

    class AfricaFactory : AbstractContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
             return new Lion();
        }

        public override Herbivore CreateHerbivore()
        {
 
            return new WildBeast();
        }
    }
    class AmericaFactory : AbstractContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
    }

    internal class WildBeast : Herbivore
    {
    }

    internal class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine($"{this.GetType().Name} eats {h.GetType().Name}");
        }
    }

    internal class Bison : Herbivore
    {

    }

    internal class Wolf : Carnivore 
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine($"{this.GetType().Name} eats {h.GetType().Name}");
        }
    }

    abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);
    }

    abstract class Herbivore
    {
        
    }

    class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _Carnivore;
        public AnimalWorld(AbstractContinentFactory abstractContinentFactory)
        {
            _herbivore = abstractContinentFactory.CreateHerbivore();
            _Carnivore = abstractContinentFactory.CreateCarnivore();

        }

        public void RunFoodChain()
        {
            _Carnivore.Eat(_herbivore);
        }
    }
}
