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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            startNewGameToolStripMenuItem = new ToolStripMenuItem();
            replayGameToolStripMenuItem = new ToolStripMenuItem();
            quitGameToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            MapGridPanel = new Panel();
            IntroPanel = new Panel();
            EnterButton = new Button();
            CharNameTextBox = new TextBox();
            EnterNameLabel = new Label();
            TitleLabel = new Label();
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
            PlayerThreatLabel = new Label();
            DirectionAndCoordinatesLabel = new Label();
            menuStrip1.SuspendLayout();
            IntroPanel.SuspendLayout();
            MovementPanel.SuspendLayout();
            ParcelContentsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LandmarkPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EnemyPictureBox).BeginInit();
            SuspendLayout();
            // 
            // UpButton
            // 
            UpButton.Location = new Point(87, 27);
            UpButton.Name = "UpButton";
            UpButton.Size = new Size(75, 23);
            UpButton.TabIndex = 0;
            UpButton.Text = "Up";
            UpButton.UseVisualStyleBackColor = true;
            UpButton.Click += UpButton_Click;
            // 
            // DownButton
            // 
            DownButton.Location = new Point(87, 98);
            DownButton.Name = "DownButton";
            DownButton.Size = new Size(75, 23);
            DownButton.TabIndex = 1;
            DownButton.Text = "Down";
            DownButton.UseVisualStyleBackColor = true;
            DownButton.Click += DownButton_Click;
            // 
            // LeftButton
            // 
            LeftButton.Location = new Point(3, 61);
            LeftButton.Name = "LeftButton";
            LeftButton.Size = new Size(75, 23);
            LeftButton.TabIndex = 2;
            LeftButton.Text = "Left";
            LeftButton.UseVisualStyleBackColor = true;
            LeftButton.Click += LeftButton_Click;
            // 
            // RightButton
            // 
            RightButton.Location = new Point(168, 61);
            RightButton.Name = "RightButton";
            RightButton.Size = new Size(75, 23);
            RightButton.TabIndex = 3;
            RightButton.Text = "Right";
            RightButton.UseVisualStyleBackColor = true;
            RightButton.Click += RightButton_Click;
            // 
            // AttackButton
            // 
            AttackButton.Location = new Point(862, 182);
            AttackButton.Name = "AttackButton";
            AttackButton.Size = new Size(75, 23);
            AttackButton.TabIndex = 4;
            AttackButton.Text = "Attack";
            AttackButton.UseVisualStyleBackColor = true;
            AttackButton.Click += AttackButton_Click;
            // 
            // DefendButton
            // 
            DefendButton.Location = new Point(943, 182);
            DefendButton.Name = "DefendButton";
            DefendButton.Size = new Size(75, 23);
            DefendButton.TabIndex = 5;
            DefendButton.Text = "Defend";
            DefendButton.UseVisualStyleBackColor = true;
            DefendButton.Click += DefendButton_Click;
            // 
            // SorceryButton
            // 
            SorceryButton.Location = new Point(1024, 182);
            SorceryButton.Name = "SorceryButton";
            SorceryButton.Size = new Size(75, 23);
            SorceryButton.TabIndex = 6;
            SorceryButton.Text = "Sorcery";
            SorceryButton.UseVisualStyleBackColor = true;
            SorceryButton.Click += SorceryButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(862, 211);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 7;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // TalkButton
            // 
            TalkButton.Location = new Point(943, 211);
            TalkButton.Name = "TalkButton";
            TalkButton.Size = new Size(75, 23);
            TalkButton.TabIndex = 8;
            TalkButton.Text = "Talk";
            TalkButton.UseVisualStyleBackColor = true;
            TalkButton.Click += TalkButton_Click;
            // 
            // StatsAndInvButton
            // 
            StatsAndInvButton.Location = new Point(862, 316);
            StatsAndInvButton.Name = "StatsAndInvButton";
            StatsAndInvButton.Size = new Size(246, 23);
            StatsAndInvButton.TabIndex = 10;
            StatsAndInvButton.Text = "Statistics and Inventory";
            StatsAndInvButton.UseVisualStyleBackColor = true;
            StatsAndInvButton.Click += StatsAndInvButton_Click;
            // 
            // GetItemButton
            // 
            GetItemButton.Location = new Point(1024, 250);
            GetItemButton.Name = "GetItemButton";
            GetItemButton.Size = new Size(75, 23);
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
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            gameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startNewGameToolStripMenuItem, replayGameToolStripMenuItem, quitGameToolStripMenuItem });
            gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            gameToolStripMenuItem.Size = new Size(50, 20);
            gameToolStripMenuItem.Text = "Game";
            // 
            // startNewGameToolStripMenuItem
            // 
            startNewGameToolStripMenuItem.Name = "startNewGameToolStripMenuItem";
            startNewGameToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            startNewGameToolStripMenuItem.Size = new Size(202, 22);
            startNewGameToolStripMenuItem.Text = "Start New Game";
            startNewGameToolStripMenuItem.Click += startNewGameToolStripMenuItem_Click;
            // 
            // replayGameToolStripMenuItem
            // 
            replayGameToolStripMenuItem.Name = "replayGameToolStripMenuItem";
            replayGameToolStripMenuItem.Size = new Size(202, 22);
            replayGameToolStripMenuItem.Text = "Replay Game";
            // 
            // quitGameToolStripMenuItem
            // 
            quitGameToolStripMenuItem.Name = "quitGameToolStripMenuItem";
            quitGameToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            quitGameToolStripMenuItem.Size = new Size(202, 22);
            quitGameToolStripMenuItem.Text = "Quit Game";
            quitGameToolStripMenuItem.Click += quitGameToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // MapGridPanel
            // 
            MapGridPanel.Location = new Point(86, 127);
            MapGridPanel.Name = "MapGridPanel";
            MapGridPanel.Size = new Size(301, 301);
            MapGridPanel.TabIndex = 13;
            MapGridPanel.Paint += MapGridPanel_Paint;
            // 
            // IntroPanel
            // 
            IntroPanel.BackColor = Color.DarkGray;
            IntroPanel.BackgroundImage = (Image)resources.GetObject("IntroPanel.BackgroundImage");
            IntroPanel.BackgroundImageLayout = ImageLayout.Stretch;
            IntroPanel.Controls.Add(EnterButton);
            IntroPanel.Controls.Add(CharNameTextBox);
            IntroPanel.Controls.Add(EnterNameLabel);
            IntroPanel.Controls.Add(TitleLabel);
            IntroPanel.Location = new Point(378, 127);
            IntroPanel.Name = "IntroPanel";
            IntroPanel.Size = new Size(468, 474);
            IntroPanel.TabIndex = 27;
            // 
            // EnterButton
            // 
            EnterButton.Location = new Point(198, 293);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(75, 23);
            EnterButton.TabIndex = 3;
            EnterButton.Text = "Enter";
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Click += EnterButton_Click;
            // 
            // CharNameTextBox
            // 
            CharNameTextBox.BackColor = Color.Black;
            CharNameTextBox.BorderStyle = BorderStyle.None;
            CharNameTextBox.ForeColor = Color.Gold;
            CharNameTextBox.Location = new Point(238, 262);
            CharNameTextBox.Name = "CharNameTextBox";
            CharNameTextBox.Size = new Size(100, 16);
            CharNameTextBox.TabIndex = 2;
            // 
            // EnterNameLabel
            // 
            EnterNameLabel.AutoSize = true;
            EnterNameLabel.BackColor = Color.Transparent;
            EnterNameLabel.Font = new Font("Segoe Script", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            EnterNameLabel.Location = new Point(143, 263);
            EnterNameLabel.Name = "EnterNameLabel";
            EnterNameLabel.Size = new Size(89, 20);
            EnterNameLabel.TabIndex = 1;
            EnterNameLabel.Text = "Enter Name:";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.BackColor = Color.Transparent;
            TitleLabel.Font = new Font("Segoe Script", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(69, 136);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(325, 48);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "PROJECT REPTILE";
            // 
            // ParcelItemList
            // 
            ParcelItemList.BackColor = Color.Black;
            ParcelItemList.ForeColor = Color.Gold;
            ParcelItemList.FormattingEnabled = true;
            ParcelItemList.ItemHeight = 15;
            ParcelItemList.Location = new Point(862, 246);
            ParcelItemList.Name = "ParcelItemList";
            ParcelItemList.Size = new Size(156, 64);
            ParcelItemList.TabIndex = 14;
            // 
            // MovementPanel
            // 
            MovementPanel.BackColor = Color.Brown;
            MovementPanel.Controls.Add(UpButton);
            MovementPanel.Controls.Add(LeftButton);
            MovementPanel.Controls.Add(RightButton);
            MovementPanel.Controls.Add(DownButton);
            MovementPanel.Location = new Point(498, 285);
            MovementPanel.Name = "MovementPanel";
            MovementPanel.Size = new Size(246, 132);
            MovementPanel.TabIndex = 15;
            // 
            // ParcelInfoLabel
            // 
            ParcelInfoLabel.BackColor = Color.LightCoral;
            ParcelInfoLabel.BorderStyle = BorderStyle.FixedSingle;
            ParcelInfoLabel.Location = new Point(60, 479);
            ParcelInfoLabel.Name = "ParcelInfoLabel";
            ParcelInfoLabel.Size = new Size(1070, 23);
            ParcelInfoLabel.TabIndex = 16;
            ParcelInfoLabel.Text = "ParcelInfoLabel";
            // 
            // EnemyInfoLabel
            // 
            EnemyInfoLabel.BackColor = Color.LightCoral;
            EnemyInfoLabel.BorderStyle = BorderStyle.FixedSingle;
            EnemyInfoLabel.ForeColor = SystemColors.ControlText;
            EnemyInfoLabel.Location = new Point(60, 502);
            EnemyInfoLabel.Name = "EnemyInfoLabel";
            EnemyInfoLabel.Size = new Size(1070, 23);
            EnemyInfoLabel.TabIndex = 17;
            // 
            // PlayerConsoleTextBox
            // 
            PlayerConsoleTextBox.BackColor = Color.Black;
            PlayerConsoleTextBox.ForeColor = Color.Gold;
            PlayerConsoleTextBox.Location = new Point(60, 540);
            PlayerConsoleTextBox.Multiline = true;
            PlayerConsoleTextBox.Name = "PlayerConsoleTextBox";
            PlayerConsoleTextBox.ReadOnly = true;
            PlayerConsoleTextBox.ScrollBars = ScrollBars.Vertical;
            PlayerConsoleTextBox.Size = new Size(1070, 170);
            PlayerConsoleTextBox.TabIndex = 18;
            // 
            // FleeButton
            // 
            FleeButton.Location = new Point(1024, 153);
            FleeButton.Name = "FleeButton";
            FleeButton.Size = new Size(75, 23);
            FleeButton.TabIndex = 19;
            FleeButton.Text = "Flee";
            FleeButton.UseVisualStyleBackColor = true;
            FleeButton.Click += FleeButton_Click;
            // 
            // ParcelContentsPanel
            // 
            ParcelContentsPanel.BackColor = Color.Olive;
            ParcelContentsPanel.Controls.Add(LandmarkPictureBox);
            ParcelContentsPanel.Controls.Add(EnemyPictureBox);
            ParcelContentsPanel.Location = new Point(461, 60);
            ParcelContentsPanel.Name = "ParcelContentsPanel";
            ParcelContentsPanel.Size = new Size(318, 174);
            ParcelContentsPanel.TabIndex = 20;
            // 
            // LandmarkPictureBox
            // 
            LandmarkPictureBox.BackColor = SystemColors.Control;
            LandmarkPictureBox.Location = new Point(209, 47);
            LandmarkPictureBox.Name = "LandmarkPictureBox";
            LandmarkPictureBox.Size = new Size(74, 69);
            LandmarkPictureBox.TabIndex = 1;
            LandmarkPictureBox.TabStop = false;
            // 
            // EnemyPictureBox
            // 
            EnemyPictureBox.BackColor = SystemColors.Control;
            EnemyPictureBox.Location = new Point(41, 47);
            EnemyPictureBox.Name = "EnemyPictureBox";
            EnemyPictureBox.Size = new Size(75, 69);
            EnemyPictureBox.TabIndex = 0;
            EnemyPictureBox.TabStop = false;
            // 
            // EnemyStrengthLabel
            // 
            EnemyStrengthLabel.BackColor = Color.Brown;
            EnemyStrengthLabel.BorderStyle = BorderStyle.FixedSingle;
            EnemyStrengthLabel.ForeColor = SystemColors.ActiveCaptionText;
            EnemyStrengthLabel.Location = new Point(862, 81);
            EnemyStrengthLabel.Name = "EnemyStrengthLabel";
            EnemyStrengthLabel.Size = new Size(119, 23);
            EnemyStrengthLabel.TabIndex = 21;
            EnemyStrengthLabel.Text = "EnemyStrengthLabel";
            // 
            // PlayerStrengthLabel
            // 
            PlayerStrengthLabel.BackColor = Color.IndianRed;
            PlayerStrengthLabel.BorderStyle = BorderStyle.FixedSingle;
            PlayerStrengthLabel.Location = new Point(862, 116);
            PlayerStrengthLabel.Name = "PlayerStrengthLabel";
            PlayerStrengthLabel.Size = new Size(119, 23);
            PlayerStrengthLabel.TabIndex = 22;
            PlayerStrengthLabel.Text = "PlayerStrengthLabel";
            // 
            // PlayerGoldLabel
            // 
            PlayerGoldLabel.BackColor = Color.IndianRed;
            PlayerGoldLabel.BorderStyle = BorderStyle.FixedSingle;
            PlayerGoldLabel.Location = new Point(862, 150);
            PlayerGoldLabel.Name = "PlayerGoldLabel";
            PlayerGoldLabel.Size = new Size(119, 23);
            PlayerGoldLabel.TabIndex = 23;
            PlayerGoldLabel.Text = "PlayerGoldLabel";
            // 
            // EnemyThreatLabel
            // 
            EnemyThreatLabel.BackColor = Color.Firebrick;
            EnemyThreatLabel.Location = new Point(987, 81);
            EnemyThreatLabel.Name = "EnemyThreatLabel";
            EnemyThreatLabel.Size = new Size(105, 23);
            EnemyThreatLabel.TabIndex = 24;
            EnemyThreatLabel.Text = "EnemyThreatLabel";
            // 
            // PlayerThreatLabel
            // 
            PlayerThreatLabel.BackColor = Color.IndianRed;
            PlayerThreatLabel.BorderStyle = BorderStyle.FixedSingle;
            PlayerThreatLabel.Location = new Point(987, 116);
            PlayerThreatLabel.Name = "PlayerThreatLabel";
            PlayerThreatLabel.Size = new Size(105, 23);
            PlayerThreatLabel.TabIndex = 25;
            PlayerThreatLabel.Text = "PlayerThreatLabel";
            // 
            // DirectionAndCoordinatesLabel
            // 
            DirectionAndCoordinatesLabel.BackColor = Color.Brown;
            DirectionAndCoordinatesLabel.Location = new Point(86, 81);
            DirectionAndCoordinatesLabel.Name = "DirectionAndCoordinatesLabel";
            DirectionAndCoordinatesLabel.Size = new Size(301, 23);
            DirectionAndCoordinatesLabel.TabIndex = 26;
            DirectionAndCoordinatesLabel.Text = "DirectionAndCoordinatesLabel";
            // 
            // MainForm
            // 
            AcceptButton = EnterButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 761);
            Controls.Add(IntroPanel);
            Controls.Add(ParcelContentsPanel);
            Controls.Add(DirectionAndCoordinatesLabel);
            Controls.Add(MovementPanel);
            Controls.Add(PlayerThreatLabel);
            Controls.Add(EnemyThreatLabel);
            Controls.Add(PlayerGoldLabel);
            Controls.Add(PlayerStrengthLabel);
            Controls.Add(EnemyStrengthLabel);
            Controls.Add(FleeButton);
            Controls.Add(PlayerConsoleTextBox);
            Controls.Add(EnemyInfoLabel);
            Controls.Add(ParcelInfoLabel);
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
            Name = "MainForm";
            Text = "Form1";
            Load += ViewForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            IntroPanel.ResumeLayout(false);
            IntroPanel.PerformLayout();
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
        private Label PlayerThreatLabel;
        private Label DirectionAndCoordinatesLabel;
        private Panel IntroPanel;
        private Label EnterNameLabel;
        private Label TitleLabel;
        private Button EnterButton;
        private TextBox CharNameTextBox;
        private ToolStripMenuItem startNewGameToolStripMenuItem;
        private ToolStripMenuItem replayGameToolStripMenuItem;
        private ToolStripMenuItem quitGameToolStripMenuItem;
    }
}
