using System;
using System.Windows.Forms; 

namespace ProjectReptile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int Spacing = 2;
        static int GridSize = 37;

        private void MapGrid(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush myDrawingBrush = new SolidBrush(Color.Cyan);
            Brush myDrawingBrush2 = new SolidBrush(Color.Bisque);
            g.FillRectangle(myDrawingBrush, 0, 0, GridSize * (GameState.rows + 1) + Spacing, GridSize * (GameState.columns + 1) + Spacing);
            for (int i = 0; i < GameState.rows + 1; i++)
            {
                for (int j = 0; j < GameState.columns + 1; j++)
                {
                    if (Player.LocationX == i && Player.LocationY == j)
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
            Player.MovePlayerUp();
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player.MovePlayerDown();
            this.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Player.MovePlayerLeft();
            this.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Player.MovePlayerRight();
            this.Refresh();
        }
    }
}
