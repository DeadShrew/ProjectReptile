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
            g.FillRectangle(myDrawingBrush, 0, 0, GridSize * GameState.rows + Spacing, GridSize * GameState.columns + Spacing);
            for (int i = 0; i < GameState.rows; i++)
            {
                for (int j = 0; j < GameState.columns; j++)
                {
                    if (Player.LocationX == i && Player.LocationY == j)
                    {
                        g.FillRectangle(myDrawingBrush2,Spacing + i * GridSize, Spacing + j * GridSize, GridSize - Spacing, GridSize - Spacing); ;
                    }

                }
            }
        }

    }
}
