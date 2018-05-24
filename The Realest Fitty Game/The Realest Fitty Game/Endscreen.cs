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
    public partial class Endscreen : Form
    {
        private Info data;
        private bool wonGame;

        public Endscreen(Info data_, bool win)
        {
            data = data_;
            data.timer.Stop();
            wonGame = win;

            InitializeComponent();
            Setup();
        }

        private void Title_Click(object sender, EventArgs e)
        {
            
        }

        private void Setup()
        {
            if (wonGame)
            {
                this.Title.Text = "You won the Game.";
                this.Timelabel.Text = "Besting the Game took you: ";
            }
            else
            {
                this.Title.Text = "You lost the Game";
                this.Timelabel.Text = "You lasted for: ";
            }

            this.Time.Text = getTime();
        //    this.Portrait.Image = data.playerchar.portrait;
        }

        private String getTime()
        {
            String time;

            long Millitime = (data.timer.ElapsedMilliseconds - data.GameStartTime) % 1000;
            long Sectime = (data.timer.ElapsedMilliseconds - data.GameStartTime) / 1000 % 60;
            long Mintime = (data.timer.ElapsedMilliseconds - data.GameStartTime) / 1000 / 60 % 60;

            time = data.NumParse(Mintime) + " Minutes\n" + data.NumParse(Sectime) + " Seconds\n"
                + data.NumParse(Millitime, true) + " Milliseconds";
            return time;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            /*new Menu(data).Show();
            data.reset();
            this.Visible = false;
            this.Close();*/
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Endscreen_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
