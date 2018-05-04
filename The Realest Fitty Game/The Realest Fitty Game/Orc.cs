using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Realest_Fitty_Game
{
    class Orc : Character
    {
        public Orc()
        {
            Name = "Orc";
            Charnum = 0;
            enemy = true;
            hp = 50;
            sprite = global::The_Realest_Fitty_Game.Properties.Resources.Orc;
        }
    }
}
