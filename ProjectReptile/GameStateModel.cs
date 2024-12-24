using ProjectReptile.AbstractClasses;
using ProjectReptile.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile
{
    internal class GameStateModel
    {
        public int rows = Settings.Rows;
        public int columns  = Settings.Rows;

        public Player player; 

        LinkedList<Encounter> EncounterList = new LinkedList<Encounter>();
        LinkedList<Enemy> EnemyList = new LinkedList<Enemy>();
        LinkedList<Parcel> ParcelList = new LinkedList<Parcel>();
        LinkedList<Trap> TrapList = new LinkedList<Trap>();
        LinkedList<Landmark>LandmarkList = new LinkedList<Landmark>();

        Random random = new Random();

        public GameStateModel()
        {
            GenerateParcels(rows, columns);
            GenerateEnemies();
            GenerateTraps(rows, columns);
            GenerateLandmarks(); 

            GenerateEnemyLocations();
            GenerateTrapLocations();
            GenerateLandmarkLocations();

            AddEnemiesToEncounterList();
            AddTrapsToEncounterList();
            AddLandmarksToEncounterList();

            player = new Player();

            foreach (Enemy enemy in EnemyList)
            {
                foreach (Trap trap in TrapList)
                {
                    if (enemy.LocationX == trap.LocationX && enemy.LocationY == trap.LocationY)  
                    {
                        Console.WriteLine("Boom! at space " + enemy.GetLocation().ToString()); 
                    }
                }
            }
        
        }

        public void GenerateParcels(int rows, int columns)
        {
            for (int i = 0; i < rows + 1; i++)
            {
                for (int j = 0; j < columns+ 1; j++)
                {
                    Parcel parcel = new Parcel(i, j);
                    ParcelList.AddLast(parcel); 
                }
            }

            foreach(Parcel parcel in ParcelList)
            {
                EncounterList.AddLast(parcel); 
            }
        }

        public void GenerateEnemies()
        {
            int monsterAmount = random.Next(1, 6);

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

        public void AddEnemiesToEncounterList()
        {
            foreach (Enemy enemy in EnemyList)
            {
                Console.WriteLine("I am a " + enemy.Name + " and my location is " + enemy.LocationX + "," + enemy.LocationY);
                Console.WriteLine("My Power is " + enemy.Power + " and my equipped weapon is a " + enemy.equippedWeapon);

                EncounterList.AddLast(enemy);
            }
        }

        public void GenerateTraps(int rows, int columns)
        {
            for (int i = 0; i < columns + 1; i++)
            {
                TrapList.AddLast(new Trap());
            }
        }

        public void GenerateTrapLocations()
        {
            List<Tuple<int, int>> occupiedLocations = new List<Tuple<int, int>>();

            foreach (Trap trap in TrapList)
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

                trap.SetLocation(x, y);
                occupiedLocations.Add(Tuple.Create(x, y));
            }
        }

        public void AddTrapsToEncounterList()
        {
            foreach (Trap trap in TrapList)
            {
                Console.WriteLine("I am a trap and my location is " + trap.LocationX + "," + trap.LocationY);
               
                EncounterList.AddLast(trap);
            }
        }

        public void GenerateLandmarks()
        {
            int landmarkAmount = random.Next(1, 6);

            for (int i = 0; i < landmarkAmount; i++)
            {
                LandmarkList.AddLast(LandmarkFactory.CreateLandmark());
            }
        }

        public void GenerateLandmarkLocations()
        {
            List<Tuple<int, int>> occupiedLocations = new List<Tuple<int, int>>();

            foreach (Landmark landmark in LandmarkList)
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

                landmark.SetLocation(x, y);
                occupiedLocations.Add(Tuple.Create(x, y));
            }
        }

        public void AddLandmarksToEncounterList()
        {
            foreach (Landmark landmark in LandmarkList)
            {
                Console.WriteLine("I am a " + landmark.Name + " and my location is " + landmark.LocationX + "," + landmark.LocationY);
                
                EncounterList.AddLast(landmark);
            }
        }

        public void EncounterCheck()
        {
            foreach (Enemy enemy in EnemyList)
            {
                enemy.EncounterCheck(player); 
            }
        }
    }
}
