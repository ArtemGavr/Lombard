using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lombard_Project.UserClasses
{
    [Serializable]
    public class Cart 
    {
        public List<Product> LikedProducts { set; get; }
        public Client Buyer { set; get; }

     

        public Cart()
        {
            LikedProducts = new List<Product>();

        }
    }
}
