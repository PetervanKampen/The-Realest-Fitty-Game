using System;
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
            Charnum = 3;
            enemy = false;
            hp = 90;
            maxHP = 90;
            AD = 11;
            defense = 8;
            passive = " - Elven Insight";
            desription = "Elven Insight: Gain double the amount of actions at the start of each fight.";
            attacks = new String[] { "Dead Eye", "Double Shot", "Knife Strikes" };
            attackUses = new int[] { 2, 2, 5 };
            rangedAttacks = true;
            ranged = true;
            sprite = global::The_Realest_Fitty_Game.Properties.Resources.Legolas;
            portrait = global::The_Realest_Fitty_Game.Properties.Resources.Legolas_Portrait;          
        }
    }
}