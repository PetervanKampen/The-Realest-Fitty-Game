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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            new Select().Show();
            this.Visible = false;
        }

        private void Settings_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
