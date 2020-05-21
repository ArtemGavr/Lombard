using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lombard_Project.UserClasses
{
    [Serializable]
    public abstract class Product
    {
       // public abstract string Name { get; set; }
        public abstract int Value { get; set; }
        public abstract DateTime DateTime { set; get; }
        public abstract Client Giver { get; set; }

        public Product() { }
    }
}
