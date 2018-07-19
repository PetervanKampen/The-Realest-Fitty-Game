using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Realest_Fitty_Game
{
    class Gimli : Character
    {

        public Gimli()
        {
            Name = "Gimli";
            Charnum = 4;
            enemy = false;
            hp = 120;
            maxHP = 120;
            AD = 10;
            defense = 15;
            passive = " - Dwarven Sturdiness";
            desription = "Dwarven Sturdiness: Regain portion of lost HP at the start of each turn.";
            attacks = new String[] { "Dwarven Charge", "Cleaving Strike", "Change Stance" };
            attackUses = new int[] { 2, 2, 99 };
            rangedAttacks = false;
            sprite = global::The_Realest_Fitty_Game.Properties.Resources.Gimli;
            portrait = global::The_Realest_Fitty_Game.Properties.Resources.Gimli_Portrait;
        }
    }
}