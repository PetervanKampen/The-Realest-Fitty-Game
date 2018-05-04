﻿using System;
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
                SoundBox.Text = "Sound: <- ON ->";
                data.setSound(SoundBox.Checked);
            } 
            else if(!SoundBox.Checked)
            {
                SoundBox.Text = "Sound: <- OFF ->";
                data.setSound(SoundBox.Checked);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}