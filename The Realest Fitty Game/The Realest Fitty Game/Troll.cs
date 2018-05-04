using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Realest_Fitty_Game
{
    class Troll : Character
    {
        public Troll()
        {
            Name = "Troll";
            Charnum = 2;
            enemy = true;
            hp = 150;
            sprite = global::The_Realest_Fitty_Game.Properties.Resources.Troll;
        }
    }
}
