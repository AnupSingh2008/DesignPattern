using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DisignPattern.StructuralDesignPattern
{
    class BridgeMain
    {
         public void GetBridgeMain()
        {
            Customer customer = new Customer("Delhi");

            customer.Data = new CustomerData();

            customer.Next();
            customer.Show();
            customer.Prior();
            customer.Show();
            customer.ShowAll();
            customer.Add("Anup");
            customer.ShowAll();
        }
    }


   class CustomerBase
    {
        private Dataobject _dataObject;
        private string _group;
        public CustomerBase(string groupName)
        {
            Console.WriteLine(groupName);
        }
        public Dataobject Data
        {
            get { return _dataObject; }
            set { _dataObject = value; }
        }

        public virtual void Next()
        {
            _dataObject.NextRecord();
        }
        public virtual void Prior()
        {
            _dataObject.PriorRecord();
        }
        public virtual void Add(string customer)
        {
            _dataObject.AddRecord(customer);
        }
        public virtual void Delete(string customer)
        {
            _dataObject.DeleteRecord(customer);
        }
        public virtual void Show()
        {
            _dataObject.ShowRecord();
        }
        public virtual void ShowAll()
        {
            _dataObject.ShowAllRecord();
        }
    }
    class Customer : CustomerBase
    {
        public Customer(string group):base(group)
        {

        }

        public override void ShowAll()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
            base.ShowAll();
            Console.WriteLine("--------------------------------------------------");
        }


    }

    abstract class Dataobject
    {
        public abstract void NextRecord();
        public abstract void PriorRecord();
        public abstract void AddRecord(string customer);
        public abstract void DeleteRecord(string customer);
        public abstract void ShowRecord();
        public abstract void ShowAllRecord();
    }

    class CustomerData : Dataobject
    {
        private List<string> _customer = new List<string>();
        private int _current;
        public CustomerData()
        {
            _customer.Add("Anika");
            _customer.Add("Avyaan");
            _customer.Add("Neha");
            _customer.Add("Mansi");
            _customer.Add("Ruby");
            _customer.Add("Avinash");
        }
        public override void PriorRecord()
        {
            if (_current > 0)
                _current--;
        }

        public override void NextRecord()
        {
            if (_current > 0 && _current < _customer.Count - 1)
                _current++;
        }
        public override void AddRecord(string customer)
        {
            _customer.Add(customer);
        }
        public override void DeleteRecord(string customer)
        {
            _customer.Remove(customer);
        }
        public override void ShowRecord()
        {
            Console.WriteLine(_customer[_current]);
        }
        public override void ShowAllRecord()
        {
            foreach (var str in _customer)
                Console.WriteLine(str);
        }
    }
}
