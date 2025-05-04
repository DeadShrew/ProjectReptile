using ProjectReptile.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Tomes
{
    class BlackBookOfValusia : Tome
    {
        public BlackBookOfValusia()
        {
            this.Name = "arcane tome";
            this.TrueName = "Black Book of Valusia";
        }

        public override void CastSorcery()
        {
            throw new NotImplementedException();
        }
    }
}
