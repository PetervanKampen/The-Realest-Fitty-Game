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
    public partial class Settings : Form
    {
        private Info data;

        public Settings(Info data_)
        {
            data = data_;
            InitializeComponent();
        }

        private void SoundBox_CheckedChanged(object sender, EventArgs e)
        {
            if(SoundBox.Checked)
            {
                SoundBox.Text = "Sound: <- ON    ->";              
            } 
            else if(!SoundBox.Checked)
            {
                SoundBox.Text = "Sound: <- OFF ->";              
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!data.getScreen())
            {
            //    System.Windows.Forms.Application.Exit();
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            data.setSound(SoundBox.Checked);

            /*new Menu(data).Show();
            this.Visible = false;*/

            Form menu = new Menu(data);
          
            menu.ShowDialog();
            this.Dispose();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;           
        }

        
    }
}
