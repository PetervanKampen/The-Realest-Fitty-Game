﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Realest_Fitty_Game
{
    class Legolas : Character
    {
        public Legolas()
        {
            Name = "Legolas";
            Charnum = 2;
            enemy = false;
            hp = 90;
            AD = 11;
            defense = 8;
            desription = "Elven Insight: Gain one free turn at the start of each fight.";
            sprite = global::The_Realest_Fitty_Game.Properties.Resources.Legolas;
            portrait = global::The_Realest_Fitty_Game.Properties.Resources.Legolas_Portrait;
        }
    }
}