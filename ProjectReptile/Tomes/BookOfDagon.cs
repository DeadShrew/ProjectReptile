using ProjectReptile.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Tomes
{
    class BookOfDagon : Tome
    {
        public BookOfDagon()
        {
            this.Name = "arcane tome";
            this.TrueName = "Book of Dagon";
        }

        public override void CastSorcery()
        {
            throw new NotImplementedException();
        }
    }
}
