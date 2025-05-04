using ProjectReptile.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Tomes
{
    class Necronomicon : Tome
    {
        public Necronomicon()
        {
            this.Name = "arcane tome";
            this.TrueName = "Necronomicon";
        }
        public override void CastSorcery()
        {
            throw new NotImplementedException();
        }
    }
}
