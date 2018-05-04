namespace The_Realest_Fitty_Game
{
    partial class Battlescreen
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
            this.Char1 = new System.Windows.Forms.PictureBox();
            this.Char2 = new System.Windows.Forms.PictureBox();
            this.Char1HP = new System.Windows.Forms.ProgressBar();
            this.Debug = new System.Windows.Forms.Button();
            this.Char2HP = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.Char1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Char2)).BeginInit();
            this.SuspendLayout();
            // 
            // Char1
            // 
            this.Char1.BackColor = System.Drawing.Color.Transparent;
            this.Char1.Image = global::The_Realest_Fitty_Game.Properties.Resources.Gandalf;           
            this.Char1.Location = new System.Drawing.Point(98, 241);
            this.Char1.Name = "Char1";
            this.Char1.Size = new System.Drawing.Size(276, 434);
            this.Char1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Char1.TabIndex = 0;
            this.Char1.TabStop = false;
            // 
            // Char2
            // 
            this.Char2.BackColor = System.Drawing.Color.Transparent;
            this.Char2.Image = global::The_Realest_Fitty_Game.Properties.Resources.Saruman;
            this.Char2.Location = new System.Drawing.Point(888, 241);
            this.Char2.Name = "Char2";
            this.Char2.Size = new System.Drawing.Size(315, 434);
            this.Char2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Char2.TabIndex = 1;
            this.Char2.TabStop = false;
            // 
            // Char1HP
            // 
            this.Char1HP.BackColor = System.Drawing.Color.White;
            this.Char1HP.Cursor = System.Windows.Forms.Cursors.Default;
            this.Char1HP.ForeColor = System.Drawing.Color.Green;
            this.Char1HP.Location = new System.Drawing.Point(12, 696);
            this.Char1HP.Name = "Char1HP";
            this.Char1HP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Char1HP.Size = new System.Drawing.Size(600, 23);
            this.Char1HP.Step = -5;
            this.Char1HP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Char1HP.TabIndex = 1;
            this.Char1HP.Value = 100;
            // 
            // Debug
            // 
            this.Debug.Location = new System.Drawing.Point(421, 260);
            this.Debug.Name = "Debug";
            this.Debug.Size = new System.Drawing.Size(75, 23);
            this.Debug.TabIndex = 3;
            this.Debug.Text = "Debug";
            this.Debug.UseVisualStyleBackColor = true;
            this.Debug.Click += new System.EventHandler(this.Debug_Click);
            // 
            // Char2HP
            // 
            this.Char2HP.BackColor = System.Drawing.Color.White;
            this.Char2HP.Cursor = System.Windows.Forms.Cursors.Default;
            this.Char2HP.ForeColor = System.Drawing.Color.Red;
            this.Char2HP.Location = new System.Drawing.Point(672, 696);
            this.Char2HP.Name = "Char2HP";
            this.Char2HP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Char2HP.RightToLeftLayout = true;
            this.Char2HP.Size = new System.Drawing.Size(600, 23);
            this.Char2HP.Step = -5;
            this.Char2HP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Char2HP.TabIndex = 4;
            this.Char2HP.Value = 100;
            // 
            // Battlescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Battle_Background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 731);
            this.Controls.Add(this.Char2HP);
            this.Controls.Add(this.Debug);
            this.Controls.Add(this.Char1HP);
            this.Controls.Add(this.Char2);
            this.Controls.Add(this.Char1);
            this.Name = "Battlescreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Battlescreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Char1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Char2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Char1;
        private System.Windows.Forms.PictureBox Char2;
        private System.Windows.Forms.ProgressBar Char1HP;
        private System.Windows.Forms.Button Debug;
        private System.Windows.Forms.ProgressBar Char2HP;
    }
}

