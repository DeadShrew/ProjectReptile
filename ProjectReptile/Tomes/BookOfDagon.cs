using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;
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
            this.NonCombative = true;
        }

        public override void CastSorcery(Player player, Enemy enemy)
        {
            if (player.Strength < player.MaxStrength)
            player.Strength += 1;
            GUIOutputManager.PlayerConsoleOutputList.AddLast("You have healed some health!"); 
        }
    }
}
