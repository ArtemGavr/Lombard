using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lombard_Project.UserClasses
{
    [Serializable]
    public class Item: Product
    {
        public override string Name { get; set; }
        public override int Value { get; set; }
        public override DateTime DateTime {  set; get; }
        public override Client Giver { get; set; }
        public override string Description { get; set; }
        public override string Type { get; set; }

        public Item(string name, int value,Client giver, string descript, DateTime? t = null)
        {
            Name = name;
            Value = value;
            Giver = giver;
            Description = descript;
            Type = "item";
            if (t == null)
                DateTime = DateTime.Now;
            else
                DateTime = (DateTime)t;
        }

        public Item() : base() { }

        public override string ToString()
        {
            return "item";
        }
    }
}
