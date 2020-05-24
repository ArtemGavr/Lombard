using System;
using System.Drawing;

namespace Lombard_Project.UserClasses
{
    [Serializable]
    public class Item : Product
    {
        public override string Name { get; set; }
        public override int Value { get; set; }
        public override DateTime DateTime { set; get; }
        public override Client Giver { get; set; }
        public override string Description { get; set; }
        public override string Type { get; set; }
        public override Image Image { get; set; }
        public override string GiverName { get => Giver.Name;  }

        public Item(string name, int value, Client giver, string descript, Image image, DateTime? t = null)
        {
            Name = name;
            Value = value;
            Giver = giver;
            Description = descript;
            Image = image;
            Type = "item";
            if (t == null)
                DateTime = DateTime.Now;
            else
                DateTime = (DateTime)t;
        }

        public Item() : base()
        {
        }

        public override string ToString()
        {
            return "item";
        }
    }
}