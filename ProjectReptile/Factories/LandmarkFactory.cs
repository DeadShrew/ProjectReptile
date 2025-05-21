using ProjectReptile.AbstractClasses;
using ProjectReptile.Landmarks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Factories
{
    internal class LandmarkFactory
    {
        public static Landmark CreateLandmark()
        {
            Random random = new Random();

            int landmark = random.Next(1, 17);

            switch (landmark)
            {
                case 1:
                    return new Mausoleum();

                case 2:
                    return new OpenGrave();

                case 3:
                    return new Chest();

                case 4:
                    return new BloodstainedAltar();

                case 5:
                    return new BogShanty();

                case 6:
                    return new CrudeAltar();

                case 7:
                    return new FirePit();

                case 8:
                    return new GarbagePit();

                case 9:
                    return new Grove();

                case 10:
                    return new OccultChest();

                case 11:
                    return new OtherworldlyStatue();

                case 12:
                    return new SeanceTable();

                case 13:
                    return new Shrine();

                case 14:
                    return new WatchTower();

                case 15:
                    return new WaterfallHideout();

                case 16:
                    return new WaterWheel();

            }
            return null;
        }
    }
}
