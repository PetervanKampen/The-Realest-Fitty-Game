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
        private bool fullscreen = true;
        public bool playerturn = true;
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

        public String NumParse(long num)
        {
            String output = "";
            if (num.ToString().Length == 1)
            {
                output = "0" + num.ToString();
            }
            else
            {
                output = num.ToString();
            }
            return output;
        }

        public String NumParse(long num, bool milli)
        {
            String output = "";
            if (num.ToString().Length == 2)
            {
                output = "0" + num.ToString();
            }
            else if (num.ToString().Length == 1)
            {
                output = "00" + num.ToString();
            }
            else
            {
                output = num.ToString();
            }
            return output;
        }

        public String getAttackDescription(String attackName)
        {
            String answer = "";
            switch (attackName)
            {
                case "Attack 1":
                    answer = "Attack 1";
                    break;
                case "Attack 2":
                    answer = "Attack 2";
                    break;
                case "Attack 3":
                    answer = "Attack 3";
                    break;
                case "Attack 4":
                    answer = "Attack 4";
                    break;
                case "Attack 5":
                    answer = "Attack 5";
                    break;
            }
            return answer;
        }

        public void reset()
        {
            BossCycle = 0;
            timer.Reset();
        }

        public void setSound(bool sound_) { Sound = sound_; }
        public bool getSound() { return Sound; }

        public void setScreen(bool screen_) { fullscreen = screen_; }
        public bool getScreen() { return fullscreen; }

        public void setCycle(int cycle) { BossCycle = cycle; }
        public void addCycle() { BossCycle++; }
        public int getCycle() { return BossCycle; }
    }
}
