using ProjectReptile.AbstractClasses;
using ProjectReptile.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile
{
    public class Player 
    {
        public int LocationX;
        public int LocationY;
        public int Strength = 14;
        public int Power = 1;
        public int Armor = 1;
        public int Dexterity = 2; 
        public int Gold = 10;
        public bool InCombat;
        public bool AtLandmark;
        public string MovedDir;
        

        public LinkedList<Item> ItemList;

        Random random = new Random();
        public Player()
        {
            LocationX = random.Next(0, Settings.Columns);
            LocationY = random.Next(0, Settings.Rows);
            ItemList = new LinkedList<Item>();

            //Test Item
            ItemList.AddLast(new Potion());
        }

        public void MovePlayerUp()
        {
            MovedDir = "N";

            if (LocationY > 0)
            {
                LocationY--;
            }
            else if (LocationY == 0)
            {
                LocationY = Settings.Rows -1;
            }
        }

        public void MovePlayerDown()
        {
            MovedDir = "S";

            if (LocationY < Settings.Rows -1)
            {
                LocationY++;
            }
            else if (LocationY == Settings.Rows - 1)
            {
                LocationY = 0;
            }
        }

        public void MovePlayerLeft()
        {
            MovedDir = "W";

            if (LocationX > 0)
            {
                LocationX--;
            }
            else if (LocationX == 0)
            {
                LocationX = Settings.Columns -1;
            }
        }

        public void MovePlayerRight()
        {
            MovedDir = "E";  

            if (LocationX < Settings.Columns - 1)
            {
                LocationX++;
            }
            else if (LocationX >= Settings.Columns - 1)
            {
                LocationX = 0; 
            }
        }
    }
}
