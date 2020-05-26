using System;

namespace Lombard_Project.UserClasses
{
    [Serializable]
    public class MyApplication
    {
        //public string Name { set; get; }
        public Product Prod { set; get; }

        public Client Giver { set; get; }

        public string ClientName { get { return Giver.Name; } }

        public string ProductName
        {
            get { return Prod.Name; }
        }

        public MyApplication(Product prod, Client clie)
        {
            Prod = prod;
            Giver = clie;
        }
    }
}