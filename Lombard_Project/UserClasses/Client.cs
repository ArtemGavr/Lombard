using System;
using System.Collections.Generic;

namespace Lombard_Project.UserClasses
{
    [Serializable]
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }
        public List<Product> PurchasedGoods { set; get; }

        public Client(int id, string name, string pass)
        {
            ID = id;
            Name = name;
            Password = pass;
            PurchasedGoods = new List<Product>();
        }
    }
}