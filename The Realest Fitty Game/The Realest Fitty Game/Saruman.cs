﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Realest_Fitty_Game
{
    class Saruman : Character
    {

        public Saruman()
        {
            Name = "Saruman";
            Charnum = 3;
            enemy = true;
            hp = 100;
            maxHP = 100;
            defense = 11;
            rangedAttacks = true;
            sprite = global::The_Realest_Fitty_Game.Properties.Resources.Saruman;

        }
    }
}
