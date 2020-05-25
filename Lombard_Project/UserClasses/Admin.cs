using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Lombard_Project.UserClasses;

namespace Lombard_Project.UserClasses
{
    [Serializable]
    public class Admin : User
    {
        public override int ID { get ; set ; }
        public override string Name { get ; set; }

        public Admin(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
