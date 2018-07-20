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
            this.actionCountLabel = new System.Windows.Forms.Label();
            this.defendButton = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.turnIndicator = new System.Windows.Forms.Button();
            this.endTurnButton = new System.Windows.Forms.Button();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.modifierPanel = new System.Windows.Forms.Panel();
            this.modifierLabel = new System.Windows.Forms.Label();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.action1Label = new System.Windows.Forms.Label();
            this.action2Label = new System.Windows.Forms.Label();
            this.enemyModPanel = new System.Windows.Forms.Panel();
            this.enemyModLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endGamePanel = new System.Windows.Forms.Panel();
            this.endTextLabel = new System.Windows.Forms.Label();
            this.endGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Char1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Char2)).BeginInit();
            this.attackPanel.SuspendLayout();
            this.statPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.modifierPanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.enemyModPanel.SuspendLayout();
            this.endGamePanel.SuspendLayout();
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
            this.Debug.Location = new System.Drawing.Point(325, 166);
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
            this.Timer.Location = new System.Drawing.Point(12, 0);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(113, 37);
            this.Timer.TabIndex = 5;
            this.Timer.Text = "00:00:000";
            // 
            // playerDamage
            // 
            this.playerDamage.AutoSize = true;
            this.playerDamage.BackColor = System.Drawing.Color.Transparent;
            this.playerDamage.Font = new System.Drawing.Font("Gigi", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerDamage.ForeColor = System.Drawing.Color.Gold;
            this.playerDamage.Location = new System.Drawing.Point(12, 65);
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
            this.playerDefense.Location = new System.Drawing.Point(12, 102);
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
            this.attack5.Font = new System.Drawing.Font("Gigi", 20F);
            this.attack5.ForeColor = System.Drawing.Color.Gold;
            this.attack5.Location = new System.Drawing.Point(780, 12);
            this.attack5.Name = "attack5";
            this.attack5.Size = new System.Drawing.Size(186, 111);
            this.attack5.TabIndex = 18;
            this.attack5.Text = "Attack 5";
            this.attack5.UseVisualStyleBackColor = false;
            this.attack5.Click += new System.EventHandler(this.attack5_Click);
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
            this.attack4.Font = new System.Drawing.Font("Gigi", 20F);
            this.attack4.ForeColor = System.Drawing.Color.Gold;
            this.attack4.Location = new System.Drawing.Point(588, 12);
            this.attack4.Name = "attack4";
            this.attack4.Size = new System.Drawing.Size(186, 111);
            this.attack4.TabIndex = 17;
            this.attack4.Text = "Attack 4";
            this.attack4.UseVisualStyleBackColor = false;
            this.attack4.Click += new System.EventHandler(this.attack4_Click);
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
            this.attack3.Font = new System.Drawing.Font("Gigi", 20F);
            this.attack3.ForeColor = System.Drawing.Color.Gold;
            this.attack3.Location = new System.Drawing.Point(396, 12);
            this.attack3.Name = "attack3";
            this.attack3.Size = new System.Drawing.Size(186, 111);
            this.attack3.TabIndex = 16;
            this.attack3.Text = "Attack 3";
            this.attack3.UseVisualStyleBackColor = false;
            this.attack3.Click += new System.EventHandler(this.attack3_Click);
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
            this.attack2.Click += new System.EventHandler(this.attack2_Click);
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
            this.statPanel.Controls.Add(this.actionCountLabel);
            this.statPanel.Controls.Add(this.Timer);
            this.statPanel.Controls.Add(this.playerDamage);
            this.statPanel.Controls.Add(this.playerDefense);
            this.statPanel.Location = new System.Drawing.Point(12, 12);
            this.statPanel.Name = "statPanel";
            this.statPanel.Size = new System.Drawing.Size(280, 139);
            this.statPanel.TabIndex = 11;
            // 
            // actionCountLabel
            // 
            this.actionCountLabel.AutoSize = true;
            this.actionCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.actionCountLabel.Font = new System.Drawing.Font("Gigi", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionCountLabel.ForeColor = System.Drawing.Color.Gold;
            this.actionCountLabel.Location = new System.Drawing.Point(15, 28);
            this.actionCountLabel.Name = "actionCountLabel";
            this.actionCountLabel.Size = new System.Drawing.Size(240, 37);
            this.actionCountLabel.TabIndex = 9;
            this.actionCountLabel.Text = "Actions Remaining:";
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
            this.controlPanel.Controls.Add(this.turnIndicator);
            this.controlPanel.Controls.Add(this.endTurnButton);
            this.controlPanel.Controls.Add(this.defendButton);
            this.controlPanel.Controls.Add(this.attackButton);
            this.controlPanel.Location = new System.Drawing.Point(439, 544);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(441, 190);
            this.controlPanel.TabIndex = 13;
            // 
            // turnIndicator
            // 
            this.turnIndicator.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.turnIndicator.BackColor = System.Drawing.Color.Transparent;
            this.turnIndicator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.turnIndicator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.turnIndicator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turnIndicator.Font = new System.Drawing.Font("Gigi", 20F);
            this.turnIndicator.ForeColor = System.Drawing.Color.Green;
            this.turnIndicator.Location = new System.Drawing.Point(230, 109);
            this.turnIndicator.Name = "turnIndicator";
            this.turnIndicator.Size = new System.Drawing.Size(161, 66);
            this.turnIndicator.TabIndex = 14;
            this.turnIndicator.Text = "Your Turn";
            this.turnIndicator.UseVisualStyleBackColor = false;
            // 
            // endTurnButton
            // 
            this.endTurnButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.endTurnButton.BackColor = System.Drawing.Color.Transparent;
            this.endTurnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.endTurnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.endTurnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endTurnButton.Font = new System.Drawing.Font("Gigi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTurnButton.ForeColor = System.Drawing.Color.Gold;
            this.endTurnButton.Location = new System.Drawing.Point(46, 109);
            this.endTurnButton.Name = "endTurnButton";
            this.endTurnButton.Size = new System.Drawing.Size(161, 66);
            this.endTurnButton.TabIndex = 13;
            this.endTurnButton.Text = "End Turn";
            this.endTurnButton.UseVisualStyleBackColor = false;
            this.endTurnButton.Click += new System.EventHandler(this.endTurnButton_Click);
            // 
            // detailsPanel
            // 
            this.detailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsPanel.BackColor = System.Drawing.Color.Black;
            this.detailsPanel.Controls.Add(this.detailsLabel);
            this.detailsPanel.Location = new System.Drawing.Point(12, 12);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(280, 139);
            this.detailsPanel.TabIndex = 14;
            this.detailsPanel.Visible = false;
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.BackColor = System.Drawing.Color.Transparent;
            this.detailsLabel.Font = new System.Drawing.Font("Gigi", 18F);
            this.detailsLabel.ForeColor = System.Drawing.Color.Gold;
            this.detailsLabel.Location = new System.Drawing.Point(3, 9);
            this.detailsLabel.MaximumSize = new System.Drawing.Size(280, 150);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(75, 33);
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
            this.modifierPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.modifierPanel_Paint);
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
            this.modifierLabel.Size = new System.Drawing.Size(0, 41);
            this.modifierLabel.TabIndex = 0;
            // 
            // actionPanel
            // 
            this.actionPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.actionPanel.BackColor = System.Drawing.Color.Black;
            this.actionPanel.Controls.Add(this.action1Label);
            this.actionPanel.Controls.Add(this.action2Label);
            this.actionPanel.Location = new System.Drawing.Point(439, 413);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(441, 124);
            this.actionPanel.TabIndex = 16;
            this.actionPanel.Visible = false;
            // 
            // action1Label
            // 
            this.action1Label.AutoSize = true;
            this.action1Label.BackColor = System.Drawing.Color.Transparent;
            this.action1Label.Font = new System.Drawing.Font("Gigi", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action1Label.ForeColor = System.Drawing.Color.Gold;
            this.action1Label.Location = new System.Drawing.Point(9, 76);
            this.action1Label.Name = "action1Label";
            this.action1Label.Size = new System.Drawing.Size(0, 37);
            this.action1Label.TabIndex = 10;
            // 
            // action2Label
            // 
            this.action2Label.AutoSize = true;
            this.action2Label.BackColor = System.Drawing.Color.Transparent;
            this.action2Label.Font = new System.Drawing.Font("Gigi", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action2Label.ForeColor = System.Drawing.Color.Gray;
            this.action2Label.Location = new System.Drawing.Point(9, 16);
            this.action2Label.Name = "action2Label";
            this.action2Label.Size = new System.Drawing.Size(110, 37);
            this.action2Label.TabIndex = 9;
            this.action2Label.Text = "Action2";
            // 
            // enemyModPanel
            // 
            this.enemyModPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enemyModPanel.BackColor = System.Drawing.Color.Black;
            this.enemyModPanel.Controls.Add(this.enemyModLabel);
            this.enemyModPanel.Controls.Add(this.label1);
            this.enemyModPanel.Location = new System.Drawing.Point(992, 157);
            this.enemyModPanel.Name = "enemyModPanel";
            this.enemyModPanel.Size = new System.Drawing.Size(280, 150);
            this.enemyModPanel.TabIndex = 16;
            this.enemyModPanel.Visible = false;
            // 
            // enemyModLabel
            // 
            this.enemyModLabel.AutoSize = true;
            this.enemyModLabel.BackColor = System.Drawing.Color.Transparent;
            this.enemyModLabel.Font = new System.Drawing.Font("Gigi", 18F);
            this.enemyModLabel.ForeColor = System.Drawing.Color.Gold;
            this.enemyModLabel.Location = new System.Drawing.Point(9, 9);
            this.enemyModLabel.MaximumSize = new System.Drawing.Size(280, 150);
            this.enemyModLabel.Name = "enemyModLabel";
            this.enemyModLabel.Size = new System.Drawing.Size(75, 33);
            this.enemyModLabel.TabIndex = 1;
            this.enemyModLabel.Text = "Blyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gigi", 22F);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.MaximumSize = new System.Drawing.Size(280, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 41);
            this.label1.TabIndex = 0;
            // 
            // endGamePanel
            // 
            this.endGamePanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.endGamePanel.BackColor = System.Drawing.Color.Black;
            this.endGamePanel.Controls.Add(this.endGameButton);
            this.endGamePanel.Controls.Add(this.endTextLabel);
            this.endGamePanel.Location = new System.Drawing.Point(439, 170);
            this.endGamePanel.MaximumSize = new System.Drawing.Size(440, 227);
            this.endGamePanel.Name = "endGamePanel";
            this.endGamePanel.Size = new System.Drawing.Size(440, 227);
            this.endGamePanel.TabIndex = 17;
            this.endGamePanel.Visible = false;
            this.endGamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // endTextLabel
            // 
            this.endTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endTextLabel.AutoSize = true;
            this.endTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.endTextLabel.Font = new System.Drawing.Font("Gigi", 38F);
            this.endTextLabel.ForeColor = System.Drawing.Color.Gold;
            this.endTextLabel.Location = new System.Drawing.Point(4, 13);
            this.endTextLabel.MaximumSize = new System.Drawing.Size(450, 150);
            this.endTextLabel.Name = "endTextLabel";
            this.endTextLabel.Size = new System.Drawing.Size(418, 70);
            this.endTextLabel.TabIndex = 1;
            this.endTextLabel.Text = "You won the Fight";
            // 
            // endGameButton
            // 
            this.endGameButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.endGameButton.BackColor = System.Drawing.Color.Transparent;
            this.endGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.endGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.endGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endGameButton.Font = new System.Drawing.Font("Gigi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endGameButton.ForeColor = System.Drawing.Color.Gold;
            this.endGameButton.Location = new System.Drawing.Point(72, 102);
            this.endGameButton.Name = "endGameButton";
            this.endGameButton.Size = new System.Drawing.Size(301, 107);
            this.endGameButton.TabIndex = 15;
            this.endGameButton.Text = "To the next Fight!";
            this.endGameButton.UseVisualStyleBackColor = false;
            this.endGameButton.Click += new System.EventHandler(this.endGameButton_Click);
            // 
            // Battlescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Realest_Fitty_Game.Properties.Resources.Orc_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 731);
            this.Controls.Add(this.Debug);
            this.Controls.Add(this.endGamePanel);
            this.Controls.Add(this.enemyModPanel);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.modifierPanel);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.statPanel);
            this.Controls.Add(this.attackPanel);
            this.Controls.Add(this.Char2HP);
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
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.modifierPanel.ResumeLayout(false);
            this.modifierPanel.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.actionPanel.PerformLayout();
            this.enemyModPanel.ResumeLayout(false);
            this.enemyModPanel.PerformLayout();
            this.endGamePanel.ResumeLayout(false);
            this.endGamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Char1;
        private System.Windows.Forms.PictureBox Char2;
        private System.Windows.Forms.ProgressBar Char1HP;
        private System.Windows.Forms.Button Debug;
        private System.Windows.Forms.ProgressBar Char2HP;
        private System.Windows.Forms.Label Timer;
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
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Label action1Label;
        private System.Windows.Forms.Label action2Label;
        private System.Windows.Forms.Label actionCountLabel;
        private System.Windows.Forms.Button turnIndicator;
        private System.Windows.Forms.Button endTurnButton;
        private System.Windows.Forms.Panel enemyModPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label enemyModLabel;
        private System.Windows.Forms.Panel endGamePanel;
        private System.Windows.Forms.Label endTextLabel;
        private System.Windows.Forms.Button endGameButton;
    }
}

