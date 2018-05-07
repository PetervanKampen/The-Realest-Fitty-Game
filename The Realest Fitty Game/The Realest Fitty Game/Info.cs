using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Realest_Fitty_Game
{
    public class Info
    {
        private bool Sound;
        public Character playerchar;
        public Character enemychar;
        private int BossCycle;
        public Stopwatch timer = new Stopwatch();
        public long GameStartTime;

        public Info()
        {
            Sound = true;
            BossCycle = 0;
            timer.Start();
        }

        public void setSound(bool sound_) { Sound = sound_; }
        public bool getSound() { return Sound; }

        public void setCycle(int cycle) { BossCycle = cycle; }
        public void addCycle() { BossCycle++; }
        public int getCycle() { return BossCycle; }
    }
}
