using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lombard_Project.UserClasses
{
    public class Application
    {
        //public string Name { set; get; }
        public Product Prod { set; get; }
        public Client Giver { set; get; }

        public Application(Product prod, Client clie)
        {
            Prod = prod;
            Giver = clie;
        }

    }
}
