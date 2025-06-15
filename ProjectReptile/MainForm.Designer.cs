using System.Drawing.Text;
using System.Drawing.Text;
using System.Runtime.InteropServices;

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
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("QC_Assets\\Alkhemikal.ttf"); // Put the font file in the app folder
            Font alkhemikal = new Font(pfc.Families[0], 12f);

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
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            EnterButton = new Button();
            CharNameTextBox = new TextBox();
            EnterNameLabel = new Label();
            TitleLabel = new Label();
            ParcelItemList = new ListBox();
            MovementPanel = new BufferedPanel();
            ParcelInfoLabel = new Label();
            EnemyInfoLabel = new Label();
            PlayerConsoleTextBox = new TextBox();
            FleeButton = new Button();
            ParcelContentsPanel = new BufferedPanel();
            EnemiesLabel = new Label();
            TerrainLabel = new Label();
            RoomContentsLabel = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MovementPanel.SuspendLayout();
            ParcelContentsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LandmarkPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EnemyPictureBox).BeginInit();
            SuspendLayout();
            // 
            // UpButton
            // 
            UpButton.BackColor = Color.Transparent;
            UpButton.BackgroundImage = (Image)resources.GetObject("UpButton.BackgroundImage");
            UpButton.BackgroundImageLayout = ImageLayout.Stretch;
            UpButton.FlatStyle = FlatStyle.Popup;
            UpButton.Location = new Point(94, 4);
            UpButton.Name = "UpButton";
            UpButton.Size = new Size(85, 85);
            UpButton.TabIndex = 0;
            UpButton.UseVisualStyleBackColor = false;
            UpButton.Click += UpButton_Click;
            // 
            // DownButton
            // 
            DownButton.BackColor = Color.Transparent;
            DownButton.BackgroundImage = (Image)resources.GetObject("DownButton.BackgroundImage");
            DownButton.BackgroundImageLayout = ImageLayout.Stretch;
            DownButton.FlatStyle = FlatStyle.Popup;
            DownButton.Location = new Point(94, 90);
            DownButton.Name = "DownButton";
            DownButton.Size = new Size(85, 85);
            DownButton.TabIndex = 1;
            DownButton.UseVisualStyleBackColor = false;
            DownButton.Click += DownButton_Click;
            // 
            // LeftButton
            // 
            LeftButton.BackColor = Color.Transparent;
            LeftButton.BackgroundImage = (Image)resources.GetObject("LeftButton.BackgroundImage");
            LeftButton.BackgroundImageLayout = ImageLayout.Stretch;
            LeftButton.FlatStyle = FlatStyle.Popup;
            LeftButton.Location = new Point(3, 88);
            LeftButton.Name = "LeftButton";
            LeftButton.Size = new Size(85, 85);
            LeftButton.TabIndex = 2;
            LeftButton.UseVisualStyleBackColor = false;
            LeftButton.Click += LeftButton_Click;
            // 
            // RightButton
            // 
            RightButton.BackColor = Color.Transparent;
            RightButton.BackgroundImage = (Image)resources.GetObject("RightButton.BackgroundImage");
            RightButton.BackgroundImageLayout = ImageLayout.Stretch;
            RightButton.FlatStyle = FlatStyle.Popup;
            RightButton.Location = new Point(185, 88);
            RightButton.Name = "RightButton";
            RightButton.Size = new Size(85, 85);
            RightButton.TabIndex = 3;
            RightButton.UseVisualStyleBackColor = false;
            RightButton.Click += RightButton_Click;
            // 
            // AttackButton
            // 
            AttackButton.Location = new Point(819, 183);
            AttackButton.Name = "AttackButton";
            AttackButton.Size = new Size(78, 29);
            AttackButton.TabIndex = 4;
            AttackButton.Text = "Attack";
            AttackButton.UseVisualStyleBackColor = true;
            AttackButton.Click += AttackButton_Click;
            AttackButton.Font = alkhemikal;
            // 
            // DefendButton
            // 
            DefendButton.Location = new Point(916, 183);
            DefendButton.Name = "DefendButton";
            DefendButton.Size = new Size(78, 29);
            DefendButton.TabIndex = 5;
            DefendButton.Text = "Defend";
            DefendButton.UseVisualStyleBackColor = true;
            DefendButton.Click += DefendButton_Click;
            DefendButton.Font = alkhemikal;
            // 
            // SorceryButton
            // 
            SorceryButton.Location = new Point(1011, 215);
            SorceryButton.Name = "SorceryButton";
            SorceryButton.Size = new Size(78, 29);
            SorceryButton.TabIndex = 6;
            SorceryButton.Text = "Sorcery";
            SorceryButton.UseVisualStyleBackColor = true;
            SorceryButton.Click += SorceryButton_Click;
            SorceryButton.Font = alkhemikal;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(819, 215);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(78, 29);
            SearchButton.TabIndex = 7;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            SearchButton.Font = alkhemikal;
            // 
            // TalkButton
            // 
            TalkButton.Location = new Point(916, 215);
            TalkButton.Name = "TalkButton";
            TalkButton.Size = new Size(78, 29);
            TalkButton.TabIndex = 8;
            TalkButton.Text = "Talk";
            TalkButton.UseVisualStyleBackColor = true;
            TalkButton.Click += TalkButton_Click;
            TalkButton.Font = alkhemikal;
            // 
            // StatsAndInvButton
            // 
            StatsAndInvButton.BackColor = Color.Black;
            StatsAndInvButton.BackgroundImage = (Image)resources.GetObject("StatsAndInvButton.BackgroundImage");
            StatsAndInvButton.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StatsAndInvButton.Location = new Point(819, 410);
            StatsAndInvButton.Name = "StatsAndInvButton";
            StatsAndInvButton.Size = new Size(273, 23);
            StatsAndInvButton.TabIndex = 10;
            StatsAndInvButton.Text = "Statistics and Inventory";
            StatsAndInvButton.UseVisualStyleBackColor = false;
            StatsAndInvButton.Click += StatsAndInvButton_Click;
            StatsAndInvButton.Font = alkhemikal;
            // 
            // GetItemButton
            // 
            GetItemButton.Location = new Point(1011, 260);
            GetItemButton.Name = "GetItemButton";
            GetItemButton.Size = new Size(78, 23);
            GetItemButton.TabIndex = 11;
            GetItemButton.Text = "Get Item";
            GetItemButton.UseVisualStyleBackColor = true;
            GetItemButton.Click += GetItemButton_Click;
            GetItemButton.Font = alkhemikal;
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
            replayGameToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            replayGameToolStripMenuItem.Size = new Size(202, 22);
            replayGameToolStripMenuItem.Text = "Replay Game";
            replayGameToolStripMenuItem.Click += replayGameToolStripMenuItem_Click;
            // 
            // quitGameToolStripMenuItem
            // 
            quitGameToolStripMenuItem.Name = "quitGameToolStripMenuItem";
            quitGameToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            quitGameToolStripMenuItem.Size = new Size(202, 22);
            quitGameToolStripMenuItem.Text = "Quit";
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
            IntroPanel.Controls.Add(pictureBox1);
            IntroPanel.Controls.Add(label3);
            IntroPanel.Controls.Add(label2);
            IntroPanel.Controls.Add(label1);
            IntroPanel.Controls.Add(EnterButton);
            IntroPanel.Controls.Add(CharNameTextBox);
            IntroPanel.Controls.Add(EnterNameLabel);
            IntroPanel.Controls.Add(TitleLabel);
            IntroPanel.Location = new Point(363, 116);
            IntroPanel.Name = "IntroPanel";
            IntroPanel.Size = new Size(479, 387);
            IntroPanel.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(173, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(362, 372);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 6;
            label3.Text = "V 0.1 BETA 2024-2025";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Script", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(170, 109);
            label2.Name = "label2";
            label2.Size = new Size(153, 19);
            label2.TabIndex = 5;
            label2.Text = "Art by Rachel Webster";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Script", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(153, 93);
            label1.Name = "label1";
            label1.Size = new Size(187, 19);
            label1.TabIndex = 4;
            label1.Text = "A game by Edwin Copeland";
            // 
            // EnterButton
            // 
            EnterButton.Location = new Point(197, 350);
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
            CharNameTextBox.Location = new Point(237, 319);
            CharNameTextBox.Name = "CharNameTextBox";
            CharNameTextBox.Size = new Size(100, 16);
            CharNameTextBox.TabIndex = 2;
            // 
            // EnterNameLabel
            // 
            EnterNameLabel.AutoSize = true;
            EnterNameLabel.BackColor = Color.Transparent;
            EnterNameLabel.Font = new Font("Segoe Script", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            EnterNameLabel.Location = new Point(142, 320);
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
            TitleLabel.Location = new Point(39, 41);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(403, 48);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "ESCAPE FROM VALUSIA";
            // 
            // ParcelItemList
            // 
            ParcelItemList.BackColor = Color.Black;
            ParcelItemList.ForeColor = Color.Gold;
            ParcelItemList.FormattingEnabled = true;
            ParcelItemList.ItemHeight = 15;
            ParcelItemList.Location = new Point(819, 260);
            ParcelItemList.Name = "ParcelItemList";
            ParcelItemList.Size = new Size(186, 94);
            ParcelItemList.TabIndex = 14;
            ParcelItemList.Font = alkhemikal;
            // 
            // MovementPanel
            // 
            MovementPanel.BackColor = Color.Transparent;
            MovementPanel.BackgroundImage = (Image)resources.GetObject("MovementPanel.BackgroundImage");
            MovementPanel.BackgroundImageLayout = ImageLayout.Stretch;
            MovementPanel.Controls.Add(UpButton);
            MovementPanel.Controls.Add(LeftButton);
            MovementPanel.Controls.Add(RightButton);
            MovementPanel.Controls.Add(DownButton);
            MovementPanel.Location = new Point(475, 260);
            MovementPanel.Name = "MovementPanel";
            MovementPanel.Size = new Size(274, 180);
            MovementPanel.TabIndex = 15;
            // 
            // ParcelInfoLabel
            // 
            ParcelInfoLabel.BackColor = Color.LightCoral;
            ParcelInfoLabel.BorderStyle = BorderStyle.FixedSingle;
            ParcelInfoLabel.Image = (Image)resources.GetObject("ParcelInfoLabel.Image");
            ParcelInfoLabel.Location = new Point(120, 459);
            ParcelInfoLabel.Name = "ParcelInfoLabel";
            ParcelInfoLabel.Size = new Size(972, 23);
            ParcelInfoLabel.TabIndex = 16;
            ParcelInfoLabel.Text = "ParcelInfoLabel";
            ParcelInfoLabel.Font = alkhemikal;
            // 
            // EnemyInfoLabel
            // 
            EnemyInfoLabel.BackColor = Color.Gray;
            EnemyInfoLabel.BorderStyle = BorderStyle.FixedSingle;
            EnemyInfoLabel.ForeColor = SystemColors.ControlText;
            EnemyInfoLabel.Image = (Image)resources.GetObject("EnemyInfoLabel.Image");
            EnemyInfoLabel.Location = new Point(120, 493);
            EnemyInfoLabel.Name = "EnemyInfoLabel";
            EnemyInfoLabel.Size = new Size(972, 23);
            EnemyInfoLabel.TabIndex = 17;
            EnemyInfoLabel.Font = alkhemikal;
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
            PlayerConsoleTextBox.Font = alkhemikal;
            // 
            // FleeButton
            // 
            FleeButton.Location = new Point(1011, 150);
            FleeButton.Name = "FleeButton";
            FleeButton.Size = new Size(78, 23);
            FleeButton.TabIndex = 19;
            FleeButton.Text = "Flee";
            FleeButton.UseVisualStyleBackColor = true;
            FleeButton.Click += FleeButton_Click;
            FleeButton.Font = alkhemikal;
            // 
            // ParcelContentsPanel
            // 
            ParcelContentsPanel.BackColor = Color.Transparent;
            ParcelContentsPanel.BackgroundImage = (Image)resources.GetObject("ParcelContentsPanel.BackgroundImage");
            ParcelContentsPanel.BackgroundImageLayout = ImageLayout.Stretch;
            ParcelContentsPanel.Controls.Add(EnemiesLabel);
            ParcelContentsPanel.Controls.Add(TerrainLabel);
            ParcelContentsPanel.Controls.Add(RoomContentsLabel);
            ParcelContentsPanel.Controls.Add(LandmarkPictureBox);
            ParcelContentsPanel.Controls.Add(EnemyPictureBox);
            ParcelContentsPanel.Location = new Point(443, 81);
            ParcelContentsPanel.Name = "ParcelContentsPanel";
            ParcelContentsPanel.Size = new Size(337, 173);
            ParcelContentsPanel.TabIndex = 20;
            ParcelContentsPanel.Font = alkhemikal;
            // 
            // EnemiesLabel
            // 
            EnemiesLabel.AutoSize = true;
            EnemiesLabel.BackColor = Color.Transparent;
            EnemiesLabel.Location = new Point(226, 134);
            EnemiesLabel.Name = "EnemiesLabel";
            EnemiesLabel.Size = new Size(51, 15);
            EnemiesLabel.TabIndex = 4;
            EnemiesLabel.Text = "Enemies";
            EnemiesLabel.Font = alkhemikal;
            // 
            // TerrainLabel
            // 
            TerrainLabel.AutoSize = true;
            TerrainLabel.BackColor = Color.Transparent;
            TerrainLabel.Location = new Point(41, 134);
            TerrainLabel.Name = "TerrainLabel";
            TerrainLabel.Size = new Size(65, 15);
            TerrainLabel.TabIndex = 3;
            TerrainLabel.Text = "Landmarks";
            TerrainLabel.Font = alkhemikal;
            // 
            // RoomContentsLabel
            // 
            RoomContentsLabel.AutoSize = true;
            RoomContentsLabel.BackColor = Color.Transparent;
            RoomContentsLabel.Location = new Point(112, 3);
            RoomContentsLabel.Name = "RoomContentsLabel";
            RoomContentsLabel.Size = new Size(97, 15);
            RoomContentsLabel.TabIndex = 2;
            RoomContentsLabel.Text = "Local Encounters";
            // 
            // LandmarkPictureBox
            // 
            LandmarkPictureBox.BackColor = SystemColors.Control;
            LandmarkPictureBox.BackgroundImage = (Image)resources.GetObject("LandmarkPictureBox.BackgroundImage");
            LandmarkPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            LandmarkPictureBox.Location = new Point(35, 31);
            LandmarkPictureBox.Name = "LandmarkPictureBox";
            LandmarkPictureBox.Size = new Size(100, 100);
            LandmarkPictureBox.TabIndex = 1;
            LandmarkPictureBox.TabStop = false;
            // 
            // EnemyPictureBox
            // 
            EnemyPictureBox.BackColor = SystemColors.Control;
            EnemyPictureBox.BackgroundImage = (Image)resources.GetObject("EnemyPictureBox.BackgroundImage");
            EnemyPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            EnemyPictureBox.Location = new Point(206, 31);
            EnemyPictureBox.Name = "EnemyPictureBox";
            EnemyPictureBox.Size = new Size(100, 100);
            EnemyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            EnemyPictureBox.TabIndex = 0;
            EnemyPictureBox.TabStop = false;
            // 
            // EnemyStrengthLabel
            // 
            EnemyStrengthLabel.BackColor = Color.Brown;
            EnemyStrengthLabel.BorderStyle = BorderStyle.FixedSingle;
            EnemyStrengthLabel.ForeColor = SystemColors.ActiveCaptionText;
            EnemyStrengthLabel.Image = (Image)resources.GetObject("EnemyStrengthLabel.Image");
            EnemyStrengthLabel.ImageAlign = ContentAlignment.TopLeft;
            EnemyStrengthLabel.Location = new Point(819, 80);
            EnemyStrengthLabel.Name = "EnemyStrengthLabel";
            EnemyStrengthLabel.Size = new Size(142, 23);
            EnemyStrengthLabel.TabIndex = 21;
            EnemyStrengthLabel.Text = "EnemyStrengthLabel";
            EnemyStrengthLabel.Font = alkhemikal;
            // 
            // PlayerStrengthLabel
            // 
            PlayerStrengthLabel.BackColor = Color.IndianRed;
            PlayerStrengthLabel.BorderStyle = BorderStyle.FixedSingle;
            PlayerStrengthLabel.Image = (Image)resources.GetObject("PlayerStrengthLabel.Image");
            PlayerStrengthLabel.Location = new Point(819, 116);
            PlayerStrengthLabel.Name = "PlayerStrengthLabel";
            PlayerStrengthLabel.Size = new Size(142, 23);
            PlayerStrengthLabel.TabIndex = 22;
            PlayerStrengthLabel.Text = "PlayerStrengthLabel";
            PlayerStrengthLabel.Font = alkhemikal;
            // 
            // PlayerGoldLabel
            // 
            PlayerGoldLabel.BackColor = Color.IndianRed;
            PlayerGoldLabel.BorderStyle = BorderStyle.FixedSingle;
            PlayerGoldLabel.Image = (Image)resources.GetObject("PlayerGoldLabel.Image");
            PlayerGoldLabel.Location = new Point(819, 150);
            PlayerGoldLabel.Name = "PlayerGoldLabel";
            PlayerGoldLabel.Size = new Size(142, 23);
            PlayerGoldLabel.TabIndex = 23;
            PlayerGoldLabel.Text = "PlayerGoldLabel";
            PlayerGoldLabel.Font = alkhemikal;
            // 
            // EnemyThreatLabel
            // 
            EnemyThreatLabel.BackColor = Color.Firebrick;
            EnemyThreatLabel.Image = (Image)resources.GetObject("EnemyThreatLabel.Image");
            EnemyThreatLabel.ImageAlign = ContentAlignment.TopLeft;
            EnemyThreatLabel.Location = new Point(967, 80);
            EnemyThreatLabel.Name = "EnemyThreatLabel";
            EnemyThreatLabel.Size = new Size(125, 23);
            EnemyThreatLabel.TabIndex = 24;
            EnemyThreatLabel.Text = "EnemyThreatLabel";
            EnemyThreatLabel.Font = alkhemikal;
            // 
            // PlayerThreatLabel
            // 
            PlayerThreatLabel.BackColor = Color.IndianRed;
            PlayerThreatLabel.BorderStyle = BorderStyle.FixedSingle;
            PlayerThreatLabel.Image = (Image)resources.GetObject("PlayerThreatLabel.Image");
            PlayerThreatLabel.Location = new Point(967, 116);
            PlayerThreatLabel.Name = "PlayerThreatLabel";
            PlayerThreatLabel.Size = new Size(125, 23);
            PlayerThreatLabel.TabIndex = 25;
            PlayerThreatLabel.Text = "PlayerThreatLabel";
            PlayerThreatLabel.Font = alkhemikal;
            // 
            // DirectionAndCoordinatesLabel
            // 
            DirectionAndCoordinatesLabel.BackColor = Color.Brown;
            DirectionAndCoordinatesLabel.Image = (Image)resources.GetObject("DirectionAndCoordinatesLabel.Image");
            DirectionAndCoordinatesLabel.ImageAlign = ContentAlignment.TopLeft;
            DirectionAndCoordinatesLabel.Location = new Point(86, 81);
            DirectionAndCoordinatesLabel.Name = "DirectionAndCoordinatesLabel";
            DirectionAndCoordinatesLabel.Size = new Size(301, 23);
            DirectionAndCoordinatesLabel.TabIndex = 26;
            DirectionAndCoordinatesLabel.Text = "DirectionAndCoordinatesLabel";
            DirectionAndCoordinatesLabel.Font = alkhemikal;
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Escape From Valusia";
            Load += ViewForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            IntroPanel.ResumeLayout(false);
            IntroPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MovementPanel.ResumeLayout(false);
            ParcelContentsPanel.ResumeLayout(false);
            ParcelContentsPanel.PerformLayout();
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
        private BufferedPanel MovementPanel;
        private Label ParcelInfoLabel;
        private Label EnemyInfoLabel;
        private TextBox PlayerConsoleTextBox;
        private Button FleeButton;
        private BufferedPanel ParcelContentsPanel;
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
        private Label RoomContentsLabel;
        private Label TerrainLabel;
        private Label EnemiesLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
