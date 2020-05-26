using System;
using System.Collections.Generic;

namespace Lombard_Project.UserClasses
{
    [Serializable]
    public class Cart
    {
        // Коллекція продуктів на покупку.
        public List<Product> LikedProducts { set; get; }
        // Покупець-клієнт.
        public Client Buyer { set; get; }

        public Cart()
        {
            LikedProducts = new List<Product>();
        }
    }
}