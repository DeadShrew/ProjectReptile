using ProjectReptile.Landmarks;
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
                Console.WriteLine("My Power is " + enemy.Power + " and my equipped weapon is a " + enemy.equippedWeapon);
            }       
        }

        public void GenerateMonsterLocation()
        {
            List<Tuple<int, int>> occupiedLocations = new List<Tuple<int, int>>();

            foreach (Enemy enemy in EnemyList)
            {
                bool isPositionOccupied = true;
                int x = 0, y = 0;

                while (isPositionOccupied)
                {
                    x = random.Next(1, rows + 1); 
                    y = random.Next(1, columns + 1); 

                    isPositionOccupied = false;
                    foreach (var occupiedLocation in occupiedLocations)
                    {
                        if (occupiedLocation.Item1 == x && occupiedLocation.Item2 == y)
                        {
                            isPositionOccupied = true;
                            break;
                        }
                    }
                }

                enemy.SetEnemyLocation(x, y);
                occupiedLocations.Add(Tuple.Create(x, y));
            }
        }
    }
}
