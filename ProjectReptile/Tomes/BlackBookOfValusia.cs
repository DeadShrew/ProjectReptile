using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;
using ProjectReptile.Weapons;
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
            this.NonCombative = false;
        }

        public override void CastSorcery(Player player, Enemy enemy)
        {
            Random random = new Random();

            int drainedHealth = random.Next(1, 3);

            enemy.Strength -= drainedHealth;

            if (player.Strength < player.MaxStrength)
            {
                player.Strength += drainedHealth;
            } else
            {
                player.Strength = player.MaxStrength; 
            }


                GUIOutputManager.PlayerConsoleOutputList.AddLast("You slurped up " + drainedHealth + " from the enemy!"); 
        }
    }
}
