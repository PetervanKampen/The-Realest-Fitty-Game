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
        private Info data;

        public Menu(Info data_)
        {
            data = data_;
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (data.getScreen())
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            //new Select(data).Show();
            Form select = new Select(data);

            select.Show();
            this.Hide();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            //new Settings(data).Show();
            Form setting = new Settings(data);
            
            setting.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!data.getScreen())
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
