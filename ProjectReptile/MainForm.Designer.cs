namespace ProjectReptile
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UpButton = new Button();
            DownButton = new Button();
            LeftButton = new Button();
            RightButton = new Button();
            AttackButton = new Button();
            DefendButton = new Button();
            SorceryButton = new Button();
            SearchButton = new Button();
            TalkButton = new Button();
            StatsAndInvButton = new Button();
            GetItemButton = new Button();
            menuStrip1 = new MenuStrip();
            gameToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            MapGridPanel = new Panel();
            ParcelItemList = new ListBox();
            MovementPanel = new Panel();
            ParcelInfoLabel = new Label();
            EnemyInfoLabel = new Label();
            PlayerConsoleTextBox = new TextBox();
            FleeButton = new Button();
            ParcelContentsPanel = new Panel();
            LandmarkPictureBox = new PictureBox();
            EnemyPictureBox = new PictureBox();
            EnemyStrengthLabel = new Label();
            PlayerStrengthLabel = new Label();
            PlayerGoldLabel = new Label();
            EnemyThreatLabel = new Label();
            PlayerThreadLabel = new Label();
            DirectionAndCoordinatesLabel = new Label();
            menuStrip1.SuspendLayout();
            MovementPanel.SuspendLayout();
            ParcelContentsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LandmarkPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EnemyPictureBox).BeginInit();
            SuspendLayout();
            // 
            // UpButton
            // 
            UpButton.Location = new Point(99, 36);
            UpButton.Margin = new Padding(3, 4, 3, 4);
            UpButton.Name = "UpButton";
            UpButton.Size = new Size(86, 31);
            UpButton.TabIndex = 0;
            UpButton.Text = "Up";
            UpButton.UseVisualStyleBackColor = true;
            UpButton.Click += UpButton_Click;
            // 
            // DownButton
            // 
            DownButton.Location = new Point(99, 131);
            DownButton.Margin = new Padding(3, 4, 3, 4);
            DownButton.Name = "DownButton";
            DownButton.Size = new Size(86, 31);
            DownButton.TabIndex = 1;
            DownButton.Text = "Down";
            DownButton.UseVisualStyleBackColor = true;
            DownButton.Click += DownButton_Click;
            // 
            // LeftButton
            // 
            LeftButton.Location = new Point(3, 81);
            LeftButton.Margin = new Padding(3, 4, 3, 4);
            LeftButton.Name = "LeftButton";
            LeftButton.Size = new Size(86, 31);
            LeftButton.TabIndex = 2;
            LeftButton.Text = "Left";
            LeftButton.UseVisualStyleBackColor = true;
            LeftButton.Click += LeftButton_Click;
            // 
            // RightButton
            // 
            RightButton.Location = new Point(192, 81);
            RightButton.Margin = new Padding(3, 4, 3, 4);
            RightButton.Name = "RightButton";
            RightButton.Size = new Size(86, 31);
            RightButton.TabIndex = 3;
            RightButton.Text = "Right";
            RightButton.UseVisualStyleBackColor = true;
            RightButton.Click += RightButton_Click;
            // 
            // AttackButton
            // 
            AttackButton.Location = new Point(695, 256);
            AttackButton.Margin = new Padding(3, 4, 3, 4);
            AttackButton.Name = "AttackButton";
            AttackButton.Size = new Size(86, 31);
            AttackButton.TabIndex = 4;
            AttackButton.Text = "Attack";
            AttackButton.UseVisualStyleBackColor = true;
            AttackButton.Click += AttackButton_Click;
            // 
            // DefendButton
            // 
            DefendButton.Location = new Point(787, 256);
            DefendButton.Margin = new Padding(3, 4, 3, 4);
            DefendButton.Name = "DefendButton";
            DefendButton.Size = new Size(86, 31);
            DefendButton.TabIndex = 5;
            DefendButton.Text = "Defend";
            DefendButton.UseVisualStyleBackColor = true;
            DefendButton.Click += DefendButton_Click;
            // 
            // SorceryButton
            // 
            SorceryButton.Location = new Point(880, 256);
            SorceryButton.Margin = new Padding(3, 4, 3, 4);
            SorceryButton.Name = "SorceryButton";
            SorceryButton.Size = new Size(86, 31);
            SorceryButton.TabIndex = 6;
            SorceryButton.Text = "Sorcery";
            SorceryButton.UseVisualStyleBackColor = true;
            SorceryButton.Click += SorceryButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(695, 295);
            SearchButton.Margin = new Padding(3, 4, 3, 4);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(86, 31);
            SearchButton.TabIndex = 7;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // TalkButton
            // 
            TalkButton.Location = new Point(787, 295);
            TalkButton.Margin = new Padding(3, 4, 3, 4);
            TalkButton.Name = "TalkButton";
            TalkButton.Size = new Size(86, 31);
            TalkButton.TabIndex = 8;
            TalkButton.Text = "Talk";
            TalkButton.UseVisualStyleBackColor = true;
            TalkButton.Click += TalkButton_Click;
            // 
            // StatsAndInvButton
            // 
            StatsAndInvButton.Location = new Point(695, 440);
            StatsAndInvButton.Margin = new Padding(3, 4, 3, 4);
            StatsAndInvButton.Name = "StatsAndInvButton";
            StatsAndInvButton.Size = new Size(271, 31);
            StatsAndInvButton.TabIndex = 10;
            StatsAndInvButton.Text = "Statistics and Inventory";
            StatsAndInvButton.UseVisualStyleBackColor = true;
            StatsAndInvButton.Click += StatsAndInvButton_Click;
            // 
            // GetItemButton
            // 
            GetItemButton.Location = new Point(880, 347);
            GetItemButton.Margin = new Padding(3, 4, 3, 4);
            GetItemButton.Name = "GetItemButton";
            GetItemButton.Size = new Size(86, 31);
            GetItemButton.TabIndex = 11;
            GetItemButton.Text = "Get Item";
            GetItemButton.UseVisualStyleBackColor = true;
            GetItemButton.Click += GetItemButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gameToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(993, 30);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            gameToolStripMenuItem.Size = new Size(62, 24);
            gameToolStripMenuItem.Text = "Game";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // MapGridPanel
            // 
            MapGridPanel.Location = new Point(56, 99);
            MapGridPanel.Margin = new Padding(3, 4, 3, 4);
            MapGridPanel.Name = "MapGridPanel";
            MapGridPanel.Size = new Size(344, 401);
            MapGridPanel.TabIndex = 13;
            MapGridPanel.Paint += MapGridPanel_Paint;
            // 
            // ParcelItemList
            // 
            ParcelItemList.FormattingEnabled = true;
            ParcelItemList.Location = new Point(695, 347);
            ParcelItemList.Margin = new Padding(3, 4, 3, 4);
            ParcelItemList.Name = "ParcelItemList";
            ParcelItemList.Size = new Size(178, 84);
            ParcelItemList.TabIndex = 14;
            // 
            // MovementPanel
            // 
            MovementPanel.BackColor = SystemColors.Info;
            MovementPanel.Controls.Add(UpButton);
            MovementPanel.Controls.Add(LeftButton);
            MovementPanel.Controls.Add(RightButton);
            MovementPanel.Controls.Add(DownButton);
            MovementPanel.Location = new Point(407, 256);
            MovementPanel.Margin = new Padding(3, 4, 3, 4);
            MovementPanel.Name = "MovementPanel";
            MovementPanel.Size = new Size(281, 176);
            MovementPanel.TabIndex = 15;
            // 
            // ParcelInfoLabel
            // 
            ParcelInfoLabel.BackColor = SystemColors.GradientActiveCaption;
            ParcelInfoLabel.BorderStyle = BorderStyle.FixedSingle;
            ParcelInfoLabel.Location = new Point(30, 523);
            ParcelInfoLabel.Name = "ParcelInfoLabel";
            ParcelInfoLabel.Size = new Size(936, 30);
            ParcelInfoLabel.TabIndex = 16;
            ParcelInfoLabel.Text = "ParcelInfoLabel";
            // 
            // EnemyInfoLabel
            // 
            EnemyInfoLabel.BackColor = SystemColors.GradientActiveCaption;
            EnemyInfoLabel.BorderStyle = BorderStyle.FixedSingle;
            EnemyInfoLabel.ForeColor = SystemColors.ControlText;
            EnemyInfoLabel.Location = new Point(30, 553);
            EnemyInfoLabel.Name = "EnemyInfoLabel";
            EnemyInfoLabel.Size = new Size(936, 30);
            EnemyInfoLabel.TabIndex = 17;
            // 
            // PlayerConsoleTextBox
            // 
            PlayerConsoleTextBox.Location = new Point(30, 588);
            PlayerConsoleTextBox.Margin = new Padding(3, 4, 3, 4);
            PlayerConsoleTextBox.Multiline = true;
            PlayerConsoleTextBox.Name = "PlayerConsoleTextBox";
            PlayerConsoleTextBox.ScrollBars = ScrollBars.Vertical;
            PlayerConsoleTextBox.Size = new Size(935, 132);
            PlayerConsoleTextBox.TabIndex = 18;
            // 
            // FleeButton
            // 
            FleeButton.Location = new Point(880, 217);
            FleeButton.Margin = new Padding(3, 4, 3, 4);
            FleeButton.Name = "FleeButton";
            FleeButton.Size = new Size(86, 31);
            FleeButton.TabIndex = 19;
            FleeButton.Text = "Flee";
            FleeButton.UseVisualStyleBackColor = true;
            FleeButton.Click += FleeButton_Click;
            // 
            // ParcelContentsPanel
            // 
            ParcelContentsPanel.BackColor = SystemColors.Highlight;
            ParcelContentsPanel.Controls.Add(LandmarkPictureBox);
            ParcelContentsPanel.Controls.Add(EnemyPictureBox);
            ParcelContentsPanel.Location = new Point(407, 99);
            ParcelContentsPanel.Margin = new Padding(3, 4, 3, 4);
            ParcelContentsPanel.Name = "ParcelContentsPanel";
            ParcelContentsPanel.Size = new Size(281, 149);
            ParcelContentsPanel.TabIndex = 20;
            // 
            // LandmarkPictureBox
            // 
            LandmarkPictureBox.BackColor = SystemColors.Control;
            LandmarkPictureBox.Location = new Point(166, 27);
            LandmarkPictureBox.Margin = new Padding(3, 4, 3, 4);
            LandmarkPictureBox.Name = "LandmarkPictureBox";
            LandmarkPictureBox.Size = new Size(85, 92);
            LandmarkPictureBox.TabIndex = 1;
            LandmarkPictureBox.TabStop = false;
            // 
            // EnemyPictureBox
            // 
            EnemyPictureBox.BackColor = SystemColors.Control;
            EnemyPictureBox.Location = new Point(32, 27);
            EnemyPictureBox.Margin = new Padding(3, 4, 3, 4);
            EnemyPictureBox.Name = "EnemyPictureBox";
            EnemyPictureBox.Size = new Size(86, 92);
            EnemyPictureBox.TabIndex = 0;
            EnemyPictureBox.TabStop = false;
            // 
            // EnemyStrengthLabel
            // 
            EnemyStrengthLabel.BackColor = SystemColors.Highlight;
            EnemyStrengthLabel.BorderStyle = BorderStyle.FixedSingle;
            EnemyStrengthLabel.ForeColor = SystemColors.ActiveCaptionText;
            EnemyStrengthLabel.Location = new Point(705, 99);
            EnemyStrengthLabel.Name = "EnemyStrengthLabel";
            EnemyStrengthLabel.Size = new Size(136, 30);
            EnemyStrengthLabel.TabIndex = 21;
            EnemyStrengthLabel.Text = "EnemyStrengthLabel";
            // 
            // PlayerStrengthLabel
            // 
            PlayerStrengthLabel.BackColor = SystemColors.GradientActiveCaption;
            PlayerStrengthLabel.BorderStyle = BorderStyle.FixedSingle;
            PlayerStrengthLabel.Location = new Point(705, 129);
            PlayerStrengthLabel.Name = "PlayerStrengthLabel";
            PlayerStrengthLabel.Size = new Size(136, 30);
            PlayerStrengthLabel.TabIndex = 22;
            PlayerStrengthLabel.Text = "PlayerStrengthLabel";
            // 
            // PlayerGoldLabel
            // 
            PlayerGoldLabel.BackColor = SystemColors.GradientActiveCaption;
            PlayerGoldLabel.BorderStyle = BorderStyle.FixedSingle;
            PlayerGoldLabel.Location = new Point(705, 161);
            PlayerGoldLabel.Name = "PlayerGoldLabel";
            PlayerGoldLabel.Size = new Size(136, 30);
            PlayerGoldLabel.TabIndex = 23;
            PlayerGoldLabel.Text = "PlayerGoldLabel";
            // 
            // EnemyThreatLabel
            // 
            EnemyThreatLabel.BackColor = SystemColors.MenuHighlight;
            EnemyThreatLabel.Location = new Point(846, 99);
            EnemyThreatLabel.Name = "EnemyThreatLabel";
            EnemyThreatLabel.Size = new Size(120, 31);
            EnemyThreatLabel.TabIndex = 24;
            EnemyThreatLabel.Text = "EnemyThreatLabel";
            // 
            // PlayerThreadLabel
            // 
            PlayerThreadLabel.BackColor = SystemColors.GradientActiveCaption;
            PlayerThreadLabel.BorderStyle = BorderStyle.FixedSingle;
            PlayerThreadLabel.Location = new Point(846, 129);
            PlayerThreadLabel.Name = "PlayerThreadLabel";
            PlayerThreadLabel.Size = new Size(120, 30);
            PlayerThreadLabel.TabIndex = 25;
            PlayerThreadLabel.Text = "PlayerThreatLabel";
            // 
            // DirectionAndCoordinatesLabel
            // 
            DirectionAndCoordinatesLabel.BackColor = SystemColors.HotTrack;
            DirectionAndCoordinatesLabel.Location = new Point(56, 44);
            DirectionAndCoordinatesLabel.Name = "DirectionAndCoordinatesLabel";
            DirectionAndCoordinatesLabel.Size = new Size(344, 31);
            DirectionAndCoordinatesLabel.TabIndex = 26;
            DirectionAndCoordinatesLabel.Text = "DirectionAndCoordinatesLabel";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(993, 745);
            Controls.Add(DirectionAndCoordinatesLabel);
            Controls.Add(PlayerThreadLabel);
            Controls.Add(EnemyThreatLabel);
            Controls.Add(PlayerGoldLabel);
            Controls.Add(PlayerStrengthLabel);
            Controls.Add(EnemyStrengthLabel);
            Controls.Add(ParcelContentsPanel);
            Controls.Add(FleeButton);
            Controls.Add(PlayerConsoleTextBox);
            Controls.Add(EnemyInfoLabel);
            Controls.Add(ParcelInfoLabel);
            Controls.Add(MovementPanel);
            Controls.Add(ParcelItemList);
            Controls.Add(MapGridPanel);
            Controls.Add(GetItemButton);
            Controls.Add(StatsAndInvButton);
            Controls.Add(TalkButton);
            Controls.Add(SearchButton);
            Controls.Add(SorceryButton);
            Controls.Add(DefendButton);
            Controls.Add(AttackButton);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Form1";
            Load += ViewForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            MovementPanel.ResumeLayout(false);
            ParcelContentsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LandmarkPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)EnemyPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpButton;
        private Button DownButton;
        private Button LeftButton;
        private Button RightButton;
        private Button AttackButton;
        private Button DefendButton;
        private Button SorceryButton;
        private Button SearchButton;
        private Button TalkButton;
        private Button StatsAndInvButton;
        private Button GetItemButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Panel MapGridPanel;
        private ListBox ParcelItemList;
        private Panel MovementPanel;
        private Label ParcelInfoLabel;
        private Label EnemyInfoLabel;
        private TextBox PlayerConsoleTextBox;
        private Button FleeButton;
        private Panel ParcelContentsPanel;
        private PictureBox LandmarkPictureBox;
        private PictureBox EnemyPictureBox;
        private Label EnemyStrengthLabel;
        private Label PlayerStrengthLabel;
        private Label PlayerGoldLabel;
        private Label EnemyThreatLabel;
        private Label PlayerThreadLabel;
        private Label DirectionAndCoordinatesLabel;
    }
}
