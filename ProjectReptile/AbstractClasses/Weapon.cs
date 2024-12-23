using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.AbstractClasses
{
    public abstract class Weapon : Item
    {
        public int Power;
        public bool TwoHanded;
        public bool Magical;
        public string Name;
    }
}
