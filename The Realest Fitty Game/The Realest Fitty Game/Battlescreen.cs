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
            if (data.playerchar.getCharNum() == 4)
            {
                RescaleImage(Char1, 1.2, 0.8, false);
            }

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
                    Char2.Location = new Point(770, 38);
                    break;

                case 2:
                    data.enemychar = new Saruman();
                    BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Saruman_Background;
                    break;

                case 3:
                    data.enemychar = new Sauron();
                    BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Sauron_Background;
                    RescaleImage(Char2, 1.7, 1.7, true);
                    Char2.Location = new Point(770, 38);
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
                this.Char2HP.Value -= 100;
            }
            if (this.Char2HP.Value == 0)
            {
                if (data.enemychar.getCharNum() != 4)
                {
                    data.addCycle();
                }
                new Battlescreen(data).Show();
                this.Visible = false;
            }
        }

        public void RescaleImage(PictureBox image, double widthfactor, double heightfactor, bool enemy)
        {
            double newWidth = image.Width * widthfactor;
            double newHeight = image.Height * heightfactor;

            if (!enemy)
            {
                double diffWidth = (image.Width - newWidth);
                //double diffHeight = (image.Height - newHeight);

                image.Location = new Point((image.Location.X), (image.Location.Y - (int)diffWidth));
            }
            /*  else if (enemy)
              {
                  double diffWidth = 0;
                  double diffHeight = 0;
                  if (widthfactor > 1 || heightfactor > 1)
                  {
                      diffWidth = Math.Abs(image.Width - newWidth);
                      diffHeight = Math.Abs(image.Height - newHeight);

                      image.Location = new Point((image.Location.X - (int)diffHeight), (image.Location.Y - (int)diffWidth));
                  }
                  else
                  {
                      diffWidth = (image.Width - newWidth);
                      diffHeight = (image.Height - newHeight);

                      image.Location = new Point((image.Location.X + (int)diffHeight), (image.Location.Y + (int)diffWidth));
                  }

              }
  */
            image.Width = (int)newWidth;
            image.Height = (int)newHeight;
        }
    }
}
