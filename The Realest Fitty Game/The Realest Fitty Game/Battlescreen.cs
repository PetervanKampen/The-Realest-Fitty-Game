using System;
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

        public Battlescreen(Info data_)
        {
            data = data_;
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            this.Char1.Image = data.playerchar.sprite;
            switch (data.getCycle())
            {
                case 0:
                    data.enemychar = new Orc();
                    BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Orc_Background;
                    break;

                case 1:
                    data.enemychar = new Troll();
                    BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Troll_Background;
                    break;

                case 2:
                    data.enemychar = new Saruman();
                    BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Saruman_Background;
                    break;

                case 3:
                    data.enemychar = new Sauron(); 
                    BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Sauron_Background;
                    break;
            }
            this.Char2.Image = data.enemychar.sprite;
        }

        private void Battlescreen_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Debug_Click(object sender, EventArgs e)
        {
            if (this.Char1HP.Value > 0 && this.Char2HP.Value > 0)
            {
                this.Char1HP.Value -= 10;
                this.Char2HP.Value -= 10;
            }
            if (this.Char2HP.Value == 0)
            {
                data.addCycle();
                new Battlescreen(data).Show();
                this.Visible = false;
            }
        }
    }
}
