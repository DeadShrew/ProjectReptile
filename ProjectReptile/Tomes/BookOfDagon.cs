using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;
using System;
using System.Collections.Generic;
using System.Data;
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
            Random random = new Random();

            int role = random.Next(0, 7);

            if (role < 3)
            {
                MessageBox.Show("The tomes' text shifts into undecipherable symbols. It is worthless now.");
                player.ItemList.Remove(this);

            }
            else
            {
                if (player.Strength < player.MaxStrength)
                    player.Strength += role;
                GUIOutputManager.PlayerConsoleOutputList.AddLast("You have restored some strength. Small patches of scales appear on your body.");
            }
        }
    }
}
