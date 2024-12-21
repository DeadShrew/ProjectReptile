using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Interfaces
{
    internal interface IEnemy
    {
        void SetEnemyLocation(int x, int y);

        Tuple<int, int> GetEnemyLocation();
    }
}
