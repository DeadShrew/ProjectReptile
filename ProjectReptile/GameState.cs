using ProjectReptile.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile
{
    internal class GameState
    {

        public int rows = 3;
        public int columns  = 3;
        public int[,] dungeon;

        LinkedList<Enemy> EnemyList = new LinkedList<Enemy>();  
        LinkedList<Landmark> LandmarkList = new LinkedList<Landmark>();
        LinkedList<Trap> TrapList = new LinkedList<Trap>();

        Random random = new Random();

        public GameState()
        {
            int monsterAmount= random.Next(1, 6);
            dungeon = new int[rows, columns];

            for (int i = 0; i < monsterAmount; i++)
            {
                EnemyList.AddLast(EnemyFactory.CreateEnemy());
            }

            GenerateMonsterLocation();

            foreach (Enemy enemy in EnemyList)
            {
                Console.WriteLine("I am a " + enemy.EnemyName + " and my location is " + enemy.LocationX +"," + enemy.LocationY);
            }       
        }

        public void GenerateMonsterLocation()
        {
            foreach (Enemy enemy in EnemyList)
            {
                int x = random.Next(1, rows + 1);
                int y = random.Next(1, columns + 1);
                enemy.SetEnemyLocation(x, y);

            }
        }
    }
}
