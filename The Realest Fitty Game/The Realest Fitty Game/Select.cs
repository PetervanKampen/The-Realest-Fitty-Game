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
    public partial class Select : Form
    {
        private int p1 = 0;

        public Select()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (p1 != 0)
            {
                new Battlescreen(p1).Show();
                this.Visible = false;
            }
            else
            {
                this.Title.ForeColor = Color.Red;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Gandalf_Button_Click(object sender, EventArgs e)
        {
            this.Aragorn_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Empty;
            this.Gimli_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Empty;
            this.Legolas_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Empty;
            this.Gandalf_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Ring_Text;
            p1 = 1;
            this.Title.ForeColor = Color.Gold;
            this.Description.Text = "A kind wizard sent to help in the fight against evil.";
        }

        private void Aragorn_Button_Click(object sender, EventArgs e)
        {
            this.Gandalf_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Empty;
            this.Gimli_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Empty;
            this.Legolas_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Empty;
            this.Aragorn_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Ring_Text;
            p1 = 2;
            this.Title.ForeColor = Color.Gold;
            this.Description.Text = "The exiled King of Gondor, an agile swordsman wielding a two handed blade.";
        }

        private void Saruman_Button_Click(object sender, EventArgs e)
        {
            this.Gimli_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Empty;
            this.Aragorn_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Empty;
            this.Gandalf_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Empty;
            this.Legolas_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Ring_Text;
            p1 = 3;
            this.Title.ForeColor = Color.Gold;
            this.Description.Text = "The prince of the elven kingdom of Mirkwood, wielding a bow with deadeye accuracy.";
        }

        private void Sauron_Button_Click(object sender, EventArgs e)
        {
            this.Legolas_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Empty;
            this.Aragorn_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Empty;
            this.Gandalf_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Empty;
            this.Gimli_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Ring_Text;
            p1 = 4;
            this.Title.ForeColor = Color.Gold;
            this.Description.Text = "A stubborn dwarf hailing from Erebor. Not very agile but definitely hits hardest.";
        }

        private void Return_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Visible = false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

    }
}
