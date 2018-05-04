namespace The_Realest_Fitty_Game
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Settings_Title = new System.Windows.Forms.Label();
            this.SoundBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Settings_Title
            // 
            this.Settings_Title.AutoSize = true;
            this.Settings_Title.BackColor = System.Drawing.Color.Transparent;
            this.Settings_Title.Font = new System.Drawing.Font("Gigi", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_Title.ForeColor = System.Drawing.Color.Gold;
            this.Settings_Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Settings_Title.Location = new System.Drawing.Point(517, 9);
            this.Settings_Title.Name = "Settings_Title";
            this.Settings_Title.Size = new System.Drawing.Size(238, 83);
            this.Settings_Title.TabIndex = 5;
            this.Settings_Title.Text = "Settings";
            // 
            // SoundBox
            // 
            this.SoundBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SoundBox.AutoSize = true;
            this.SoundBox.BackColor = System.Drawing.Color.Transparent;
            this.SoundBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SoundBox.Checked = true;
            this.SoundBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SoundBox.FlatAppearance.BorderSize = 0;
            this.SoundBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.SoundBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SoundBox.Font = new System.Drawing.Font("Gigi", 45F);
            this.SoundBox.ForeColor = System.Drawing.Color.Gold;
            this.SoundBox.Location = new System.Drawing.Point(420, 216);
            this.SoundBox.Name = "SoundBox";
            this.SoundBox.Size = new System.Drawing.Size(429, 93);
            this.SoundBox.TabIndex = 7;
            this.SoundBox.Text = "Sound: <- ON ->";
            this.SoundBox.UseVisualStyleBackColor = false;
            this.SoundBox.CheckedChanged += new System.EventHandler(this.SoundBox_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 731);
            this.Controls.Add(this.SoundBox);
            this.Controls.Add(this.Settings_Title);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Settings";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Settings_Title;
        private System.Windows.Forms.CheckBox SoundBox;
    }
}