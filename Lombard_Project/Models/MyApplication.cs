using System;

namespace Lombard_Project.UserClasses
{
    [Serializable]
    // Класс аплікації.
    public class MyApplication
    {
        // Який продукт здали.
        public Product Prod { set; get; }
        // Хто здав.
        public Client Giver { set; get; }
        // Повертає ім'я клієнта для коректного відображення. 
        public string ClientName 
        { 
            get { return Giver.Name; } 
        }
        // Повертає назву товару для коректног відображення. 
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