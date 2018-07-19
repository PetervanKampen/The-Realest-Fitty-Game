using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Realest_Fitty_Game
{
    class Gandalf : Character
    {

        public Gandalf()
        {
            Name = "Gandalf";
            Charnum = 1;
            enemy = false;
            hp = 100;
            maxHP = 100;
            AD = 12;
            defense = 10;
            passive = " - Spell Flux";
            desription = "Spell Flux: Regain Spell Uses after each succesful fight.";
            attacks = new String[] { "Silencing Voice", "Wizard Blast", "Healing Whispers" };
            attackUses = new int[] { 2, 2, 2 };
            rangedAttacks = false;
            sprite = global::The_Realest_Fitty_Game.Properties.Resources.Gandalf;
            portrait = global::The_Realest_Fitty_Game.Properties.Resources.Gandalf_Portrait;
        }
    }
}
