using System;
using System.Drawing;

namespace Lombard_Project.UserClasses
{
    [Serializable]

    // Класс "Квартира", унаслідує "Товар".
    public class Property : Product
    {
        public override string Name { get; set; }
        public override int Value { get; set; }
        public override DateTime DateTime { set; get; }
        public override Client Giver { get; set; }
        public override string Description { get; set; }
        public override string Type { get; set; }
        public override Image Image { get; set; }
        public override string GiverName { get => Giver.Name; }
        public override int Price { set; get; }
        public override int StoreDays { get; set; }

        public Property(string name, int value, Client giver, string descr, DateTime? t = null)
        {
            Name = name;
            Value = value;
            Giver = giver;
            Description = descr;
            Type = "property";
            if (t == null)
                DateTime = DateTime.Now;
            else
                DateTime = (DateTime)t;
        }

        public Property() : base()
        {
        }
    }
}