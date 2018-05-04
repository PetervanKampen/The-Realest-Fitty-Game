using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Realest_Fitty_Game
{
    public class Character
    {
        protected String Name;
        protected int Charnum;
        protected bool enemy;
        protected int hp;
        protected String desription;
        public System.Drawing.Image sprite;

        public Character()
        {        }

        public void setName(String name_) { Name = name_; }
        public String getName() { return Name; }

        public void setCharNum(int num_) { Charnum = num_; }
        public int getCharNum() { return Charnum; }

        public void setEnemy(bool enemy_) { enemy = enemy_; }
        public bool getEnemy() { return enemy; }

        public void setHP(int hp_) { hp = hp_; }
        public int getHP() { return hp; }

        public void setDesription(String descrip) { desription = descrip; }
        public String getDescription() { return desription; }

    }
}
