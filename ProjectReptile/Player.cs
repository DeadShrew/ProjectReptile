using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile
{
    internal class Player
    {
        public static int LocationX; 
        public static int LocationY;

        Random random = new Random();
        public Player()
        {
            LocationX = random.Next(1, 6);
            LocationY = random.Next(1, 6);

        }
    }
}
