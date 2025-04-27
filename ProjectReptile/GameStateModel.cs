using ProjectReptile.AbstractClasses;
using ProjectReptile.Factories;
using ProjectReptile.GameObjects;
using System.Windows.Forms;

namespace ProjectReptile
{
    public class GameStateModel
    {
        public int rows = Settings.Rows;
        public int columns  = Settings.Columns;

        public Player player; 

        public LinkedList<Encounter> EncounterList = new LinkedList<Encounter>();
        public LinkedList<Enemy> EnemyList = new LinkedList<Enemy>();
        public LinkedList<Parcel> ParcelList = new LinkedList<Parcel>();
        public LinkedList<Trap> TrapList = new LinkedList<Trap>();
        public LinkedList<Landmark>LandmarkList = new LinkedList<Landmark>();

        public static List<string> ParcelDescriptionsList = new List<string>();

        Random random = new Random();

        public GameStateModel()
        {
            InitializeParcelDescriptions(); 
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
                var description = ParcelDescriptionsList[random.Next(0, ParcelDescriptionsList.Count)];
                ParcelDescriptionsList.Remove(description);
                parcel.Description = description;
                
                foreach(Landmark landmark in LandmarkList)
                {
                    if (landmark.LocationX == x && landmark.LocationY == y)
                    {
                        parcel.LandmarkDescription = " A " + landmark.Name + " is here.";
                    }
                }

                foreach (Enemy enemy in EnemyList)
                {
                    if (enemy.LocationX == x && enemy.LocationY == y)
                    {
                        parcel.EnemyDescription = " A " + enemy.Name + " is here.";
                    }
                }

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

        public Enemy GetEnemyByCoordinates(int x, int y)
        {
            foreach (Enemy enemy in EnemyList)
            {
                if (enemy.LocationX == x && enemy.LocationY == y)
                {
                    return enemy;
                }
            }
            return null;
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
            int monsterAmount = random.Next(10, 20);

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

        public void SearchLandmarks()
        {
            foreach (Landmark landmark in LandmarkList) {
                
               foreach (Parcel parcel in ParcelList)
                {
                    if (parcel.LocationX == landmark.LocationX && parcel.LocationY == landmark.LocationY 
                        && player.LocationX == landmark.LocationX && player.LocationY == landmark.LocationY)
                    {
                        parcel.ItemList.AddLast(landmark.SearchLandmark());
                        parcel.LandmarkDescription = " A searched " + landmark.Name + " is here.";
                    }
                }
            }
        }

        private void InitializeParcelDescriptions()
        {
            for (int i = 0; i < 4; i++)
            {
                ParcelDescriptionsList.Add("You are in a room with strange symbols on the walls.");
                ParcelDescriptionsList.Add("You are in a hallway of roughly hewn stone.");
                ParcelDescriptionsList.Add("You are in a hallway of fitted stone.");
                ParcelDescriptionsList.Add("You are in a room with a smooth stone floor and walls. ");
                ParcelDescriptionsList.Add("You are in a room with grotesque murals on the walls.");

                ParcelDescriptionsList.Add("You are in a room with a low ceiling.");
                ParcelDescriptionsList.Add("You are in a room with walls and floors of fitted stone.");
                ParcelDescriptionsList.Add("You are in a hallway with a inlaid pattern on the floor.");
                ParcelDescriptionsList.Add("You are in a room colored in a checker pattern.");
                ParcelDescriptionsList.Add("You are in a room with rubble covering the floor.");

                ParcelDescriptionsList.Add("You are in a room with a high, domed ceiling. ");
                ParcelDescriptionsList.Add("You are in a room with a misty haze in it.");
                ParcelDescriptionsList.Add("You are in a corridor which twists and winds.");
                ParcelDescriptionsList.Add("You are in a corridor of narrow width and a low roof.");
                ParcelDescriptionsList.Add("You are in a cavern with a light breeze blowing.");

                ParcelDescriptionsList.Add("You are in a room with many stone pillars.");
                ParcelDescriptionsList.Add("You are in a strangely shaped room of weird dimensions. ");
                ParcelDescriptionsList.Add("You are in a room with many mirrors.");
                ParcelDescriptionsList.Add("You are in a room with patches of glowing fungi.");
                ParcelDescriptionsList.Add("You are in a cavern with many stalactites and stalagmites.");

                ParcelDescriptionsList.Add("You are in a room with a polished marble floor and pillars.");
                ParcelDescriptionsList.Add("You are in a room full of cobwebs and dust.");
                ParcelDescriptionsList.Add("You are in a room with elaborate wood paneling.");
                ParcelDescriptionsList.Add("You are in a room with many nooks and crannies.");
                ParcelDescriptionsList.Add("You are in a cavern with glimmering minerals in the walls.");
            }
        }

        public void AttackEnemyOffensively()
        {
            Enemy enemy = GetEnemyByCoordinates(player.LocationX, player.LocationY);

            int playerInitiativeRoll = random.Next(1, player.Dexterity + 1);
            int enemyInitiativeRoll = random.Next(1, enemy.Dexterity + 1);

            if (playerInitiativeRoll >= enemyInitiativeRoll)
            {
                PlayerOffensiveAttack(enemy);

                if (enemy.Strength > 0)
                    EnemyAttack(enemy);
            }
            else
            {
                EnemyAttack(enemy);

                if (enemy.Strength > 0)
                    PlayerOffensiveAttack(enemy);
            }

        }

        public void AttackEnemyDefensively()
        {
            Enemy enemy = GetEnemyByCoordinates(player.LocationX, player.LocationY);

            int playerInitiativeRoll = random.Next(1, player.Dexterity + 1);
            int enemyInitiativeRoll = random.Next(1, enemy.Dexterity + 1);

            if (playerInitiativeRoll >= enemyInitiativeRoll)
            {
                PlayerDefensiveAttack(enemy);

                if (enemy.Strength > 0)
                    BlockedEnemyAttack(enemy);
            }
            else
            {
                BlockedEnemyAttack(enemy);

                if (enemy.Strength > 0)
                    PlayerDefensiveAttack(enemy);
            }
        }

        public void PlayerOffensiveAttack(Enemy enemy)
        {
            int diceRoll = random.Next(1, 7);
            int damageRoll = random.Next(1, (int)(player.Strength * 0.666 + player.Power) + 1);

            if (diceRoll > 1 && diceRoll < 6)
            {
                enemy.Strength -= Math.Max(0, damageRoll - enemy.Armor);
                GUIOutputManager.PlayerConsoleOutputList.AddLast("You have hit the " + enemy.Name + " for " + Math.Max(0, damageRoll - enemy.Armor) + " point(s).");
            } else if (diceRoll > 5)
            {
                enemy.Strength -= damageRoll;
                GUIOutputManager.PlayerConsoleOutputList.AddLast("CRITICAL HIT! You have hit the " + enemy.Name + " for " + damageRoll + " point(s).");
            } else if (diceRoll < 2)
            {
                GUIOutputManager.PlayerConsoleOutputList.AddLast("You missed the " + enemy.Name + " with your " + player.equippedWeapon.Name + ".");
            }
        }

        public void PlayerDefensiveAttack(Enemy enemy)
        {
            int diceRoll = random.Next(1, 7);
            int damageRoll = random.Next(1, (int)(player.Strength * 0.333 + player.Power) + 1);

            if (diceRoll > 1 && diceRoll < 6)
            {
                enemy.Strength -= Math.Max(0, damageRoll - enemy.Armor);
                GUIOutputManager.PlayerConsoleOutputList.AddLast("You have hit the " + enemy.Name + " for " + Math.Max(0, damageRoll - enemy.Armor) + " point(s).");
            }
            else if (diceRoll > 5)
            {
                enemy.Strength -= damageRoll;
                GUIOutputManager.PlayerConsoleOutputList.AddLast("CRITICAL HIT! You have hit the " + enemy.Name + " for " + damageRoll + " point(s).");
            }
            else if (diceRoll < 2)
            {
                GUIOutputManager.PlayerConsoleOutputList.AddLast("You missed the " + enemy.Name + " with your " + player.equippedWeapon.Name + ".");
            }
        }

        public void EnemyAttack(Enemy enemy)
        {
            int diceRoll = random.Next(1, 7);
            int damageRoll = random.Next(1, (int)(enemy.Strength * 0.666 + enemy.Power) + 1);

            if (diceRoll > 1 && diceRoll < 6)
            {
                player.Strength -= Math.Max(0, damageRoll - player.Armor);
                GUIOutputManager.PlayerConsoleOutputList.AddLast("The " + enemy.Name + " hit you for " + Math.Max(0, damageRoll - player.Armor) + " point(s).");
            }
            else if (diceRoll > 5)
            {
                player.Strength -= damageRoll;
                GUIOutputManager.PlayerConsoleOutputList.AddLast("CRITICAL HIT! The " + enemy.Name + " hit you for " + damageRoll + " point(s)."); ;
            }
            else if (diceRoll < 2)
            {
                GUIOutputManager.PlayerConsoleOutputList.AddLast("The " + enemy.Name + " missed you with its attack.");
            }
        }

        public void BlockedEnemyAttack(Enemy enemy)
        {
            int diceRoll = random.Next(1, 7);
            int damageRoll = random.Next(1, (int)(enemy.Strength * 0.666 + enemy.Power) + 1);

            if (diceRoll > 4 && diceRoll < 6)
            {
                player.Strength -= Math.Max(0, damageRoll - player.Armor);
                GUIOutputManager.PlayerConsoleOutputList.AddLast("The " + enemy.Name + " hit you for " + Math.Max(0, damageRoll - player.Armor) + " point(s).");
            }
            else if (diceRoll > 5)
            {
                player.Strength -= damageRoll;
                GUIOutputManager.PlayerConsoleOutputList.AddLast("CRITICAL HIT! The " + enemy.Name + " hit you for " + damageRoll + " point(s)."); ;
            }
            else if (diceRoll < 4)
            {
                GUIOutputManager.PlayerConsoleOutputList.AddLast("The " + enemy.Name + " missed you with its attack.");
            }
        }

        public void FleeAttempt()
        {
            int diceRoll = random.Next(1, 7);

            if (diceRoll > 2)
            {
                player.InCombat = false;
                GUIOutputManager.PlayerConsoleOutputList.AddLast("You have escaped."); 
            } else if (diceRoll <= 2)
            {
                GUIOutputManager.PlayerConsoleOutputList.AddLast("You have not escaped.");
                EnemyAttack(GetEnemyByCoordinates(player.LocationX, player.LocationY)); 
            }
        }

        public void EnemyDeathCheck()
        {
            Enemy enemy = GetEnemyByCoordinates(player.LocationX, player.LocationY);
            Parcel parcel = GetParcelByCoordinates(player.LocationX, player.LocationY);

            if (enemy.Strength <= 0) 
            {
                enemy.Strength = 0;
                enemy.IsAlive = false;
                parcel.EnemyDescription = "A dead " + enemy.Name + " is here";
                
                if (enemy.equippedWeapon != null)
                {
                    parcel.ItemList.AddLast(enemy.equippedWeapon);
                }

                if (enemy.equippedArmour != null)
                {
                    parcel.ItemList.AddLast(enemy.equippedArmour);
                }

                if (enemy.equippedShield != null)
                {
                    parcel.ItemList.AddLast(enemy.equippedShield);
                }
            }
        }

        public void PlayerDeathCheck()
        {
            if (player.Strength <= 0)
            {
                player.Strength = 0;
                var defeatForm = new DefeatForm();
                defeatForm.Show();
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
