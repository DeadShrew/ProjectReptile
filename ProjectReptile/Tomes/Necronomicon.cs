﻿using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Tomes
{
    class Necronomicon : Tome
    {
        public Necronomicon()
        {
            this.Name = "arcane tome";
            this.TrueName = "Necronomicon";
            this.NonCombative = false;
        }

        public override void CastSorcery(Player player, Enemy enemy)
        {
            enemy.Strength = enemy.Strength - 5;
            GUIOutputManager.PlayerConsoleOutputList.AddLast("You blasted that lil guy"); 
        }
    }
}
