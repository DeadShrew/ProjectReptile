using ProjectReptile.AbstractClasses;
using System.Reflection;

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
            RemoveItemsFromListBox();
            gameState.EncounterCheck();
            AddParcelItemsToListbox();
            gameState.GenerateParcel(gameState.player.LocationX, gameState.player.LocationY);
            gameState.ParcelTrapProximityCheck();
            this.Refresh();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            RemoveItemsFromListBox();
            gameState.player.MovePlayerUp();
            gameState.GenerateParcel(gameState.player.LocationX, gameState.player.LocationY);
            gameState.ParcelTrapProximityCheck();
            AddParcelItemsToListbox();
            gameState.EncounterCheck();
            this.Refresh();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            RemoveItemsFromListBox();
            gameState.player.MovePlayerDown();
            gameState.GenerateParcel(gameState.player.LocationX, gameState.player.LocationY);
            gameState.ParcelTrapProximityCheck();
            AddParcelItemsToListbox();
            gameState.EncounterCheck();
            this.Refresh();
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            RemoveItemsFromListBox();
            gameState.player.MovePlayerLeft();
            gameState.GenerateParcel(gameState.player.LocationX, gameState.player.LocationY);
            gameState.ParcelTrapProximityCheck();
            AddParcelItemsToListbox();
            gameState.EncounterCheck();
            this.Refresh();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            RemoveItemsFromListBox();
            gameState.player.MovePlayerRight();
            gameState.GenerateParcel(gameState.player.LocationX, gameState.player.LocationY);
            gameState.ParcelTrapProximityCheck();
            AddParcelItemsToListbox();
            gameState.EncounterCheck();
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
        }

        private void TalkButton_Click(object sender, EventArgs e)
        {

        }

        private void GetItemButton_Click(object sender, EventArgs e)
        {
            if (ParcelItemList != null)
            {
                Item item = (Item)ParcelItemList.SelectedItem;

                ParcelItemList.Items.Remove(item);

                gameState.GetParcelByCoordinates(gameState.player.LocationX, gameState.player.LocationY).ItemList.Remove(item);

                gameState.player.ItemList.AddLast(item);

                this.Refresh();
            }
        }

        private void StatsAndInvButton_Click(object sender, EventArgs e)
        {
            /*var statsAndInvForm = StatsAndInvForm.GetInstance();
            statsAndInvForm.StartPosition = FormStartPosition.Manual;
            statsAndInvForm.Location = new System.Drawing.Point(this.Right - 480, this.Top);
            statsAndInvForm.BringToFront();
            statsAndInvForm.ShowDialog();*/

            var statsAndInvForm = new StatsAndInvForm(gameState);
            statsAndInvForm.Show();
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
            foreach (Parcel parcel in gameState.ParcelList)
            {
                if (gameState.player.LocationX == parcel.LocationX && gameState.player.LocationY == parcel.LocationY)
                {
                    foreach (Item item in gameState.GetParcelByCoordinates(gameState.player.LocationX, gameState.player.LocationY).ItemList)
                    {
                        //this is bad and should be replaced with disabling the search button
                        try
                        {
                            ParcelItemList.Items.Add(item);
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }
            }
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
