using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DisignPattern.StructuralDesignPattern
{
    class Compound
    {
        protected string _chemincal;
        protected float _meltingPoint;
        protected float _boilingpoint;
        protected double _molecularWeight;
        protected string _molecularStructure;
        public Compound(string chemical)
        {
            _chemincal = chemical;
        }

        public virtual void Display()
        {
            Console.WriteLine($"{_chemincal}");
        }
    }

    class RichCompound : Compound
    {
        ChemicalDataBank _bank;
        public RichCompound(string compoundName) : base(compoundName)
        {

        }

        public override void Display()
        {

            _bank = new ChemicalDataBank();
            _meltingPoint = _bank.GetCriticalPoint(_chemincal, "M");
            _boilingpoint = _bank.GetCriticalPoint(_chemincal, "B");
            _molecularWeight = _bank.GetMolecularWeight(_chemincal);
            _molecularStructure = _bank.GetMolecularStructure(_chemincal);

            base.Display();
            Console.WriteLine($"Melting Point : {this._meltingPoint}");
            Console.WriteLine($"Boiling POint : { this._boilingpoint}");
            Console.WriteLine($"Molecular Weight : {this._molecularWeight}");
            Console.WriteLine($"Molecular Structure : {this._molecularStructure}");

        }
    }

    class ChemicalDataBank
    {
        public float GetCriticalPoint(string name, string point)
        {
            if (point == "M")
            {
                switch (name.ToLower())
                {
                    case "water": return 0.0f;
                    case "benzene": return 5.5f;
                    case "ethanol": return -114.0f;
                    default: return 0.0f;
                }
            }
            else

                switch (name.ToLower())
                {
                    case "water": return 100f;
                    case "benzene": return 80f;
                    case "ethanol": return 78.3f;
                    default: return 0.0f;
                }

        }

        public double GetMolecularWeight(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return 18.015;
                case "benzene": return 78.1134;
                case "ethanol": return 46.0668;
                default: return 0.000;
            }
        }

        public string GetMolecularStructure(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return "H2O";
                case "benzene": return "C2H2";
                case "ethanol": return "C2H50H";
                default: return "";
            }
        }

    }

    public class AdapterMain
    {
        public void GetAdapter()
        {
            Compound compound = new Compound("Unknow");
            compound.Display();

            compound = new RichCompound("Water");
            compound.Display();

            compound = new RichCompound("Benzene");
            compound.Display();

            compound = new RichCompound("Ethanol");
            compound.Display();
                
        }
    }
}
