using ProjectReptile.Factories;
using ProjectReptile.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.AbstractClasses
{
    public abstract class Landmark : Encounter
    {
        public Image landmarkIcon;

        public string ?Name;
        public bool Searched;
        public string ParcelInfoText; 

        public override void EncounterCheck(Player player)
        {
            if (player.LocationX == this.LocationX && player.LocationY == this.LocationY)
            {
                //Console.WriteLine("The player has encountered a " + this.Name);
            }
        }

        public Item? SearchLandmark()
        {
            if (Searched == false) {

                Item item = ItemFactory.CreateItem();

                Searched = true;
                GUIOutputManager.PlayerConsoleOutputList.AddLast("A " +  item.Name + " is here.");

                return item;
            }
            return null; 
        }
    }
}

