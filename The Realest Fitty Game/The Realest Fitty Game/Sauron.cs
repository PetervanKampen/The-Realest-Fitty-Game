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
            Charnum = 2;
            enemy = true;
            hp = 200;
            sprite = global::The_Realest_Fitty_Game.Properties.Resources.Sauron;

        }
    }
}
