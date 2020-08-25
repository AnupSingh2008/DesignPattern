using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DisignPattern.CreationalPattern
{

    class LoadBalancer
    {
        private static LoadBalancer _instance;
        private List<string> _server = new List<string>();
        Random random = new Random();

        private static object synLock = new object();

        protected LoadBalancer()
        {
            _server.Add("Server 1");
            _server.Add("Server 2");
            _server.Add("Server 3");
            _server.Add("Server 4");
            _server.Add("Server 5");

        }

        public static LoadBalancer GetLoadBalancer()
        {
            lock (synLock)
            {
                if (_instance == null)
                {
                    _instance = new LoadBalancer();
                }
            }
            return _instance;
        }

        public string Server
        {
            get
            {
                int r = random.Next(_server.Count);
                return _server[r].ToString();
            }
        }
    }

    class SingletonMain
    {

        public void CallSingleton()
        {
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            if (b1 == b2 && b2 == b3)
            {
                Console.WriteLine("Same instance");
            }

            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            for(int i= 0; i < 15; i++)
            {
                string server = balancer.Server;
                Console.WriteLine($"Disptach request to :{server}");
            }
        }
    }
}
