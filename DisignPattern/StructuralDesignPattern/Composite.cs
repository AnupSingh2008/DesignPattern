using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DisignPattern.StructuralDesignPattern
{
    interface Icomponent
    {
        public void DisplayPrice();
    }

    class Leaf : Icomponent
    {
        string _name;
        float _price;
        static string strspacepad = "";
        public Leaf(string name, float price)
        {
            _name = name;
            _price = price;
        }
        public void DisplayPrice()
        {
            Console.WriteLine($"        -Price :{this._price}   Leaf Name :{this._name}\t");
        }
    }

    class Composite : Icomponent
    {
        string _name;
        List<Icomponent> icomponents = new List<Icomponent>();
        static string strspacepad = "";
        public Composite()
        {

        }
        public Composite(string name)
        {
            _name = name;
        }

        public void Add(Icomponent icomponent)
        {
            icomponents.Add(icomponent);
        }

        public void DisplayPrice()
        {
            Console.WriteLine($"{strspacepad}+Composite Name : {this._name}");
            foreach (var com in icomponents)
            {
                if (com.GetType() == new Composite().GetType())
                {
                    strspacepad = strspacepad + "   ";
                }
                
                com.DisplayPrice();
                
            }
        }
    }

    class CompositeMain
    {
        public void GetCompositeMain()
        {
            Icomponent Keyboard = new Leaf("Keyboard",500);
            Icomponent Mouse = new Leaf("Mouse", 100);

            Icomponent HardDisk = new Leaf("HardDisk", 1000);
            Icomponent Ram = new Leaf("Ram", 600);
            Icomponent CPU = new Leaf("CPU",1200);

            Composite Peripheral = new Composite("Peropheral");
            Composite Motherboard = new Composite("Motherboard");

            Composite Cabinet = new Composite("Cabinet");

            Peripheral.Add(Mouse);
            Peripheral.Add(Keyboard);

            Cabinet.Add(Peripheral);

            Motherboard.Add(CPU);
            Motherboard.Add(Ram);

            Cabinet.Add(Motherboard);

            Cabinet.Add(HardDisk);

            //Peripheral.DisplayPrice();
            //Keyboard.DisplayPrice();
            //Mouse.DisplayPrice();

            //Motherboard.DisplayPrice();
            //Ram.DisplayPrice();
            //CPU.DisplayPrice();

            Cabinet.DisplayPrice();
           // HardDisk.DisplayPrice();




        }
    }
}
