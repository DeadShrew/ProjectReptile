using ProjectReptile.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFactory.Monsters
{
    public class Cultist_1 : IEncounter, IEnemy
    {

        public int Power;
        public int Constitution;
        public int Dexterity;
        public int Armor;
        public int Gold;
        public int ThreatLevel;
        public int LocationX;
        public int LocationY;
        public bool IsIntelligent;
        public bool IsNegotiable;
        public string EnemyName;


        public Cultist_1()
        {
            Random random = new Random();

            this.Power = 15;
            this.Constitution = 15 + random.Next(-2, 2);
            this.Dexterity = 15;
            this.Armor = 15;

        }

        public void EncounterCheck()
        {
            throw new NotImplementedException();
        }

        public void GenerateNewLocation()
        {
            throw new NotImplementedException();
        }

        public void ResetForNewGame()
        {
            throw new NotImplementedException();
        }
    }
}
