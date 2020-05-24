using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lombard_Project.UserClasses
{
    [Serializable]
    public class Client: User
    {
        public override int ID { get; set; }
        public override string Name { get; set; }

        public string Password { get; set; }
        public List<Product> PurchasedGoods {set; get; }

        public Client(int id, string name,  string pass)
        {
            ID = id;
            Name = name;
            //Login = log;
            Password = pass;
            PurchasedGoods = new List<Product>();
        }
    }
}
