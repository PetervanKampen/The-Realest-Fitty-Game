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
            desription = "A kind wizard sent to help in the fight against evil.";
            sprite = global::The_Realest_Fitty_Game.Properties.Resources.Gandalf;
        }
    }
}
