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
        private int cycle;
        private Info data;

        public Battlescreen(Info data_)
        {
            data = data_;
            cycle = 0;
            InitializeComponent();
            Setup();

        }

        public Battlescreen(Info data_, int cycle_)
        {
            data = data_;
            cycle = cycle_;
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            this.Char1.Image = data.playerchar.sprite;
            switch (cycle)
            {
                case 0:

                    this.Char2.Image = global::The_Realest_Fitty_Game.Properties.Resources.Saruman; break;

                case 1:
                    this.Char2.Image = global::The_Realest_Fitty_Game.Properties.Resources.Sauron; break;
            }
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
        }
    }
}
