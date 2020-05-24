using System;
using System.Drawing;

namespace Lombard_Project.UserClasses
{
    [Serializable]
    public abstract class Product
    {
        public abstract string Name { get; set; }
        public abstract int Value { get; set; }
        public abstract DateTime DateTime { set; get; }
        public abstract Client Giver { get; set; }
        public abstract string Description { get; set; }
        public abstract string Type { get; set; }
        public abstract Image Image { get; set; }

        public Product()
        {
        }
    }
}