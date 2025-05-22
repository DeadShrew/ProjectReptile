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
        public Item item;

        public Landmark()
        {            
        }

        public override void EncounterCheck(Player player)
        {
        }

        public Item? SearchLandmark()
        {
            if (Searched == false) {            

                Searched = true;
                GUIOutputManager.PlayerConsoleOutputList.AddLast("A " +  item.Name + " is here.");

                return item;
            }
            return null; 
        }
    }
}

