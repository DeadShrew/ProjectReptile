using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms; 

namespace ProjectReptile
{
    public partial class ViewForm : Form
    {
        private GameStateModel gameState;
        static int Spacing = 2;
        static int GridSize = 37;
        public ViewForm()
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
            g.FillRectangle(myDrawingBrush, 0, 0, GridSize * (gameState.rows) + Spacing, GridSize * (gameState.columns) + Spacing);
            for (int i = 0; i < gameState.rows; i++)
            {
                for (int j = 0; j < gameState.columns; j++)
                {
                    if (gameState.player.LocationX == i && gameState.player.LocationY == j && !gameState.TrapList.Any(o => o.LocationX == i && o.LocationY == j))
                    {
                        g.FillRectangle(myDrawingBrush2, Spacing + i * GridSize, Spacing + j * GridSize, GridSize - Spacing, GridSize - Spacing);

                    } else if (gameState.ParcelList.Any(o => o.LocationX == i && o.LocationY == j) && !gameState.TrapList.Any(o => o.LocationX == i && o.LocationY == j))
                    {
                        g.FillRectangle(myDrawingBrush3, Spacing + i * GridSize, Spacing + j * GridSize, GridSize - Spacing, GridSize - Spacing); 
                    } else if (gameState.TrapList.Any(o => o.LocationX == i && o.LocationY == j) && 
                        (gameState.ParcelList.Any(o => o.LocationX == i && o.LocationY == j) || (gameState.player.LocationX == i && gameState.player.LocationY == j)))
                    {
                        g.FillRectangle(myDrawingBrush4, Spacing + i * GridSize, Spacing + j * GridSize, GridSize - Spacing, GridSize - Spacing);
                    }

                    for (int n = 0; n < gameState.rows; n++)
                    {
                        for (int m = 0; m < gameState.columns; m++)
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

        private void button1_Click(object sender, EventArgs e)
        {
            gameState.player.MovePlayerUp();
            gameState.GenerateParcel(gameState.player.LocationX, gameState.player.LocationY);
            gameState.ParcelTrapProximityCheck();
            gameState.EncounterCheck();
            
            this.Refresh();
            //Console.WriteLine("My location is " + gameState.player.LocationY + ", " + gameState.player.LocationX); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameState.player.MovePlayerDown();
            gameState.GenerateParcel(gameState.player.LocationX, gameState.player.LocationY);
            gameState.ParcelTrapProximityCheck();
            gameState.EncounterCheck();
            this.Refresh();
            //Console.WriteLine("My location is " + gameState.player.LocationY + ", " + gameState.player.LocationX);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gameState.player.MovePlayerLeft();
            gameState.GenerateParcel(gameState.player.LocationX, gameState.player.LocationY);
            gameState.ParcelTrapProximityCheck();
            gameState.EncounterCheck();
            this.Refresh();
            //Console.WriteLine("My location is " + gameState.player.LocationY + ", " + gameState.player.LocationX);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gameState.player.MovePlayerRight();
            gameState.GenerateParcel(gameState.player.LocationX, gameState.player.LocationY);
            gameState.ParcelTrapProximityCheck();
            gameState.EncounterCheck();
            this.Refresh();
            //Console.WriteLine("My location is " + gameState.player.LocationY + ", " + gameState.player.LocationX);
        }
    }
}
