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
            ((System.ComponentModel.ISupportInitialize)(this.Char1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Char2)).BeginInit();
            this.SuspendLayout();
            // 
            // Char1
            // 
            this.Char1.BackColor = System.Drawing.Color.Transparent;
            this.Char1.Image = global::The_Realest_Fitty_Game.Properties.Resources.Gandalf;
            this.Char1.Location = new System.Drawing.Point(98, 367);
            this.Char1.Name = "Char1";
            this.Char1.Size = new System.Drawing.Size(205, 308);
            this.Char1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Char1.TabIndex = 0;
            this.Char1.TabStop = false;
            // 
            // Char2
            // 
            this.Char2.BackColor = System.Drawing.Color.Transparent;
            this.Char2.Image = global::The_Realest_Fitty_Game.Properties.Resources.Saruman;
            this.Char2.Location = new System.Drawing.Point(967, 367);
            this.Char2.Name = "Char2";
            this.Char2.Size = new System.Drawing.Size(236, 308);
            this.Char2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Char2.TabIndex = 1;
            this.Char2.TabStop = false;
            // 
            // Battlescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Battle_Background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 731);
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
    }
}

