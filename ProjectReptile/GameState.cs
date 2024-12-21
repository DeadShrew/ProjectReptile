using ProjectReptile.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile
{
    internal class GameState
    {

        public int rows = 10;
        public int columns  = 10;
        public int[,] dungeon;

        LinkedList<IEnemy> EnemyList = new LinkedList<IEnemy>();  
        LinkedList<ILandmark> LandmarkList = new LinkedList<ILandmark>();
        LinkedList<Trap> TrapList = new LinkedList<Trap>();

        Random random = new Random();

        public GameState()
        {

            dungeon = new int[rows, columns];
        }

        public void GenerateMonsterLocation()
        {
            foreach (IEnemy enemy in EnemyList)
            {
                int x = random.Next(0 , rows);  
                int y = random.Next(0, columns);  
                enemy.GenerateEnemyLocation(x, y);  

                foreach (IEnemy enlistedEnemy in EnemyList)
                {
                    if (enemy.GetEnemyLocation == enlistedEnemy.GetEnemyLocation)
                    {
                        GenerateMonsterLocation();
                    }
                }
            }
        }
    }
}
