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
            Charnum = 2;
            enemy = false;
            hp = 90;
            desription = "The prince of the elven kingdom of Mirkwood, wielding a bow with deadeye accuracy.";
            sprite = global::The_Realest_Fitty_Game.Properties.Resources.Legolas;
            portrait = global::The_Realest_Fitty_Game.Properties.Resources.Legolas_Portrait;
        }
    }
}