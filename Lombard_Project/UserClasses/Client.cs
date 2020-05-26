using System;
using System.Collections.Generic;

namespace Lombard_Project.UserClasses
{
    [Serializable]
    public class Client
    {
        // Паспорт клієнту.
        public int ID { get; set; }
        // Ім'я.
        public string Name { get; set; }
        // Пароль.
        public string Password { get; set; }
        // Колукція куплених товарів.
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