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

        LinkedList<Encounter> EncounterList = new LinkedList<Encounter>();
        LinkedList<Enemy> EnemyList = new LinkedList<Enemy>();
        LinkedList<Parcel> ParcelList = new LinkedList<Parcel>();
        LinkedList<Landmark>LandmarkList = new LinkedList<Landmark>();


        Random random = new Random();

        public GameState()
        {

            GenerateEnemies();
            GenerateParcels(rows, columns);
            //GenerateTraps();
            //GenerateLandMarks(); 

            GenerateEnemyLocations();
            

            foreach (Enemy enemy in EnemyList)
            {   
                Console.WriteLine("I am a " + enemy.EnemyName + " and my location is " + enemy.LocationX +"," + enemy.LocationY);
                Console.WriteLine("My Power is " + enemy.Power + " and my equipped weapon is a " + enemy.equippedWeapon);

                EncounterList.AddLast(enemy);
            }
            
            foreach (Encounter encounter in EncounterList)
            {
                Console.WriteLine(encounter.GetLocation());
            }
        }

        public void GenerateParcels(int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Parcel parcel = new Parcel(i, j);
                    ParcelList.AddLast(parcel);
                    EncounterList.AddLast(parcel); 
                }
            }


        }

        public void GenerateEnemies()
        {
            int monsterAmount = random.Next(1, 6);
            dungeon = new int[rows, columns];

            for (int i = 0; i < monsterAmount; i++)
            {
                EnemyList.AddLast(EnemyFactory.CreateEnemy());
            }
        }

        public void GenerateEnemyLocations()
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

                enemy.SetLocation(x, y);
                occupiedLocations.Add(Tuple.Create(x, y));
            }
        } 
    }
}
