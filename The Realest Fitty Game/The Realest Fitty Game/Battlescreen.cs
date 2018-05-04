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
        private int p1;
        private Info data;

        public Battlescreen(int p1_, Info data_)
        {
            p1 = p1_;
            data = data_;   
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            if (p1 == 1)
            {
                this.Char1.Image = global::The_Realest_Fitty_Game.Properties.Resources.Gandalf;
            }
            else if (p1 == 2)
            {
                this.Char1.Image = global::The_Realest_Fitty_Game.Properties.Resources.Aragorn;
            }
            else if (p1 == 3)
            {
                this.Char1.Image = global::The_Realest_Fitty_Game.Properties.Resources.Legolas;
            }
            else if (p1 == 4)
            {
                this.Char1.Image = global::The_Realest_Fitty_Game.Properties.Resources.Gimli;
            }
        }

        private void Battlescreen_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
