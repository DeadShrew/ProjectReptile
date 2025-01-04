using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.AbstractClasses
{
    public abstract class Item
    {
        public string Name;
        public string TrueName;

        public override string ToString()
        {
            return Name;
        }
    }
}
