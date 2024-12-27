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
            Brush myDrawingBrush = new SolidBrush(Color.Chocolate);
            Brush myDrawingBrush2 = new SolidBrush(Color.DarkGreen);
            Brush myDrawingBrush3 = new SolidBrush(Color.Brown);
            Font drawFont = new Font("Arial", 16);
            g.FillRectangle(myDrawingBrush, 0, 0, GridSize * (gameState.rows + 1) + Spacing, GridSize * (gameState.columns + 1) + Spacing);
            for (int i = 0; i < gameState.rows + 1; i++)
            {
                for (int j = 0; j < gameState.columns + 1; j++)
                {
                    if (gameState.player.LocationX == i && gameState.player.LocationY == j)
                    {
                        g.FillRectangle(myDrawingBrush2, Spacing + i * GridSize, Spacing + j * GridSize, GridSize - Spacing, GridSize - Spacing);

                    } else if (gameState.ParcelList.Select(o => o.LocationX).Contains(i) && gameState.ParcelList.Select(o => o.LocationY).Contains(j))
                     
                    {
                        g.FillRectangle(myDrawingBrush3, Spacing + i * GridSize, Spacing + j * GridSize, GridSize - Spacing, GridSize - Spacing);
                    }

                    /*for (int n = 0; n < gameState.rows; n++)
                    {
                        for (int m = 0; m < gameState.columns; m++)
                        {
                            if (gameState.player.LocationX == i && gameState.player.LocationX == j)
                            {
                                g.DrawString("0", drawFont, myDrawingBrush, n * GridSize + 10, m * GridSize + 10);
                            }
                        }
                    }*/

                }
            }
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            gameState.EncounterCheck();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameState.player.MovePlayerUp(); 
            gameState.EncounterCheck();
            this.Refresh();
            Console.WriteLine("My location is " + gameState.player.LocationY + ", " + gameState.player.LocationX); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameState.player.MovePlayerDown();
            gameState.EncounterCheck();
            this.Refresh();
            Console.WriteLine("My location is " + gameState.player.LocationY + ", " + gameState.player.LocationX);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gameState.player.MovePlayerLeft();
            gameState.EncounterCheck();
            this.Refresh();
            Console.WriteLine("My location is " + gameState.player.LocationY + ", " + gameState.player.LocationX);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gameState.player.MovePlayerRight();
            gameState.EncounterCheck();
            this.Refresh();
            Console.WriteLine("My location is " + gameState.player.LocationY + ", " + gameState.player.LocationX);
        }
    }
}
