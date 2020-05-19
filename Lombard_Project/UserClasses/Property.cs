using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lombard_Project.UserClasses
{
    class Property: Product
    {
        public string Adress { get; set; }
        public override int Value { get; set; }
        public override DateTime DateTime { set; get; }
        public override Client Giver { get; set; }

        public Property(string adress, int value, Client giver, DateTime? t = null)
        {
            Adress = adress;
            Value = value;
            Giver = giver;

            if (t == null)
                DateTime = DateTime.Now;
            else
                DateTime = (DateTime)t;
        }

        public Property() : base() { }
    }
}
