using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lombard_Project.UserClasses
{
    [Serializable]
    public class Property: Product
    {
        public override string Name { get; set; }
        public override int Value { get; set; }
        public override DateTime DateTime { set; get; }
        public override Client Giver { get; set; }
        public override string Description { get; set; }
        public override string Type { get; set; }

        public Property(string adress, int value, Client giver,string descr, DateTime? t = null)
        {
            Name = adress;
            Value = value;
            Giver = giver;
            Description = descr;
            Type = "property";
            if (t == null)
                DateTime = DateTime.Now;
            else
                DateTime = (DateTime)t;
        }

        public Property() : base() { }

        public override string ToString()
        {
            return "property";
        }
    }
}
