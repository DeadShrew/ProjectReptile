namespace ProjectReptile
{
    public partial class MainForm : Form
    {
        private GameStateModel gameState;
        static int Spacing = 2;
        static int GridSize = 37;
        public MainForm()
        {
            InitializeComponent();

            gameState = new GameStateModel();
        }


        private void MapGrid(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color color = Color.Chocolate;
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
                                g.DrawString(gameState.GetParcelByCoordinates(n, m).AdjacentTraps.ToString(), drawFont, myDrawingBrush, n * GridSize + 10, m * GridSize + 8);
                            }
                        }
                    }
                }
            }
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            gameState.EncounterCheck();
            gameState.GenerateParcel(gameState.player.LocationX, gameState.player.LocationY);
            gameState.ParcelTrapProximityCheck();
            this.Refresh();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            gameState.player.MovePlayerUp();
            gameState.GenerateParcel(gameState.player.LocationX, gameState.player.LocationY);
            gameState.ParcelTrapProximityCheck();
            gameState.EncounterCheck();

            this.Refresh();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            gameState.player.MovePlayerDown();
            gameState.GenerateParcel(gameState.player.LocationX, gameState.player.LocationY);
            gameState.ParcelTrapProximityCheck();
            gameState.EncounterCheck();
            this.Refresh();
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            gameState.player.MovePlayerLeft();
            gameState.GenerateParcel(gameState.player.LocationX, gameState.player.LocationY);
            gameState.ParcelTrapProximityCheck();
            gameState.EncounterCheck();
            this.Refresh();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            gameState.player.MovePlayerRight();
            gameState.GenerateParcel(gameState.player.LocationX, gameState.player.LocationY);
            gameState.ParcelTrapProximityCheck();
            gameState.EncounterCheck();
            this.Refresh();
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

        }

        private void TalkButton_Click(object sender, EventArgs e)
        {

        }

        private void GetItemButton_Click(object sender, EventArgs e)
        {

        }

        private void StatsAndInvButton_Click(object sender, EventArgs e)
        {
            var statsAndInvForm = StatsAndInvForm.GetInstance(); 
            statsAndInvForm.BringToFront();
            statsAndInvForm.ShowDialog();
        }
    }
}
