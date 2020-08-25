using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DisignPattern.CreationalPattern
{
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
