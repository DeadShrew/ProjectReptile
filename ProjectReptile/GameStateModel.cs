using ProjectReptile.AbstractClasses;
using ProjectReptile.Factories;

namespace ProjectReptile
{
    internal class GameStateModel
    {
        public int rows = Settings.Rows;
        public int columns  = Settings.Columns;

        public Player player; 

        public LinkedList<Encounter> EncounterList = new LinkedList<Encounter>();
        public LinkedList<Enemy> EnemyList = new LinkedList<Enemy>();
        public LinkedList<Parcel> ParcelList = new LinkedList<Parcel>();
        public LinkedList<Trap> TrapList = new LinkedList<Trap>();
        public LinkedList<Landmark>LandmarkList = new LinkedList<Landmark>();

        Random random = new Random();

        public GameStateModel()
        {
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
        }

        public void GenerateParcel(int x, int y)
        {
            if (!ParcelList.Any(o => o.LocationX == x && o.LocationY == y))
            {
                Parcel parcel = new Parcel(x, y);
                ParcelList.AddLast(parcel);
                EncounterList.AddLast(parcel); 
            }       
        }

        public void ParcelTrapProximityCheck()
        {
            foreach (Parcel parcel in ParcelList)
            {
                foreach(Trap trap in TrapList)
                {
                    if (parcel.TrapsChecked == false)
                    { 
                        if(trap.LocationX == parcel.LocationX + 1 && trap.LocationY == parcel.LocationY)
                        {
                            parcel.AdjacentTraps++;
                        }
                        if (trap.LocationX == parcel.LocationX - 1 && trap.LocationY == parcel.LocationY)
                        {
                            parcel.AdjacentTraps++;
                        }
                        if (trap.LocationY == parcel.LocationY + 1 && trap.LocationX == parcel.LocationX)
                        {
                            parcel.AdjacentTraps++;
                        }
                        if (trap.LocationY == parcel.LocationY - 1 & trap.LocationX == parcel.LocationX)
                        {
                            parcel.AdjacentTraps++;
                        }
                        
                        if (trap.LocationX == parcel.LocationX - Settings.Rows + 1 && trap.LocationY == parcel.LocationY)
                        {
                            parcel.AdjacentTraps++;
                        }
                        
                        if (trap.LocationX == parcel.LocationX + Settings.Rows - 1 && trap.LocationY == parcel.LocationY)
                        {
                            parcel.AdjacentTraps++;
                        }
                        
                        if (trap.LocationY == parcel.LocationY - Settings.Columns + 1 && trap.LocationX == parcel.LocationX)
                        {
                            parcel.AdjacentTraps++;
                        }

                        if (trap.LocationY == parcel.LocationY + Settings.Rows - 1 && trap.LocationX == parcel.LocationX)
                        {
                            parcel.AdjacentTraps++;
                        }
                    }  
                }
                parcel.TrapsChecked = true;
            } 
        }

        public Parcel GetParcelByCoordinates(int x, int y) 
        {
            foreach (Parcel parcel in ParcelList)
            {
                if (parcel.LocationX == x && parcel.LocationY == y)
                {
                    return parcel;
                }
            } return null; 
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
                    x = random.Next(0, columns);
                    y = random.Next(0, rows);

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
                EncounterList.AddLast(enemy);
            }
        }

        public void GenerateTraps(int rows, int columns)
        {
            for (int i = 0; i < Settings.TrapAmount; i++)
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
                    x = random.Next(0, columns);
                    y = random.Next(0, rows);
                    
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
                    x = random.Next(0, columns);
                    y = random.Next(0, rows);

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
                EncounterList.AddLast(landmark);
            }
        }

        public void EncounterCheck()
        {
            foreach (Encounter encounter in EncounterList)
            {
                encounter.EncounterCheck(player); 
            }
        }
    }
}
