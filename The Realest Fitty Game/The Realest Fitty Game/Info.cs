using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Realest_Fitty_Game
{
    public class Info
    {
        private bool Sound;

        public Info()
        {
            Sound = true;
        }

        public void setSound(bool sound_) { Sound = sound_; }
        public bool getSound() { return Sound; }

    }
}
