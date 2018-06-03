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
                    answer = "A quick and decisive attack. \n Uses Remaining: ∞";
                    break;
                case "Attack 2":
                    answer = "A hard hitting but slow attack. \n Uses Remaining: ∞";
                    break;
                case "Attack 3":
                    if (playerchar.getCharNum() == 1) //Gandalf
                    {
                        answer = "Silence the Enemy. \n Uses Remaining: " + playerchar.getAttackUses(0);
                    }
                    else if (playerchar.getCharNum() == 2) //Aragorn
                    {
                        answer = "Attack with bow and arrow. \n Uses Remaining: " + playerchar.getAttackUses(0);
                    }
                    else if (playerchar.getCharNum() == 3) //Legolas
                    {
                        answer = "Strike with precision for extra damage. \n Uses Remaining: " + playerchar.getAttackUses(0);
                    }
                    else if (playerchar.getCharNum() == 4) //Gimli
                    {
                        answer = "Stun the Enemy with your Charge. \n Uses Remaining: " + playerchar.getAttackUses(0);
                    }
                    break;
                case "Attack 4":

                    if (playerchar.getCharNum() == 1) //Gandalf
                    {
                        answer = "Blast the Enemy with Magic. \n Uses Remaining: " + playerchar.getAttackUses(1);
                    }
                    else if (playerchar.getCharNum() == 2) //Aragorn
                    {
                        answer = "Increase chance of decapitation. \n Uses Remaining: " + playerchar.getAttackUses(1);
                    }
                    else if (playerchar.getCharNum() == 3) //Legolas
                    {
                        answer = "Shoot two arrows at once. \n Uses Remaining: " + playerchar.getAttackUses(1);
                    }
                    else if (playerchar.getCharNum() == 4) //Gimli
                    {
                        answer = "Permanently reduce enemy's defence. \n Uses Remaining: " + playerchar.getAttackUses(1);
                    }
                    break;

                case "Attack 5":
                    if (playerchar.getCharNum() == 1) //Gandalf
                    {
                        answer = "Heal your sustained Wounds. \n Uses Remaining: " + playerchar.getAttackUses(2);
                    }
                    else if (playerchar.getCharNum() == 2) //Aragorn
                    {
                        answer = "Chance to instantly kill enemy. \n Uses Remaining: " + playerchar.getAttackUses(2);
                    }
                    else if (playerchar.getCharNum() == 3) //Legolas
                    {
                        answer = "Strike enemy with your two knives. \n Uses Remaining: " + playerchar.getAttackUses(2);
                    }
                    else if (playerchar.getCharNum() == 4) //Gimli
                    {
                        answer = "Swap between your weapons. \n Uses Remaining: " + playerchar.getAttackUses(2);
                    }
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
