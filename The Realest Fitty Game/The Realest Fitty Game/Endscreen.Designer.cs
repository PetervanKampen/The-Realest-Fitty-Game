namespace The_Realest_Fitty_Game
{
    partial class Endscreen
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
            this.Title = new System.Windows.Forms.Label();
            this.Timelabel = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.Portrait = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Portrait)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Gigi", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Gold;
            this.Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(276, 83);
            this.Title.TabIndex = 5;
            this.Title.Text = "Game Over";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.BackColor = System.Drawing.Color.Transparent;
            this.Timelabel.Font = new System.Drawing.Font("Gigi", 28F);
            this.Timelabel.ForeColor = System.Drawing.Color.Gold;
            this.Timelabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Timelabel.Location = new System.Drawing.Point(12, 127);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(199, 53);
            this.Timelabel.TabIndex = 6;
            this.Timelabel.Text = "It took you:";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.Transparent;
            this.Time.Font = new System.Drawing.Font("Gigi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.Gold;
            this.Time.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Time.Location = new System.Drawing.Point(12, 192);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(134, 44);
            this.Time.TabIndex = 7;
            this.Time.Text = "00:00:000";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Ring_Text;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Gigi", 36F);
            this.Exit.ForeColor = System.Drawing.Color.Gold;
            this.Exit.Location = new System.Drawing.Point(1027, 587);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(245, 132);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.Transparent;
            this.MenuButton.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Ring_Text;
            this.MenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuButton.FlatAppearance.BorderSize = 0;
            this.MenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.Font = new System.Drawing.Font("Gigi", 36F);
            this.MenuButton.ForeColor = System.Drawing.Color.Gold;
            this.MenuButton.Location = new System.Drawing.Point(1027, 429);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(245, 132);
            this.MenuButton.TabIndex = 13;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Portrait
            // 
            this.Portrait.BackColor = System.Drawing.Color.Transparent;
            this.Portrait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Portrait.Location = new System.Drawing.Point(454, 183);
            this.Portrait.Name = "Portrait";
            this.Portrait.Size = new System.Drawing.Size(355, 355);
            this.Portrait.TabIndex = 14;
            this.Portrait.TabStop = false;
            this.Portrait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // Endscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Menu_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 731);
            this.Controls.Add(this.Portrait);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Timelabel);
            this.Controls.Add(this.Title);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Endscreen";
            this.Text = "Endscreen";
            ((System.ComponentModel.ISupportInitialize)(this.Portrait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.PictureBox Portrait;
    }
}