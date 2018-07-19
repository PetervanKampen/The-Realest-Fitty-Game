using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Realest_Fitty_Game
{
    public partial class Battlescreen : Form
    {
        private Info data;
        private Random Rand = new Random();

        public Battlescreen(Info data_, bool firstTime)
        {
            data = data_;

            InitializeComponent();
            Setup();

            Threadstarter();
            if (firstTime)
            {
                data.GameStartTime = data.timer.ElapsedMilliseconds;
            }
        }

        public void Threadstarter()
        {
            Thread time =
                new Thread(new ThreadStart(Timeupdater));
            time.IsBackground = true;
            time.Start();
        }

        private void Timeupdater()
        {
            while (true)
            {
                while (data.timer.IsRunning)
                {
                    Console.WriteLine("Test run");
                    String time;
                    long Millitime = (data.timer.ElapsedMilliseconds - data.GameStartTime) % 1000;
                    long Sectime = (data.timer.ElapsedMilliseconds - data.GameStartTime) / 1000 % 60;
                    long Mintime = (data.timer.ElapsedMilliseconds - data.GameStartTime) / 1000 / 60 % 60;

                    time = data.NumParse(Mintime) + ":" + data.NumParse(Sectime) + ":" + data.NumParse(Millitime, true);            

                    if (this.Timer.InvokeRequired)
                    {
                        this.Timer.BeginInvoke((MethodInvoker)delegate () { this.Timer.Text = time; ; });
                    }
                    else
                    {
                        this.Timer.Text = time;
                    }
                }
            }
        }

        private void Setup()
        {
            Console.WriteLine("Debug");

            this.Char1.Image = data.playerchar.sprite;

            

            this.modifierLabel.Text += ("- " + data.playerchar.getPassive());
            this.attack3.Text = data.playerchar.getAttacks(0);
            this.attack4.Text = data.playerchar.getAttacks(1);
            this.attack5.Text = data.playerchar.getAttacks(2);

            this.actionCountLabel.Text = "Actions Remaining: " + data.playerchar.getActions();
            this.playerDamage.Text = "Attack Damage: " + data.playerchar.getAD();
            this.playerDefense.Text = "Defense Rating: " + data.playerchar.getDefense();

            if (data.playerchar.getCharNum() == 4)
            {
                RescaleImage(Char1, 1.2, 0.8, false);
            }
            else if(data.playerchar.getCharNum() == 2)
            {
                RescaleImage(Char1, 1.0, 1.3, false);
                Char1.Location = new Point(70, 30);
            }

            Console.WriteLine("Debug2");

            switch (data.getCycle())
            {
                case 0:
                    data.enemychar = new Orc();
                    BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Orc_Background;
                    break;

                case 1:
                    data.enemychar = new Troll();
                    BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Troll_Background;
                    RescaleImage(Char2, 1.8, 1.8, true);
                    Char2.Location = new Point(650, -140);
                    break;

                case 2:
                    data.enemychar = new Saruman();
                    BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Saruman_Background;
                    break;

                case 3:
                    data.enemychar = new Sauron();
                    BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Sauron_Background;
                    RescaleImage(Char2, 1.7, 1.7, true);
                    Char2.Location = new Point(650, -140);
                    break;
            }

            Console.WriteLine("Debug3");
            this.Char2.Image = data.enemychar.sprite;

            this.Char1HP.Maximum = data.playerchar.getHP();
            this.Char1HP.Value = data.playerchar.getHP();
            
            this.Char2HP.Maximum = data.enemychar.getHP();
            this.Char2HP.Value = data.enemychar.getHP();

            updateMods();
            Console.WriteLine("Debug4");

            /////////////////////////////
            data.playerchar.modHP(30);
            updateHP();
            /////////////////////////////

        }

        private void attack1Hover(object sender, EventArgs e)
        {
            this.detailsPanel.Visible = true;
            this.detailsLabel.Text = data.getAttackDescription("Attack 1");
        }

        private void attack2Hover(object sender, EventArgs e)
        {
            this.detailsPanel.Visible = true;
            this.detailsLabel.Text = data.getAttackDescription("Attack 2");
        }

        private void attack3Hover(object sender, EventArgs e)
        {
            this.detailsPanel.Visible = true;
            this.detailsLabel.Text = data.getAttackDescription("Attack 3");
        }

        private void attack4Hover(object sender, EventArgs e)
        {
            this.detailsPanel.Visible = true;
            this.detailsLabel.Text = data.getAttackDescription("Attack 4");
        }

        private void attack5Hover(object sender, EventArgs e)
        {
            this.detailsPanel.Visible = true;
            this.detailsLabel.Text = data.getAttackDescription("Attack 5");
        }

        private void attackLeave(object sender, EventArgs e)
        {
            this.detailsPanel.Visible = false;
        }

        private void Battlescreen_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            
         //   System.Windows.Forms.Application.Exit();
        }

        private void Debug_Click(object sender, EventArgs e)
        {
            turnSwap();
            if (this.Char1HP.Value > 0 && this.Char2HP.Value > 0)
            {
                this.Char1HP.Value -= 10;
                this.Char2HP.Value -= (data.enemychar.getHP() / 2);
            }
            if (this.Char2HP.Value <= 0)
            {
                if (data.enemychar.getCharNum() != 4)
                {
                    data.addCycle();
                    Form battle = new Battlescreen(data, false);
                    battle.ShowDialog();
                }
                else
                {
                    Form end = new Endscreen(data, true);
                    end.ShowDialog();
                }

                this.Dispose();
            }
        }

        public void RescaleImage(PictureBox image, double widthfactor, double heightfactor, bool enemy)
        {
            double newWidth = image.Width * widthfactor;
            double newHeight = image.Height * heightfactor;

            if (!enemy)
            {
                double diffWidth = (image.Width - newWidth);
                image.Location = new Point((image.Location.X), (image.Location.Y - (int)diffWidth));
            }
            image.Width = (int)newWidth;
            image.Height = (int)newHeight;
        }

        private void turnSwap()
        {
            if (data.playerturn)
            {
                this.attackPanel.Visible = false;
                this.turnIndicator.ForeColor = System.Drawing.Color.Red;
                this.turnIndicator.Text = "Enemy Turn";
                this.attackButton.ForeColor = System.Drawing.Color.Gray;
                this.defendButton.ForeColor = System.Drawing.Color.Gray;
                this.endTurnButton.ForeColor = System.Drawing.Color.Gray;
                data.playerturn = false;
                if((data.turnCount - data.enemychar.getSilencedTurn()) >= 1)
                {
                    data.enemychar.setSilenced(false);
                    updateEnemyMods();
                }
                if ((data.turnCount - data.enemychar.getStunnedTurn()) >= 1)
                {
                    data.enemychar.setStunned(false);
                    updateEnemyMods();
                }
                if ((data.turnCount - data.enemychar.getPinnedTurn()) >= 2)
                {
                    data.enemychar.setPinned(false);
                    updateEnemyMods();
                }
            }
            else
            {
                data.turnCount += 1;
                this.turnIndicator.Text = "Your Turn";
                this.turnIndicator.ForeColor = System.Drawing.Color.Green;
                this.attackButton.ForeColor = System.Drawing.Color.Gold;
                this.defendButton.ForeColor = System.Drawing.Color.Gold;
                this.endTurnButton.ForeColor = System.Drawing.Color.Gold;
                data.playerturn = true;
            }
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            if (data.playerturn)
            {
                if (!this.attackPanel.Visible)
                {
                    this.attackPanel.Visible = true;
                }
                else if (this.attackPanel.Visible)
                {
                    this.attackPanel.Visible = false;
                }
            }
        }

        private void playerDefense_Click(object sender, EventArgs e)
        {

        }

        private void defendButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void attack1_Click(object sender, EventArgs e)
        {
            this.actionPanel.Visible = true;
            this.action2Label.Text = this.action1Label.Text;
            this.action1Label.Text = data.playerchar.getName() + " used " + this.attack1.Text;
            if (!data.playerchar.getStunned())
            {
                data.enemychar.modHP(damageMit((int)(data.playerchar.getAD() * 1), true));
            }
            else
            {
                this.action2Label.Text = this.action1Label.Text;
                this.action1Label.Text = data.playerchar.getName() + " is stunned.";
            }
            updateHP();
            if(data.playerchar.getRangedAttacks())
            {
                data.playerchar.setRanged(true);
            }
            else
            {
                data.playerchar.setRanged(false);
            }
        }

        private void attack2_Click(object sender, EventArgs e)
        {
            this.actionPanel.Visible = true;
            this.action2Label.Text = this.action1Label.Text;
            this.action1Label.Text = data.playerchar.getName() + " used " + this.attack2.Text;
            if (!data.playerchar.getStunned())
            {
                data.enemychar.modHP(damageMit((int)(data.playerchar.getAD() * 1.5), true));
            }
            else
            {
                this.action2Label.Text = this.action1Label.Text;
                this.action1Label.Text = data.playerchar.getName() + " is stunned.";
            }
            updateHP();
            if (data.playerchar.getRangedAttacks())
            {
                data.playerchar.setRanged(true);
            }
            else
            {
                data.playerchar.setRanged(false);
            }
        }

        private void attack3_Click(object sender, EventArgs e)
        {
            this.actionPanel.Visible = true;     
            specAttack1();
        }

        private void attack4_Click(object sender, EventArgs e)
        {
            this.actionPanel.Visible = true;
            specAttack2();
        }

        private void attack5_Click(object sender, EventArgs e)
        {
            this.actionPanel.Visible = true;
            specAttack3();
        }

        private void endTurnButton_Click(object sender, EventArgs e)
        {
            this.actionPanel.Visible = false;
            turnSwap();
        }

        private void modifierPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateHP()
        {
            if (data.playerchar.getHP() >= 0)
            {
                this.Char1HP.Value = data.playerchar.getHP();
            }
            if (data.enemychar.getHP() >= 0)
            {
                this.Char2HP.Value = data.enemychar.getHP();
            }
        }

        private void updateMods()
        {
            String text = (data.playerchar.getPassive() + " \n");
            if (data.playerchar.getCloven())
            {
                text += " - Cloven Defense \n";
            }
            if (data.playerchar.getRanged())
            {
                text += " - Ranged \n";
            }
            if (data.playerchar.getSilenced())
            {
                text += " - Silenced \n";
            }
            if (data.playerchar.getStunned())
            {
                text += " - Stunned \n";
            }
            if (data.playerchar.getPinned())
            {
                text += " - Pinned \n";
            }

            if (text != null)
            {
                modifierPanel.Visible = true;
                modifierLabel.Text = text;
            }

        }

        private void updateEnemyMods()
        {
            String text = null;
            if (data.enemychar.getCloven())
            {
                text += " - Cloven Defense \n";
            }
            if (data.enemychar.getRanged())
            {
                text += " - Ranged \n";
            }
            if (data.enemychar.getSilenced())
            {
                text += " - Silenced \n";
            }
            if(data.enemychar.getStunned())
            {
                text += " - Stunned \n";
            }
            if (data.enemychar.getPinned())
            {
                text += " - Pinned \n";
            }

            if (text != null)
            {
                enemyModPanel.Visible = true;
                enemyModLabel.Text = text;
            }
            else
            {
                enemyModPanel.Visible = false;
            }
        }

        private bool chanceRanged()
        {
            int chance = Rand.Next(0, 10);
            if(chance <= 6)
            {
                Console.WriteLine(" ranged true");
                return true;
            }
            else
            {
                Console.WriteLine(" ranged false");
                return false;
            }
        }

        private int damageMit(int damage, bool targetenemy)
        {
            if (targetenemy)
            {
                return (int)(damage / data.enemychar.getDefense() * 10);
            }
            else
            {
                return (int)(damage / data.playerchar.getDefense() * 10);
            }
        }

        private void specAttack1()
        {
            if (data.playerchar.getAttackUses(0) > 0)
            {
                if (!data.playerchar.getSilenced() && !data.playerchar.getStunned())
                {
                    data.playerchar.modAttackUses(0, -1);
                    this.action2Label.Text = this.action1Label.Text;
                    this.action1Label.Text = data.playerchar.getName() + " used " + this.attack3.Text;

                    if (data.playerchar.getCharNum() == 1) //Gandalf
                    {
                        data.enemychar.setSilenced(true);
                        data.enemychar.setSilencedTurn(data.turnCount);
                        data.playerchar.setRanged(true);
                        updateMods();
                        updateEnemyMods();
                        updateHP();
                    }

                    else if (data.playerchar.getCharNum() == 2) //Aragorn
                    {
                        if(data.enemychar.getRanged())
                        {
                            if(chanceRanged())
                            {
                                data.enemychar.modHP(damageMit(data.playerchar.getAD(), true));
                            }
                            else
                            {
                                this.action2Label.Text = this.action1Label.Text;
                                this.action1Label.Text = data.playerchar.getName() + " missed.";
                            }
                        }
                        else
                        {
                            data.enemychar.modHP(damageMit(data.playerchar.getAD(), true));
                        }                       
                        data.playerchar.setRanged(true);
                        updateMods();
                        updateEnemyMods();
                        updateHP();
                    }

                    else if (data.playerchar.getCharNum() == 3) //Legolas
                    {
                        data.enemychar.modHP(damageMit(((int)(data.playerchar.getAD() * 1.7)), true));
                        updateHP();
                        data.playerchar.setRanged(true);
                        updateMods();
                        updateEnemyMods();
                        updateHP();
                    }

                    else if (data.playerchar.getCharNum() == 4) //Gimli
                    {
                        data.enemychar.setStunned(true);
                        data.enemychar.setStunnedTurn(data.turnCount);
                        data.playerchar.setRanged(false);
                        updateMods();
                        updateEnemyMods();
                        updateHP();
                    }
                }
                else if(data.playerchar.getSilenced())
                {
                    this.action2Label.Text = this.action1Label.Text;
                    this.action1Label.Text = data.playerchar.getName() + " is silenced.";
                }
                else if (data.playerchar.getStunned())
                {
                    this.action2Label.Text = this.action1Label.Text;
                    this.action1Label.Text = data.playerchar.getName() + " is stunned.";
                }
            }
        }

        private void specAttack2()
        {
            if (data.playerchar.getAttackUses(1) > 0)
            {
                if (!data.playerchar.getSilenced() && !data.playerchar.getStunned())
                {
                    data.playerchar.modAttackUses(1, -1);
                    this.action2Label.Text = this.action1Label.Text;
                    this.action1Label.Text = data.playerchar.getName() + " used " + this.attack4.Text;

                    if (data.playerchar.getCharNum() == 1) //Gandalf
                    {
                        if (data.enemychar.getRanged())
                        {
                            if (chanceRanged())
                            {
                                data.enemychar.modHP(damageMit((int)(data.playerchar.getAD() * 1.8), true));
                                data.enemychar.setRanged(true);
                            }
                            else
                            {
                                this.action2Label.Text = this.action1Label.Text;
                                this.action1Label.Text = data.playerchar.getName() + " missed.";
                            }
                        }
                        else
                        {
                            data.enemychar.modHP(damageMit((int)(data.playerchar.getAD() * 1.8), true));
                            data.enemychar.setRanged(true);
                        }
                        data.playerchar.setRanged(true);
                        updateMods();
                        updateEnemyMods();
                        updateHP();
                    }

                    else if (data.playerchar.getCharNum() == 2) //Aragorn
                    {
                        if (data.enemychar.getRanged())
                        {
                            if (chanceRanged())
                            {
                                data.enemychar.setPinned(true);
                                data.enemychar.setPinnedTurn(data.turnCount);
                                data.enemychar.modHP(damageMit((int)(data.playerchar.getAD() * 1), true));
                            }
                            else
                            {
                                this.action2Label.Text = this.action1Label.Text;
                                this.action1Label.Text = data.playerchar.getName() + " missed.";
                            }
                        }
                        else
                        {
                            data.enemychar.setPinned(true);
                            data.enemychar.setPinnedTurn(data.turnCount);
                            data.enemychar.modHP(damageMit((int)(data.playerchar.getAD() * 1), true));
                        }
                        data.playerchar.setRanged(false);
                        updateMods();
                        updateEnemyMods();
                        updateHP();
                    }

                    else if (data.playerchar.getCharNum() == 3) //Legolas
                    {
                        if (data.enemychar.getRanged())
                        {
                            if (chanceRanged())
                            {
                                data.enemychar.modHP(damageMit((int)(data.playerchar.getAD() * 2.2), true));
                            }
                            else
                            {
                                this.action2Label.Text = this.action1Label.Text;
                                this.action1Label.Text = data.playerchar.getName() + " missed.";
                            }
                        }
                        else
                        {
                            data.enemychar.modHP(damageMit((int)(data.playerchar.getAD() * 2.2), true));
                        }
                        data.playerchar.setRanged(true);
                        updateMods();
                        updateEnemyMods();
                        updateHP();
                    }

                    else if (data.playerchar.getCharNum() == 4) //Gimli
                    {
                        if (data.enemychar.getRanged())
                        {
                            if (chanceRanged())
                            {
                                data.enemychar.setCloven(true);
                                data.enemychar.modDefense(-4);
                                data.enemychar.modHP(damageMit((int)(data.playerchar.getAD() * 1), true));
                            }
                            else
                            {
                                this.action2Label.Text = this.action1Label.Text;
                                this.action1Label.Text = data.playerchar.getName() + " missed.";
                            }
                        }
                        else
                        {
                            data.enemychar.setCloven(true);
                            data.enemychar.modDefense(-4);
                            data.enemychar.modHP(damageMit((int)(data.playerchar.getAD() * 1), true));
                        }
                        data.playerchar.setRanged(false);
                        updateMods();
                        updateEnemyMods();
                        updateHP();
                    }
                }
                else if (data.playerchar.getSilenced())
                {
                    this.action2Label.Text = this.action1Label.Text;
                    this.action1Label.Text = data.playerchar.getName() + " is silenced.";
                }
                else if (data.playerchar.getStunned())
                {
                    this.action2Label.Text = this.action1Label.Text;
                    this.action1Label.Text = data.playerchar.getName() + " is stunned.";
                }
            }
        }

        private void specAttack3()
        {
            if (data.playerchar.getAttackUses(2) > 0)
            {
                if (!data.playerchar.getSilenced() && !data.playerchar.getStunned())
                {
                    data.playerchar.modAttackUses(2, -1);
                    this.action2Label.Text = this.action1Label.Text;
                    this.action1Label.Text = data.playerchar.getName() + " used " + this.attack5.Text;

                    if (data.playerchar.getCharNum() == 1) //Gandalf
                    {
                        data.playerchar.modHP(-25);
                        
                        if(data.playerchar.getHP() > data.playerchar.getMaxHP())
                        {
                            data.playerchar.setHP(data.playerchar.getMaxHP());
                        }
                        
                        updateHP();
                    }

                    else if (data.playerchar.getCharNum() == 2) //Aragorn
                    {
                       
                    }

                    else if (data.playerchar.getCharNum() == 3) //Legolas
                    {
                        
                    }

                    else if (data.playerchar.getCharNum() == 4) //Gimli
                    {

                    }
                        
                }
                else if (data.playerchar.getSilenced())
                {
                    this.action2Label.Text = this.action1Label.Text;
                    this.action1Label.Text = data.playerchar.getName() + " is silenced.";
                }
                else if (data.playerchar.getStunned())
                {
                    this.action2Label.Text = this.action1Label.Text;
                    this.action1Label.Text = data.playerchar.getName() + " is stunned.";
                }
            }
        }
    }
}
