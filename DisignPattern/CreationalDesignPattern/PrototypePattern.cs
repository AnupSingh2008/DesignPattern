using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DisignPattern.CreationalPattern
{
    public class PrototypeMain
    {
        public void GetProtoTypeMain()
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
    public abstract class ColorPrototype
    {
        public abstract ColorPrototype clone();
    }

    class Color : ColorPrototype
    {
        private int _red;
        private int _green;
        private int _blue;
        public Color(int red, int green,int blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }

        public override ColorPrototype clone()
        {
            Console.WriteLine($"Color is cloning.. Red : {this._red} Green :{this._green} Blue : {this._green} ");
            return this.MemberwiseClone() as ColorPrototype;
        }

    }

    public class ColorManager
    {
        private Dictionary<string, ColorPrototype> _color = new Dictionary<string, ColorPrototype>();

        public ColorPrototype this[string key]
        {
            get { return _color[key]; }
            set { _color[key] = value; }
        }
    }
}
