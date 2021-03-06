﻿using System;
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
        private bool wonGame;

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



            if(data.playerchar.getCharNum() == 2) //aragorn passive reset
            {
                data.playerchar.setAD(10);
            }

            if(data.playerchar.getCharNum() == 3)
            {
                data.playerchar.legolasPassive();
            }

            updateLabels();
            Console.WriteLine("Debug4");
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

     /*   protected override void OnFormClosing(FormClosingEventArgs e)
        {
            
            System.Windows.Forms.Application.Exit();
        }*/

        private void Debug_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            /*turnSwap();
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

                this.Dispose();*/       
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
                data.enemychar.setActions(2);
                
                this.turnIndicator.ForeColor = System.Drawing.Color.Red;
                this.turnIndicator.Text = "Enemy Turn";
                this.attackButton.ForeColor = System.Drawing.Color.Gray;
                this.defendButton.ForeColor = System.Drawing.Color.Gray;
                this.endTurnButton.ForeColor = System.Drawing.Color.Gray;
                data.playerturn = false;
                if ((data.turnCount - data.enemychar.getSilencedTurn()) >= 1)
                {
                    data.enemychar.setSilenced(false);
                }
                if ((data.turnCount - data.enemychar.getStunnedTurn()) >= 1)
                {
                    data.enemychar.setStunned(false);
                }
                if ((data.turnCount - data.enemychar.getPinnedTurn()) >= 2)
                {
                    data.enemychar.setPinned(false);
                }               
                updateLabels();
            }
            else
            {
                data.turnCount += 1;
                data.playerchar.setActions(2);

                this.turnIndicator.Text = "Your Turn";
                this.turnIndicator.ForeColor = System.Drawing.Color.Green;
                this.attackButton.ForeColor = System.Drawing.Color.Gold;
                this.defendButton.ForeColor = System.Drawing.Color.Gold;
                this.endTurnButton.ForeColor = System.Drawing.Color.Gold;
                data.playerturn = true;
                if (data.playerchar.getCharNum() == 2)
                {
                    data.playerchar.aragornPassive();
                }
                if (data.playerchar.getCharNum() == 4)
                {
                    int missingHP = (data.playerchar.getMaxHP() - data.playerchar.getHP());
                    int healing = 0 - ((int)(0.25 * missingHP));
                    data.playerchar.modHP(healing);
                }
                if ((data.turnCount - data.enemychar.getDefendingTurn()) >= 1)
                {
                    data.playerchar.setDefending(false);
                    data.playerchar.modDefense(-6);
                }
                updateLabels();
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
            // System.Windows.Forms.Application.Exit();
            data.playerchar.reduceAction();
            data.playerchar.setDefending(true);
            data.playerchar.setDefendingTurn(data.turnCount);
            data.playerchar.modDefense(6);
            data.playerchar.setRanged(true);
            this.actionPanel.Visible = true;
            this.action2Label.Text = this.action1Label.Text;
            this.action1Label.Text = data.playerchar.getName() + " entered a defensive stance.";
            updateLabels();
        }

        private void attack1_Click(object sender, EventArgs e)
        {
            this.actionPanel.Visible = true;

            if (!data.playerchar.getStunned())
            {
                if (data.playerchar.getActions() > 0)
                {
                    data.playerchar.reduceAction();
                    if (data.enemychar.getRanged())
                    {
                        data.playerchar.reduceAction();
                    }
                    if (data.playerchar.getActions() >= 0)
                    {
                        data.enemychar.modHP(damageMit((int)(data.playerchar.getAD() * 1), true));

                        this.action2Label.Text = this.action1Label.Text;
                        this.action1Label.Text = data.playerchar.getName() + " used " + this.attack1.Text;
                    }
                }
                updateLabels();
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

            if (!data.playerchar.getStunned())
            {
                if (data.playerchar.getActions() > 0)
                {
                    data.playerchar.reduceAction();
                    if (data.enemychar.getRanged())
                    {
                        data.playerchar.reduceAction();
                    }
                    if (data.playerchar.getActions() >= 0)
                    {
                        data.enemychar.modHP(damageMit((int)(data.playerchar.getAD() * 1.5), true));

                        this.action2Label.Text = this.action1Label.Text;
                        this.action1Label.Text = data.playerchar.getName() + " used " + this.attack2.Text;
                    }
                }
                updateLabels();
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

        private void endGame(bool win)
        {
            if (win)
            {
                this.endTextLabel.Text = "You won the Fight";
                this.endGameButton.Text = "To the next Fight";
                this.endGamePanel.Visible = true;
                wonGame = true;
                if(data.playerchar.getCharNum() == 1)
                {
                    data.playerchar.gandalfPassive(3, 2, 2);
                }
            }
            else
            {
                this.endTextLabel.Text = "Game Over";
                this.endGameButton.Text = "To the Endscreen";
                this.endGamePanel.Visible = true;
                wonGame = false;
            }
        }

        private void updateLabels()
        {
            updateStats();
            updateEnemyMods();
            updateMods();
            updateHP();
        }

        private void updateStats()
        {
            this.actionCountLabel.Text = "Actions Remaining: " + data.playerchar.getActions();
            this.playerDamage.Text = "Attack Damage: " + data.playerchar.getAD();
            this.playerDefense.Text = "Defense Rating: " + data.playerchar.getDefense();
        }

        private void updateHP()
        {
            if (data.playerchar.getHP() >= 0)
            {
                this.Char1HP.Value = data.playerchar.getHP();
            }
            else
            {
                this.Char2HP.Value = 0;
                endGame(false);
            }
            if (data.enemychar.getHP() >= 0)
            {
                this.Char2HP.Value = data.enemychar.getHP();
            }
            else
            {
                this.Char2HP.Value = 0;
                endGame(true);
            }
        }

        private void updateMods()
        {
            String text = (data.playerchar.getPassive() + " \n");
            if (data.playerchar.getCloven())
            {
                text += " - Cloven Defense \n";
            }
            if (data.playerchar.getDefending())
            {
                text += " - Defending \n";
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
            if (data.enemychar.getDefending())
            {
                text += " - Defending \n";
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
            if (data.playerchar.getAttackUses(0) > 0 && data.playerchar.getActions() > 0)
            {
                if (!data.playerchar.getSilenced() && !data.playerchar.getStunned())
                {
                    data.playerchar.modAttackUses(0, -1);
                    data.playerchar.reduceAction();


                    if (data.playerchar.getCharNum() == 1) //Gandalf
                    {
                        data.enemychar.setSilenced(true);
                        data.enemychar.setSilencedTurn(data.turnCount);
                        data.playerchar.setRanged(true);
                        updateLabels();

                        this.action2Label.Text = this.action1Label.Text;
                        this.action1Label.Text = data.playerchar.getName() + " used " + this.attack3.Text;
                    }

                    else if (data.playerchar.getCharNum() == 2) //Aragorn
                    {
                        if (data.enemychar.getRanged())
                        {
                            data.playerchar.reduceAction();
                        }
                        if (data.playerchar.getActions() >= 0)
                        {
                            data.enemychar.modHP(damageMit(data.playerchar.getAD(), true));

                            data.playerchar.setRanged(true);
                            updateLabels();

                            this.action2Label.Text = this.action1Label.Text;
                            this.action1Label.Text = data.playerchar.getName() + " used " + this.attack3.Text;
                        }
                    }

                    else if (data.playerchar.getCharNum() == 3) //Legolas
                    {
                        data.enemychar.modHP(damageMit(((int)(data.playerchar.getAD() * 1.7)), true));
                        data.playerchar.setRanged(true);
                        updateLabels();

                        this.action2Label.Text = this.action1Label.Text;
                        this.action1Label.Text = data.playerchar.getName() + " used " + this.attack3.Text;
                    }

                    else if (data.playerchar.getCharNum() == 4) //Gimli
                    {
                        data.enemychar.setStunned(true);
                        data.enemychar.setStunnedTurn(data.turnCount);
                        data.playerchar.setRanged(false);
                        data.enemychar.setRanged(false);
                        updateLabels();

                        this.action2Label.Text = this.action1Label.Text;
                        this.action1Label.Text = data.playerchar.getName() + " used " + this.attack3.Text;
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
            if (data.playerchar.getAttackUses(1) > 0 && data.playerchar.getActions() > 0)
            {
                if (!data.playerchar.getSilenced() && !data.playerchar.getStunned())
                {
                    data.playerchar.modAttackUses(1, -1);
                    data.playerchar.reduceAction();

                    if (data.playerchar.getCharNum() == 1) //Gandalf
                    {
                        if (data.enemychar.getRanged())
                        {
                            data.playerchar.reduceAction();
                        }
                        if (data.playerchar.getActions() >= 0)
                        {
                            data.enemychar.modHP(damageMit((int)(data.playerchar.getAD() * 1.8), true));

                            data.enemychar.setRanged(true);
                            data.playerchar.setRanged(true);
                            updateLabels();

                            this.action2Label.Text = this.action1Label.Text;
                            this.action1Label.Text = data.playerchar.getName() + " used " + this.attack4.Text;
                        }
                    }

                    else if (data.playerchar.getCharNum() == 2) //Aragorn
                    {
                        if (data.enemychar.getRanged())
                        {
                            data.playerchar.reduceAction();
                        }
                        if (data.playerchar.getActions() >= 0)
                        {
                            data.enemychar.setPinned(true);
                            data.enemychar.setPinnedTurn(data.turnCount);
                            data.enemychar.modHP(damageMit((int)(data.playerchar.getAD() * 1), true));

                            data.enemychar.setRanged(false);
                            data.playerchar.setRanged(false);
                            updateLabels();

                            this.action2Label.Text = this.action1Label.Text;
                            this.action1Label.Text = data.playerchar.getName() + " used " + this.attack4.Text;
                        }
                    }

                    else if (data.playerchar.getCharNum() == 3) //Legolas
                    {
                        if (data.enemychar.getRanged())
                        {
                            data.playerchar.reduceAction();
                        }
                        if (data.playerchar.getActions() >= 0)
                        {
                            data.enemychar.modHP(damageMit((int)(data.playerchar.getAD() * 2.2), true));

                            data.playerchar.setRanged(true);
                            updateLabels();

                            this.action2Label.Text = this.action1Label.Text;
                            this.action1Label.Text = data.playerchar.getName() + " used " + this.attack4.Text;
                        }
                    }

                    else if (data.playerchar.getCharNum() == 4) //Gimli
                    {                        
                        if (data.enemychar.getRanged())
                        {
                            data.playerchar.reduceAction();                            
                        }
                        if (data.playerchar.getActions() >= 0)
                        {
                            data.enemychar.setCloven(true);
                            data.enemychar.modDefense(-4);
                            data.enemychar.modHP(damageMit((int)(data.playerchar.getAD() * 1), true));

                            data.enemychar.setRanged(false);
                            data.playerchar.setRanged(false);
                            updateLabels();

                            this.action2Label.Text = this.action1Label.Text;
                            this.action1Label.Text = data.playerchar.getName() + " used " + this.attack4.Text;
                        }
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
            if (data.playerchar.getAttackUses(2) > 0 && data.playerchar.getActions() > 0)
            {
                if (!data.playerchar.getSilenced() && !data.playerchar.getStunned())
                {
                    data.playerchar.modAttackUses(2, -1);
                    data.playerchar.reduceAction();

                    if (data.playerchar.getCharNum() == 1) //Gandalf
                    {
                        data.playerchar.modHP(-25);
                        
                        if(data.playerchar.getHP() > data.playerchar.getMaxHP())
                        {
                            data.playerchar.setHP(data.playerchar.getMaxHP());
                        }

                        updateLabels();

                        this.action2Label.Text = this.action1Label.Text;
                        this.action1Label.Text = data.playerchar.getName() + " used " + this.attack5.Text;
                    }

                    else if (data.playerchar.getCharNum() == 2) //Aragorn
                    {
                        if (data.enemychar.getRanged())
                        {
                            data.playerchar.reduceAction();
                        }
                        if (data.playerchar.getActions() >= 0)
                        {
                            int resist = data.enemychar.getDefense();
                            if (data.enemychar.getPinned())
                            {
                                resist -= 6;
                            }
                            int chance = 20 - resist;
                            int random = Rand.Next(1, 21);
                            if (random < chance)
                            {
                                data.enemychar.modHP(data.enemychar.getHP());

                                this.action2Label.Text = this.action1Label.Text;
                                this.action1Label.Text = data.playerchar.getName() + " decapitated his enemy.";
                            }
                            else
                            {
                                this.action2Label.Text = this.action1Label.Text;
                                this.action1Label.Text = data.playerchar.getName() + " missed.";
                            }
                        }

                        data.enemychar.setRanged(false);
                        data.playerchar.setRanged(false);
                        updateLabels();
                    }

                    else if (data.playerchar.getCharNum() == 3) //Legolas
                    {
                        if (data.enemychar.getRanged())
                        {
                            data.playerchar.reduceAction();
                        }
                        if (data.playerchar.getActions() >= 0)
                        {
                            data.enemychar.modHP(damageMit((int)(data.playerchar.getAD() * 1.5), true));

                            data.enemychar.setRanged(false);
                            data.playerchar.setRanged(false);
                            updateLabels();

                            this.action2Label.Text = this.action1Label.Text;
                            this.action1Label.Text = data.playerchar.getName() + " used " + this.attack5.Text;
                        }

                    }

                    else if (data.playerchar.getCharNum() == 4) //Gimli
                    {
                        if(!data.playerchar.getSwapped())
                        {
                            data.playerchar.setDefense(12);
                            data.playerchar.setAD(13);
                            data.playerchar.setSwapped(true);
                        }
                        else
                        {
                            data.playerchar.setDefense(15);
                            data.playerchar.setAD(10);
                            data.playerchar.setSwapped(false);
                        }
                        updateLabels();
                        this.action2Label.Text = this.action1Label.Text;
                        this.action1Label.Text = data.playerchar.getName() + " used " + this.attack5.Text;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void endGameButton_Click(object sender, EventArgs e)
        {
            if(wonGame)
            {
                if (data.enemychar.getCharNum() != 4)
                {
                    data.addCycle();
                    data.playerchar.setActions(2);
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
            else
            {
                Form end = new Endscreen(data, false);
                end.ShowDialog();
            }

        }
    }
}
