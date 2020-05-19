using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lombard_Project.UserClasses
{
    class Item: Product
    {
        public string Name { get; set; }
        public override int Value { get; set; }
        public override DateTime DateTime {  set; get; }
        public override Client Giver { get; set; }

        public Item(string name, int value,Client giver, DateTime? t = null)
        {
            Name = name;
            Value = value;
            Giver = giver;

            if (t == null)
                DateTime = DateTime.Now;
            else
                DateTime = (DateTime)t;
        }

        public Item() : base() { }
    }
}
