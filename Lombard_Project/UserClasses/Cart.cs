using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lombard_Project.UserClasses
{
    class Cart
    {
        public List<Product> LikedProducts { private set; get; }
        public Client Buyer { private set; get; }

        public Cart(List<Product> liked, Client buyer)
        {
            LikedProducts = liked;
            Buyer = buyer;
        }
    }
}
