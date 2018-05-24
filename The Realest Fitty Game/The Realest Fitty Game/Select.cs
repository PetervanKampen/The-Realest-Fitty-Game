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
        private Info data;

        public Select(Info data_)
        {
            data = data_;
            InitializeComponent();
        }


        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (data.playerchar != null)
            {
                Form battle =  new Battlescreen(data, true);

                battle.ShowDialog();
                this.Dispose();
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
            data.playerchar = new Gandalf();
            this.Title.ForeColor = Color.Gold;
            this.Description.Text = data.playerchar.getDescription();
        }

        private void Aragorn_Button_Click(object sender, EventArgs e)
        {
            this.Gandalf_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Empty;
            this.Gimli_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Empty;
            this.Legolas_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Empty;
            this.Aragorn_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Ring_Text;
            data.playerchar = new Aragorn();
            this.Title.ForeColor = Color.Gold;
            this.Description.Text = data.playerchar.getDescription();
        }

        private void Legolas_Button_Click(object sender, EventArgs e)
        {
            this.Gimli_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Empty;
            this.Aragorn_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Empty;
            this.Gandalf_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Empty;
            this.Legolas_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Ring_Text;
            data.playerchar = new Legolas();
            this.Title.ForeColor = Color.Gold;
            this.Description.Text = data.playerchar.getDescription();
        }

        private void Gimli_Button_Click(object sender, EventArgs e)
        {
            this.Legolas_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Empty;
            this.Aragorn_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Empty;
            this.Gandalf_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Empty;
            this.Gimli_Button.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Ring_Text;
            data.playerchar = new Gimli();
            this.Title.ForeColor = Color.Gold;
            this.Description.Text = data.playerchar.getDescription();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Form menu = new Menu(data);

            menu.ShowDialog();
            this.Dispose();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
        //    System.Windows.Forms.Application.Exit();
        }

        private void Select_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
