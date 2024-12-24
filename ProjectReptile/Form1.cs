using System;
using System.Windows.Forms; 

namespace ProjectReptile
{
    public partial class Form1 : Form
    {

        private Player player;
        private GameState gameState;
        static int Spacing = 2;
        static int GridSize = 37;
        public Form1()
        {
            InitializeComponent();
            player = new Player();
            gameState = new GameState();
        }

        

        private void MapGrid(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush myDrawingBrush = new SolidBrush(Color.Cyan);
            Brush myDrawingBrush2 = new SolidBrush(Color.Bisque);
            g.FillRectangle(myDrawingBrush, 0, 0, GridSize * (gameState.rows + 1) + Spacing, GridSize * (gameState.columns + 1) + Spacing);
            for (int i = 0; i < gameState.rows + 1; i++)
            {
                for (int j = 0; j < gameState.columns + 1; j++)
                {
                    if (player.LocationX == i && player.LocationY == j)
                    {
                        g.FillRectangle(myDrawingBrush2, Spacing + i * GridSize, Spacing + j * GridSize, GridSize - Spacing, GridSize - Spacing); ;
                    }

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.MovePlayerUp(); 
            this.Refresh();
            Console.WriteLine("My location is " + player.LocationY + ", " + player.LocationX); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.MovePlayerDown();
            this.Refresh();
            Console.WriteLine("My location is " + player.LocationY + ", " + player.LocationX);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.MovePlayerLeft();
            this.Refresh();
            Console.WriteLine("My location is " + player.LocationY + ", " + player.LocationX);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player.MovePlayerRight();
            this.Refresh();
            Console.WriteLine("My location is " + player.LocationY + ", " + player.LocationX);
        }
    }
}
