using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;
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
            this.NonCombative = false;
        }

        public override void CastSorcery(Player player, Enemy enemy)
        {
            Random random = new Random();

            int role = random.Next(0, 7);

            if (role < 3)
            {
                MessageBox.Show("The tome bursts into flames.");
                player.ItemList.Remove(this);

            }
            else
            {
                int dmgRole = random.Next(5, 10);

                enemy.Strength -= dmgRole;
                GUIOutputManager.PlayerConsoleOutputList.AddLast("A blast of eldritch consumes your foe.");
            }
        }
    }
}
