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
            this.Timer = new System.Windows.Forms.Label();
            this.Turn = new System.Windows.Forms.Label();
            this.playerDamage = new System.Windows.Forms.Label();
            this.playerDefense = new System.Windows.Forms.Label();
            this.attackPanel = new System.Windows.Forms.Panel();
            this.attack5 = new System.Windows.Forms.Button();
            this.attack4 = new System.Windows.Forms.Button();
            this.attack3 = new System.Windows.Forms.Button();
            this.attack2 = new System.Windows.Forms.Button();
            this.attack1 = new System.Windows.Forms.Button();
            this.attackButton = new System.Windows.Forms.Button();
            this.statPanel = new System.Windows.Forms.Panel();
            this.defendButton = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.modifierPanel = new System.Windows.Forms.Panel();
            this.modifierLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Char1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Char2)).BeginInit();
            this.attackPanel.SuspendLayout();
            this.statPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.modifierPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Char1
            // 
            this.Char1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Char1.BackColor = System.Drawing.Color.Transparent;
            this.Char1.Image = global::The_Realest_Fitty_Game.Properties.Resources.Gandalf;
            this.Char1.Location = new System.Drawing.Point(65, 157);
            this.Char1.Name = "Char1";
            this.Char1.Size = new System.Drawing.Size(350, 500);
            this.Char1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Char1.TabIndex = 0;
            this.Char1.TabStop = false;
            // 
            // Char2
            // 
            this.Char2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Char2.BackColor = System.Drawing.Color.Transparent;
            this.Char2.Image = global::The_Realest_Fitty_Game.Properties.Resources.Saruman;
            this.Char2.Location = new System.Drawing.Point(900, 157);
            this.Char2.Name = "Char2";
            this.Char2.Size = new System.Drawing.Size(350, 500);
            this.Char2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Char2.TabIndex = 1;
            this.Char2.TabStop = false;
            // 
            // Char1HP
            // 
            this.Char1HP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.Debug.Location = new System.Drawing.Point(613, 515);
            this.Debug.Name = "Debug";
            this.Debug.Size = new System.Drawing.Size(75, 23);
            this.Debug.TabIndex = 3;
            this.Debug.Text = "Debug";
            this.Debug.UseVisualStyleBackColor = true;
            this.Debug.Click += new System.EventHandler(this.Debug_Click);
            // 
            // Char2HP
            // 
            this.Char2HP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.BackColor = System.Drawing.Color.Transparent;
            this.Timer.Font = new System.Drawing.Font("Gigi", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.ForeColor = System.Drawing.Color.Gold;
            this.Timer.Location = new System.Drawing.Point(15, 13);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(113, 37);
            this.Timer.TabIndex = 5;
            this.Timer.Text = "00:00:000";
            // 
            // Turn
            // 
            this.Turn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Turn.AutoSize = true;
            this.Turn.BackColor = System.Drawing.Color.Transparent;
            this.Turn.Font = new System.Drawing.Font("Gigi", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turn.ForeColor = System.Drawing.Color.Gold;
            this.Turn.Location = new System.Drawing.Point(31, 93);
            this.Turn.Name = "Turn";
            this.Turn.Size = new System.Drawing.Size(377, 85);
            this.Turn.TabIndex = 6;
            this.Turn.Text = "YOUR TURN";
            // 
            // playerDamage
            // 
            this.playerDamage.AutoSize = true;
            this.playerDamage.BackColor = System.Drawing.Color.Transparent;
            this.playerDamage.Font = new System.Drawing.Font("Gigi", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerDamage.ForeColor = System.Drawing.Color.Gold;
            this.playerDamage.Location = new System.Drawing.Point(12, 62);
            this.playerDamage.Name = "playerDamage";
            this.playerDamage.Size = new System.Drawing.Size(195, 37);
            this.playerDamage.TabIndex = 7;
            this.playerDamage.Text = "Attack Damage: ";
            // 
            // playerDefense
            // 
            this.playerDefense.AutoSize = true;
            this.playerDefense.BackColor = System.Drawing.Color.Transparent;
            this.playerDefense.Font = new System.Drawing.Font("Gigi", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerDefense.ForeColor = System.Drawing.Color.Gold;
            this.playerDefense.Location = new System.Drawing.Point(12, 93);
            this.playerDefense.Name = "playerDefense";
            this.playerDefense.Size = new System.Drawing.Size(198, 37);
            this.playerDefense.TabIndex = 8;
            this.playerDefense.Text = "Defense Rating: ";
            this.playerDefense.Click += new System.EventHandler(this.playerDefense_Click);
            // 
            // attackPanel
            // 
            this.attackPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.attackPanel.BackColor = System.Drawing.Color.Black;
            this.attackPanel.Controls.Add(this.attack5);
            this.attackPanel.Controls.Add(this.attack4);
            this.attackPanel.Controls.Add(this.attack3);
            this.attackPanel.Controls.Add(this.attack2);
            this.attackPanel.Controls.Add(this.attack1);
            this.attackPanel.Location = new System.Drawing.Point(298, 12);
            this.attackPanel.Name = "attackPanel";
            this.attackPanel.Size = new System.Drawing.Size(974, 139);
            this.attackPanel.TabIndex = 9;
            this.attackPanel.Visible = false;
            // 
            // attack5
            // 
            this.attack5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.attack5.BackColor = System.Drawing.Color.Transparent;
            this.attack5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.attack5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.attack5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attack5.Font = new System.Drawing.Font("Gigi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attack5.ForeColor = System.Drawing.Color.Gold;
            this.attack5.Location = new System.Drawing.Point(780, 12);
            this.attack5.Name = "attack5";
            this.attack5.Size = new System.Drawing.Size(186, 111);
            this.attack5.TabIndex = 18;
            this.attack5.Text = "Attack 5";
            this.attack5.UseVisualStyleBackColor = false;
            this.attack5.MouseLeave += new System.EventHandler(this.attackLeave);
            this.attack5.MouseHover += new System.EventHandler(this.attack5Hover);
            // 
            // attack4
            // 
            this.attack4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.attack4.BackColor = System.Drawing.Color.Transparent;
            this.attack4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.attack4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.attack4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attack4.Font = new System.Drawing.Font("Gigi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attack4.ForeColor = System.Drawing.Color.Gold;
            this.attack4.Location = new System.Drawing.Point(588, 12);
            this.attack4.Name = "attack4";
            this.attack4.Size = new System.Drawing.Size(186, 111);
            this.attack4.TabIndex = 17;
            this.attack4.Text = "Attack 4";
            this.attack4.UseVisualStyleBackColor = false;
            this.attack4.MouseLeave += new System.EventHandler(this.attackLeave);
            this.attack4.MouseHover += new System.EventHandler(this.attack4Hover);
            // 
            // attack3
            // 
            this.attack3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.attack3.BackColor = System.Drawing.Color.Transparent;
            this.attack3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.attack3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.attack3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attack3.Font = new System.Drawing.Font("Gigi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attack3.ForeColor = System.Drawing.Color.Gold;
            this.attack3.Location = new System.Drawing.Point(396, 12);
            this.attack3.Name = "attack3";
            this.attack3.Size = new System.Drawing.Size(186, 111);
            this.attack3.TabIndex = 16;
            this.attack3.Text = "Attack 3";
            this.attack3.UseVisualStyleBackColor = false;
            this.attack3.MouseLeave += new System.EventHandler(this.attackLeave);
            this.attack3.MouseHover += new System.EventHandler(this.attack3Hover);
            // 
            // attack2
            // 
            this.attack2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.attack2.BackColor = System.Drawing.Color.Transparent;
            this.attack2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.attack2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.attack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attack2.Font = new System.Drawing.Font("Gigi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attack2.ForeColor = System.Drawing.Color.Gold;
            this.attack2.Location = new System.Drawing.Point(204, 12);
            this.attack2.Name = "attack2";
            this.attack2.Size = new System.Drawing.Size(186, 111);
            this.attack2.TabIndex = 14;
            this.attack2.Text = "Heavy Attack";
            this.attack2.UseVisualStyleBackColor = false;
            this.attack2.MouseLeave += new System.EventHandler(this.attackLeave);
            this.attack2.MouseHover += new System.EventHandler(this.attack2Hover);
            // 
            // attack1
            // 
            this.attack1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attack1.BackColor = System.Drawing.Color.Transparent;
            this.attack1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.attack1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.attack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attack1.Font = new System.Drawing.Font("Gigi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attack1.ForeColor = System.Drawing.Color.Gold;
            this.attack1.Location = new System.Drawing.Point(12, 12);
            this.attack1.Name = "attack1";
            this.attack1.Size = new System.Drawing.Size(186, 111);
            this.attack1.TabIndex = 13;
            this.attack1.Text = "Light Attack";
            this.attack1.UseVisualStyleBackColor = false;
            this.attack1.Click += new System.EventHandler(this.attack1_Click);
            this.attack1.MouseLeave += new System.EventHandler(this.attackLeave);
            this.attack1.MouseHover += new System.EventHandler(this.attack1Hover);
            // 
            // attackButton
            // 
            this.attackButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.attackButton.BackColor = System.Drawing.Color.Transparent;
            this.attackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.attackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.attackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attackButton.Font = new System.Drawing.Font("Gigi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackButton.ForeColor = System.Drawing.Color.Gold;
            this.attackButton.Location = new System.Drawing.Point(46, 15);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(161, 66);
            this.attackButton.TabIndex = 10;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = false;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // statPanel
            // 
            this.statPanel.BackColor = System.Drawing.Color.Black;
            this.statPanel.Controls.Add(this.Timer);
            this.statPanel.Controls.Add(this.playerDamage);
            this.statPanel.Controls.Add(this.playerDefense);
            this.statPanel.Location = new System.Drawing.Point(12, 12);
            this.statPanel.Name = "statPanel";
            this.statPanel.Size = new System.Drawing.Size(280, 139);
            this.statPanel.TabIndex = 11;
            // 
            // defendButton
            // 
            this.defendButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.defendButton.BackColor = System.Drawing.Color.Transparent;
            this.defendButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.defendButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.defendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defendButton.Font = new System.Drawing.Font("Gigi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defendButton.ForeColor = System.Drawing.Color.Gold;
            this.defendButton.Location = new System.Drawing.Point(230, 15);
            this.defendButton.Name = "defendButton";
            this.defendButton.Size = new System.Drawing.Size(161, 66);
            this.defendButton.TabIndex = 12;
            this.defendButton.Text = "Defend";
            this.defendButton.UseVisualStyleBackColor = false;
            this.defendButton.Click += new System.EventHandler(this.defendButton_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.controlPanel.BackColor = System.Drawing.Color.Black;
            this.controlPanel.Controls.Add(this.defendButton);
            this.controlPanel.Controls.Add(this.attackButton);
            this.controlPanel.Controls.Add(this.Turn);
            this.controlPanel.Location = new System.Drawing.Point(439, 544);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(441, 190);
            this.controlPanel.TabIndex = 13;
            // 
            // detailsPanel
            // 
            this.detailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsPanel.BackColor = System.Drawing.Color.Black;
            this.detailsPanel.Controls.Add(this.detailsLabel);
            this.detailsPanel.Location = new System.Drawing.Point(992, 157);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(280, 150);
            this.detailsPanel.TabIndex = 14;
            this.detailsPanel.Visible = false;
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.BackColor = System.Drawing.Color.Transparent;
            this.detailsLabel.Font = new System.Drawing.Font("Gigi", 22F);
            this.detailsLabel.ForeColor = System.Drawing.Color.Gold;
            this.detailsLabel.Location = new System.Drawing.Point(3, 9);
            this.detailsLabel.MaximumSize = new System.Drawing.Size(280, 150);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(93, 41);
            this.detailsLabel.TabIndex = 0;
            this.detailsLabel.Text = "Blyat";
            // 
            // modifierPanel
            // 
            this.modifierPanel.BackColor = System.Drawing.Color.Black;
            this.modifierPanel.Controls.Add(this.modifierLabel);
            this.modifierPanel.Location = new System.Drawing.Point(12, 157);
            this.modifierPanel.Name = "modifierPanel";
            this.modifierPanel.Size = new System.Drawing.Size(280, 150);
            this.modifierPanel.TabIndex = 15;
            this.modifierPanel.Visible = false;
            // 
            // modifierLabel
            // 
            this.modifierLabel.AutoSize = true;
            this.modifierLabel.BackColor = System.Drawing.Color.Transparent;
            this.modifierLabel.Font = new System.Drawing.Font("Gigi", 22F);
            this.modifierLabel.ForeColor = System.Drawing.Color.Gold;
            this.modifierLabel.Location = new System.Drawing.Point(3, 9);
            this.modifierLabel.MaximumSize = new System.Drawing.Size(280, 150);
            this.modifierLabel.Name = "modifierLabel";
            this.modifierLabel.Size = new System.Drawing.Size(93, 41);
            this.modifierLabel.TabIndex = 0;
            this.modifierLabel.Text = "Blyat";
            // 
            // Battlescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Orc_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 731);
            this.Controls.Add(this.modifierPanel);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.statPanel);
            this.Controls.Add(this.attackPanel);
            this.Controls.Add(this.Char2HP);
            this.Controls.Add(this.Debug);
            this.Controls.Add(this.Char1HP);
            this.Controls.Add(this.Char2);
            this.Controls.Add(this.Char1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Battlescreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Battlescreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Char1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Char2)).EndInit();
            this.attackPanel.ResumeLayout(false);
            this.statPanel.ResumeLayout(false);
            this.statPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.modifierPanel.ResumeLayout(false);
            this.modifierPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Char1;
        private System.Windows.Forms.PictureBox Char2;
        private System.Windows.Forms.ProgressBar Char1HP;
        private System.Windows.Forms.Button Debug;
        private System.Windows.Forms.ProgressBar Char2HP;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Label Turn;
        private System.Windows.Forms.Label playerDamage;
        private System.Windows.Forms.Label playerDefense;
        private System.Windows.Forms.Panel attackPanel;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Panel statPanel;
        private System.Windows.Forms.Button defendButton;
        private System.Windows.Forms.Button attack5;
        private System.Windows.Forms.Button attack4;
        private System.Windows.Forms.Button attack3;
        private System.Windows.Forms.Button attack2;
        private System.Windows.Forms.Button attack1;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Panel modifierPanel;
        private System.Windows.Forms.Label modifierLabel;
    }
}

