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
        protected int maxHP;
        protected int AD;
        protected int defense;
        protected int actions = 2;
        protected String desription;
        protected String passive;
        protected String[] attacks;
        protected int[] attackUses;
        protected bool rangedAttacks;
        protected bool silenced;
        protected int silencedTurn;
        protected bool stunned;
        protected int stunnedTurn;
        protected bool pinned;
        protected int pinnedTurn;
        protected bool clovenDefense;
        protected bool ranged;
        protected bool weaponSwapped;
        public System.Drawing.Image sprite;
        public System.Drawing.Image portrait;

        public Character()
        {        }

        public void setName(String name_) { Name = name_; }
        public String getName() { return Name; }

        public void setCharNum(int num_) { Charnum = num_; }
        public int getCharNum() { return Charnum; }

        public void setEnemy(bool enemy_) { enemy = enemy_; }
        public bool getEnemy() { return enemy; }

        public void setHP(int hp_) { hp = hp_; }
        public void modHP(int hp_) { hp -= hp_; }
        public int getHP() { return hp; }

        public int getMaxHP() { return maxHP; }

        public void setAD(int AD_) { AD = AD_; }
        public int getAD() { return AD; }

        public void setActions(int actions_) { actions = actions_; }
        public void reduceAction() { actions--; }
        public int getActions() { return actions; }

        public void setDefense(int defense_) { defense = defense_; }
        public void modDefense(int defense_) { defense += defense_; }
        public int getDefense() { return defense; }

        public void setDesription(String descrip) { desription = descrip; }
        public String getDescription() { return desription; }

        public void setPassive(String passive_) { passive = passive_; }
        public String getPassive() { return passive; }

        public bool getRangedAttacks() { return rangedAttacks; }

        public void setSilenced(bool silenced_) { silenced = silenced_; }
        public bool getSilenced() { return silenced; }

        public void setSilencedTurn(int silencedTurn_) { silencedTurn = silencedTurn_; }
        public int getSilencedTurn() { return silencedTurn; }

        public void setStunned(bool stunned_) { stunned = stunned_; }
        public bool getStunned() { return stunned; }

        public void setStunnedTurn(int stunnedTurn_) { stunnedTurn = stunnedTurn_; }
        public int getStunnedTurn() { return stunnedTurn; }

        public void setPinned(bool pinned_) { pinned = pinned_; }
        public bool getPinned() { return pinned; }

        public void setPinnedTurn(int pinnedTurn_) { pinnedTurn = pinnedTurn_; }
        public int getPinnedTurn() { return pinnedTurn; }

        public void setCloven(bool cloven_) { clovenDefense = cloven_; }
        public bool getCloven() { return clovenDefense; }

        public void setRanged(bool ranged_) { ranged = ranged_; }
        public bool getRanged() { return ranged; }

        public void setSwapped(bool swapped_) { weaponSwapped = swapped_; }
        public bool getSwapped() { return weaponSwapped; }

        public String getAttacks(int index)
        {
            try
            {
                return attacks[index];
            }
            catch(IndexOutOfRangeException)
            {
                return "Index out of Range";
            }
        }

        public void modAttackUses(int index, int mod)
        {
            try
            {
                attackUses[index] += mod;
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of bounds");
            }
        }
        public int getAttackUses(int index)
        {
            try
            {
                return attackUses[index];
            }
            catch (IndexOutOfRangeException)
            {
                return 404;
            }
        }

    }
}
