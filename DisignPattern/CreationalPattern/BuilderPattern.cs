using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DisignPattern.CreationalPattern
{
    class BuilderPattern
    {
    }


    class Shop
    {
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildDoor();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheel();
        }
    }

    abstract class VehicleBuilder
    {
        protected Vehicle vehicle;

        public Vehicle Vehicle
        {
            get { return vehicle; }
        }
        
        public abstract  void BuildFrame();
        public abstract void BuildWheel();
        public abstract void BuildDoor();
        public abstract void BuildEngine();

    }

    class MotorCycleBuilder : VehicleBuilder
    {
       
        public MotorCycleBuilder()
        {
            vehicle = new Vehicle("MotorCycle");
        }
        public override void BuildDoor()
        {
            vehicle["door"] ="0";
        }
        public override void BuildEngine()
        {
            vehicle["engine"] = "Motor cycle engine";
        }
        public override void BuildFrame()
        {
            vehicle["frame"] = "Motor cycle Frame";
        }
        public override void BuildWheel()
        {
            vehicle["wheel"] = "2";
        }
    }

    class CarBuiilder : VehicleBuilder
    {
        public CarBuiilder()
        {
            vehicle = new Vehicle("Car");
        }
        public override void BuildDoor()
        {
            vehicle["door"] = "4";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "Car Engine";
        }

        public override void BuildFrame()
        {
            vehicle["frame"] = "Car Frame";
        }

        public override void BuildWheel()
        {
            vehicle["wheel"] = "4";
        }
    }

    class Vehicle
    {
        private string _vehicleType;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();
        public Vehicle(string vehicleType)
        {
            _vehicleType = vehicleType;
        }

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }

        }
        public void Show()
        {
            Console.WriteLine($"Vehicle Type = {_vehicleType}");
            Console.WriteLine($"Vehicle Frame = {_parts["frame"]}");
            Console.WriteLine($"Vehicle Engine = {_parts["engine"]}");
            Console.WriteLine($"Vehicle Door = {_parts["door"]}");
            Console.WriteLine($"Vehicle Wheel = {_parts["wheel"]}");
        }
    }
}
