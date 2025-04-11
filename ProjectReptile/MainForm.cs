using ProjectReptile.AbstractClasses;
using System;
using System.Reflection;
using System.Text;

namespace ProjectReptile
{
    public partial class MainForm : Form
    {
        public GameStateModel gameState;
        static int Spacing = 1;
        static int GridSize = 30;
        public MainForm()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            MapGridPanel, new object[] { true });

            gameState = new GameStateModel();

        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            DisableActionButtons();
            ClearPlayerConsole();
            RemoveItemsFromListBox();
            gameState.EncounterCheck();
            AddParcelItemsToListbox();
            gameState.GenerateParcel(gameState.player.LocationX, gameState.player.LocationY);
            gameState.ParcelTrapProximityCheck();
            EnableActionButtons();
            UpdatePlayerConsole();
            UpdateParcelInfoLabel();
            UpdateEnemyInfoLabelsAndGUI();
            UpdatePlayerInfoLabelsAndGUI();
            this.Refresh();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            DisableActionButtons();
            ClearPlayerConsole();
            RemoveItemsFromListBox();
            gameState.player.MovePlayerUp();
            gameState.GenerateParcel(gameState.player.LocationX, gameState.player.LocationY);
            gameState.ParcelTrapProximityCheck();
            AddParcelItemsToListbox();
            gameState.EncounterCheck();
            EnableActionButtons();
            UpdatePlayerConsole();
            UpdateParcelInfoLabel();
            UpdateEnemyInfoLabelsAndGUI();
            UpdatePlayerInfoLabelsAndGUI();
            this.Refresh();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            DisableActionButtons();
            ClearPlayerConsole();
            RemoveItemsFromListBox();
            gameState.player.MovePlayerDown();
            gameState.GenerateParcel(gameState.player.LocationX, gameState.player.LocationY);
            gameState.ParcelTrapProximityCheck();
            AddParcelItemsToListbox();
            gameState.EncounterCheck();
            EnableActionButtons();
            UpdatePlayerConsole();
            UpdateParcelInfoLabel();
            UpdateEnemyInfoLabelsAndGUI();
            UpdatePlayerInfoLabelsAndGUI();
            this.Refresh();
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            DisableActionButtons();
            ClearPlayerConsole();
            RemoveItemsFromListBox();
            gameState.player.MovePlayerLeft();
            gameState.GenerateParcel(gameState.player.LocationX, gameState.player.LocationY);
            gameState.ParcelTrapProximityCheck();
            AddParcelItemsToListbox();
            gameState.EncounterCheck();
            EnableActionButtons();
            UpdatePlayerConsole();
            UpdateParcelInfoLabel();
            UpdateEnemyInfoLabelsAndGUI();
            UpdatePlayerInfoLabelsAndGUI();
            this.Refresh();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            DisableActionButtons();
            ClearPlayerConsole();
            RemoveItemsFromListBox();
            gameState.player.MovePlayerRight();
            gameState.GenerateParcel(gameState.player.LocationX, gameState.player.LocationY);
            gameState.ParcelTrapProximityCheck();
            AddParcelItemsToListbox();
            gameState.EncounterCheck();
            EnableActionButtons();
            UpdatePlayerConsole();
            UpdateParcelInfoLabel();
            UpdateEnemyInfoLabelsAndGUI();
            UpdatePlayerInfoLabelsAndGUI();
            this.Refresh();
        }

        private void FleeButton_Click(object sender, EventArgs e)
        {

        }

        private void AttackButton_Click(object sender, EventArgs e)
        {

        }

        private void DefendButton_Click(object sender, EventArgs e)
        {

        }

        private void SorceryButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            gameState.SearchLandmarks();
            AddParcelItemsToListbox();
            UpdateParcelInfoLabel();
            UpdatePlayerConsole();
        }

        private void TalkButton_Click(object sender, EventArgs e)
        {

        }

        private void GetItemButton_Click(object sender, EventArgs e)
        {
            if (ParcelItemList.SelectedItem != null)
            {
                Item item = (Item)ParcelItemList.SelectedItem;

                ParcelItemList.Items.Remove(item);

                gameState.GetParcelByCoordinates(gameState.player.LocationX, gameState.player.LocationY).ItemList.Remove(item);               

                gameState.player.ItemList.AddLast(item);

                GUIOutputManager.PlayerConsoleOutputList.AddLast("You have picked up a " + item.Name + ".");

                UpdatePlayerConsole(); 

                this.Refresh();
            } 
        }

        private void StatsAndInvButton_Click(object sender, EventArgs e)
        {
            var statsAndInvForm = new StatsAndInvForm(gameState);
            statsAndInvForm.Show();
        }

        private void DisableActionButtons()
        {
            AttackButton.Enabled = false;
            DefendButton.Enabled = false;
            SorceryButton.Enabled = false;
            TalkButton.Enabled = false;
            SearchButton.Enabled = false;
            FleeButton.Enabled = false;
        }

        private void EnableActionButtons()
        {
            foreach (Enemy enemy in gameState.EnemyList)
            {
                if (enemy.LocationX == gameState.player.LocationX && enemy.LocationY == gameState.player.LocationY && enemy.IsAlive == true)
                {
                    AttackButton.Enabled = true;
                }
            }

            foreach (Enemy enemy in gameState.EnemyList)
            {
                if (enemy.LocationX == gameState.player.LocationX && enemy.LocationY == gameState.player.LocationY
                    && enemy.IsAlive == true && enemy.IsIntelligent == true && enemy.IsNegotiable == true)
                {
                    TalkButton.Enabled = true;
                }
            }

            foreach (Landmark landmark in gameState.LandmarkList)
            {
                if (landmark.LocationX == gameState.player.LocationX && landmark.LocationY == gameState.player.LocationY && landmark.Searched == false)
                {
                    SearchButton.Enabled = true;
                }
            }
        }

        private void RemoveItemsFromListBox()
        {
            for (int i = 0; i < ParcelItemList.Items.Count; i++)
            {
                ParcelItemList.Items.RemoveAt(i);
            }
        }

        private void AddParcelItemsToListbox()
        {
            Item itemToRemove;

            foreach (Parcel parcel in gameState.ParcelList)
            {
                if (gameState.player.LocationX == parcel.LocationX && gameState.player.LocationY == parcel.LocationY)
                {
                    foreach (Item item in gameState.GetParcelByCoordinates(gameState.player.LocationX, gameState.player.LocationY).ItemList)
                    {
                        try
                        {
                            ParcelItemList.Items.Add(item);
                            SearchButton.Enabled = false;
                        }
                        catch (Exception ex)
                        {        
                            
                        }
                    }
                } 
            }
        }

        private void UpdatePlayerInfoLabelsAndGUI()
        {
            DirectionAndCoordinatesLabel.Text = "Moved Dir: " + gameState.player.MovedDir + " Curr Loc C: " + gameState.player.LocationX + " R: " + gameState.player.LocationY;  
            PlayerStrengthLabel.Text = "Player Strength: " + gameState.player.Strength;
            PlayerGoldLabel.Text = "Player Gold: " + gameState.player.Gold;
            PlayerThreatLabel.Text = "Player PV: "; 

            PlayerThreatLabel.Text = "Player PV: " + (gameState.player.Strength +
                                                    gameState.player.Power +
                                                    gameState.player.Armor +
                                                    gameState.player.Dexterity).ToString();
        }

        private void UpdateParcelInfoLabel()
        {
            ParcelInfoLabel.Text = gameState.GetParcelByCoordinates(gameState.player.LocationX, gameState.player.LocationY).Description; 
            if (gameState.GetParcelByCoordinates(gameState.player.LocationX, gameState.player.LocationY).LandmarkDescription != null )
            {
                ParcelInfoLabel.Text += gameState.GetParcelByCoordinates(gameState.player.LocationX, gameState.player.LocationY).LandmarkDescription;
            }
        }

        private void UpdateEnemyInfoLabelsAndGUI()
        {
            EnemyInfoLabel.Text = "";
            EnemyStrengthLabel.Text = "Enemy Strength: ";
            EnemyThreatLabel.Text = "Enemy PV: "; 

            if (gameState.GetParcelByCoordinates(gameState.player.LocationX, gameState.player.LocationY).EnemyDescription != null)
            {
                EnemyInfoLabel.Text += gameState.GetParcelByCoordinates(gameState.player.LocationX, gameState.player.LocationY).EnemyDescription;

                if (gameState.GetEnemyByCoordinates(gameState.player.LocationX, gameState.player.LocationY).equippedWeapon != null)
                {
                    EnemyInfoLabel.Text += " It has a " + gameState.GetEnemyByCoordinates(gameState.player.LocationX, gameState.player.LocationY).equippedWeapon;
                }

                if (gameState.GetEnemyByCoordinates(gameState.player.LocationX, gameState.player.LocationY).equippedShield != null)
                {
                    EnemyInfoLabel.Text += ", " + gameState.GetEnemyByCoordinates(gameState.player.LocationX, gameState.player.LocationY).equippedShield;
                }

                if (gameState.GetEnemyByCoordinates(gameState.player.LocationX, gameState.player.LocationY).equippedArmour != null)
                {
                    EnemyInfoLabel.Text += ", " + gameState.GetEnemyByCoordinates(gameState.player.LocationX, gameState.player.LocationY).equippedArmour;

                }

                if (gameState.GetEnemyByCoordinates(gameState.player.LocationX, gameState.player.LocationY).equippedWeapon != null ||
                       gameState.GetEnemyByCoordinates(gameState.player.LocationX, gameState.player.LocationY).equippedShield != null ||
                       gameState.GetEnemyByCoordinates(gameState.player.LocationX, gameState.player.LocationY).equippedArmour != null)
                {
                    EnemyInfoLabel.Text += ".";
                }

                EnemyStrengthLabel.Text = "Enemy Strength: " + gameState.GetEnemyByCoordinates(gameState.player.LocationX, gameState.player.LocationY).Strength.ToString();

                EnemyThreatLabel.Text = "Enemy PV: " + (gameState.GetEnemyByCoordinates(gameState.player.LocationX, gameState.player.LocationY).Strength +
                                                              gameState.GetEnemyByCoordinates(gameState.player.LocationX, gameState.player.LocationY).Power +
                                                              gameState.GetEnemyByCoordinates(gameState.player.LocationX, gameState.player.LocationY).Armor +
                                                              gameState.GetEnemyByCoordinates(gameState.player.LocationX, gameState.player.LocationY).Dexterity).ToString();

            }
        }


        private void UpdatePlayerConsole()
        {
            PlayerConsoleTextBox.Clear();

            StringBuilder consoleText = new StringBuilder();

            foreach (string message in GUIOutputManager.PlayerConsoleOutputList)
            {
                consoleText.AppendLine(message);
            }

            PlayerConsoleTextBox.Text = consoleText.ToString();
        }

        private void ClearPlayerConsole()
        {
            GUIOutputManager.PlayerConsoleOutputList.Clear();
            PlayerConsoleTextBox?.Clear();
        }

        private void MapGridPanel_Paint(object sender, PaintEventArgs e)
        {
            {
                Graphics g = e.Graphics;
                Brush myDrawingBrush = new SolidBrush(Color.Chocolate);
                Brush myDrawingBrush2 = new SolidBrush(Color.DarkGreen);
                Brush myDrawingBrush3 = new SolidBrush(Color.Brown);
                Brush myDrawingBrush4 = new SolidBrush(Color.DarkRed);
                Brush myDrawingBrush5 = new SolidBrush(Color.Black);
                Font drawFont = new Font("Arial", 16);
                g.FillRectangle(myDrawingBrush, 0, 0, GridSize * (gameState.columns) + Spacing, GridSize * (gameState.rows) + Spacing);
                for (int i = 0; i < gameState.columns; i++)
                {
                    for (int j = 0; j < gameState.rows; j++)
                    {
                        if (gameState.player.LocationX == i && gameState.player.LocationY == j && !gameState.TrapList.Any(o => o.LocationX == i && o.LocationY == j))
                        {
                            g.FillRectangle(myDrawingBrush2, Spacing + i * GridSize, Spacing + j * GridSize, GridSize - Spacing, GridSize - Spacing);

                        }
                        else if (gameState.ParcelList.Any(o => o.LocationX == i && o.LocationY == j) && !gameState.TrapList.Any(o => o.LocationX == i && o.LocationY == j))
                        {
                            g.FillRectangle(myDrawingBrush3, Spacing + i * GridSize, Spacing + j * GridSize, GridSize - Spacing, GridSize - Spacing);
                        }
                        else if (gameState.TrapList.Any(o => o.LocationX == i && o.LocationY == j) &&
                            (gameState.ParcelList.Any(o => o.LocationX == i && o.LocationY == j) || (gameState.player.LocationX == i && gameState.player.LocationY == j)))
                        {
                            g.FillRectangle(myDrawingBrush4, Spacing + i * GridSize, Spacing + j * GridSize, GridSize - Spacing, GridSize - Spacing);
                        }

                        for (int n = 0; n < gameState.columns; n++)
                        {
                            for (int m = 0; m < gameState.rows; m++)
                            {
                                if (gameState.ParcelList.Any(o => o.LocationX == n && o.LocationY == m))
                                {
                                    g.DrawString(gameState.GetParcelByCoordinates(n, m).AdjacentTraps.ToString(), drawFont, myDrawingBrush, n * GridSize + 5, m * GridSize + 5);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
