using ProjectReptile.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile
{
    public class Player : Encounter
    {
        
        Random random = new Random();
        public Player()
        {
            LocationX = random.Next(1, Settings.Columns);
            LocationY = random.Next(1, Settings.Rows);
        }

        public void MovePlayerUp()
        {
            if (LocationY > 0)
            {
                LocationY--;
            }
            else if (LocationY == 0)
            {
                LocationY = Settings.Rows;
            }
        }

        public void MovePlayerDown()
        {
            if (LocationY < Settings.Rows)
            {
                LocationY++;
            }
            else if (LocationY == Settings.Rows)
            {
                LocationY = 0;
            }
        }

        public void MovePlayerLeft()
        {
            if (LocationX > 0)
            {
                LocationX--;
            }
            else if (LocationX == 0)
            {
                LocationX = Settings.Columns;
            }
        }

        public void MovePlayerRight()
        {
            if (LocationX < Settings.Columns)
            {
                LocationX++;
            }
            else if (LocationX == Settings.Columns)
            {
                LocationX = 0; 
            }
        }
    }
}
