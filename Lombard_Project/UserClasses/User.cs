using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lombard_Project.UserClasses
{
    [Serializable]
    public abstract class User
    {
        public abstract int ID { set; get; }
        public abstract string Name { set; get; }
    }
}
