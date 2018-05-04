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
            desription = "A stubborn dwarf hailing from Erebor. Not very agile but definitely hits hardest.";
            sprite = global::The_Realest_Fitty_Game.Properties.Resources.Gimli;
        }
    }
}