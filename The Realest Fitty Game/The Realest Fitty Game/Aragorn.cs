using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Realest_Fitty_Game
{
    class Aragorn : Character
    {

        public Aragorn()
        {
            Name = "Aragorn";
            Charnum = 2;
            enemy = false;
            hp = 100;
            desription = "The exiled King of Gondor, an agile swordsman wielding a two handed blade.";
            sprite = global::The_Realest_Fitty_Game.Properties.Resources.Aragorn;
            portrait = global::The_Realest_Fitty_Game.Properties.Resources.Aragorn_Portrait;
        }
    }
}