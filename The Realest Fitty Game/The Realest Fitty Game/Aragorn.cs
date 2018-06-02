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
            AD = 10;
            defense = 10;
            passive = "Flame of the West";
            desription = "Flame of the West: Deals more damage for each succesful consecutive attack.";
            sprite = global::The_Realest_Fitty_Game.Properties.Resources.Aragorn;
            portrait = global::The_Realest_Fitty_Game.Properties.Resources.Aragorn_Portrait;
        }
    }
}