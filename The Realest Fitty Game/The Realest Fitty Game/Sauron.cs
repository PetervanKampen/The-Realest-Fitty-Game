using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Realest_Fitty_Game
{
    class Sauron : Character
    {

        public Sauron()
        {
            Name = "Sauron";
            Charnum = 4;
            enemy = true;
            hp = 200;
            maxHP = 200;
            defense = 18;
            rangedAttacks = false;
            sprite = global::The_Realest_Fitty_Game.Properties.Resources.Sauron;

        }
    }
}
