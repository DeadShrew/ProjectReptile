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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // UpButton
            // 
            UpButton.Location = new Point(381, 462);
            UpButton.Name = "UpButton";
            UpButton.Size = new Size(75, 23);
            UpButton.TabIndex = 0;
            UpButton.Text = "Up";
            UpButton.UseVisualStyleBackColor = true;
            UpButton.Click += UpButton_Click;
            // 
            // DownButton
            // 
            DownButton.Location = new Point(381, 500);
            DownButton.Name = "DownButton";
            DownButton.Size = new Size(75, 23);
            DownButton.TabIndex = 1;
            DownButton.Text = "Down";
            DownButton.UseVisualStyleBackColor = true;
            DownButton.Click += DownButton_Click;
            // 
            // LeftButton
            // 
            LeftButton.Location = new Point(300, 480);
            LeftButton.Name = "LeftButton";
            LeftButton.Size = new Size(75, 23);
            LeftButton.TabIndex = 2;
            LeftButton.Text = "Left";
            LeftButton.UseVisualStyleBackColor = true;
            LeftButton.Click += LeftButton_Click;
            // 
            // RightButton
            // 
            RightButton.Location = new Point(459, 480);
            RightButton.Name = "RightButton";
            RightButton.Size = new Size(75, 23);
            RightButton.TabIndex = 3;
            RightButton.Text = "Right";
            RightButton.UseVisualStyleBackColor = true;
            RightButton.Click += RightButton_Click;
            // 
            // AttackButton
            // 
            AttackButton.Location = new Point(621, 319);
            AttackButton.Name = "AttackButton";
            AttackButton.Size = new Size(75, 23);
            AttackButton.TabIndex = 4;
            AttackButton.Text = "Attack";
            AttackButton.UseVisualStyleBackColor = true;
            AttackButton.Click += AttackButton_Click;
            // 
            // DefendButton
            // 
            DefendButton.Location = new Point(702, 319);
            DefendButton.Name = "DefendButton";
            DefendButton.Size = new Size(75, 23);
            DefendButton.TabIndex = 5;
            DefendButton.Text = "Defend";
            DefendButton.UseVisualStyleBackColor = true;
            DefendButton.Click += DefendButton_Click;
            // 
            // SorceryButton
            // 
            SorceryButton.Location = new Point(783, 319);
            SorceryButton.Name = "SorceryButton";
            SorceryButton.Size = new Size(75, 23);
            SorceryButton.TabIndex = 6;
            SorceryButton.Text = "Sorcery";
            SorceryButton.UseVisualStyleBackColor = true;
            SorceryButton.Click += SorceryButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(621, 348);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 7;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // TalkButton
            // 
            TalkButton.Location = new Point(702, 348);
            TalkButton.Name = "TalkButton";
            TalkButton.Size = new Size(75, 23);
            TalkButton.TabIndex = 8;
            TalkButton.Text = "Talk";
            TalkButton.UseVisualStyleBackColor = true;
            TalkButton.Click += TalkButton_Click;
            // 
            // StatsAndInvButton
            // 
            StatsAndInvButton.Location = new Point(621, 447);
            StatsAndInvButton.Name = "StatsAndInvButton";
            StatsAndInvButton.Size = new Size(237, 23);
            StatsAndInvButton.TabIndex = 10;
            StatsAndInvButton.Text = "Statistics and Inventory";
            StatsAndInvButton.UseVisualStyleBackColor = true;
            StatsAndInvButton.Click += StatsAndInvButton_Click;
            // 
            // GetItemButton
            // 
            GetItemButton.Location = new Point(783, 390);
            GetItemButton.Name = "GetItemButton";
            GetItemButton.Size = new Size(75, 23);
            GetItemButton.TabIndex = 11;
            GetItemButton.Text = "Get Item";
            GetItemButton.UseVisualStyleBackColor = true;
            GetItemButton.Click += GetItemButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gameToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(884, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            gameToolStripMenuItem.Size = new Size(50, 20);
            gameToolStripMenuItem.Text = "Game";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // MapGridPanel
            // 
            MapGridPanel.Location = new Point(43, 82);
            MapGridPanel.Name = "MapGridPanel";
            MapGridPanel.Size = new Size(301, 301);
            MapGridPanel.TabIndex = 13;
            MapGridPanel.Paint += MapGridPanel_Paint;
            // 
            // ParcelItemList
            // 
            ParcelItemList.FormattingEnabled = true;
            ParcelItemList.ItemHeight = 15;
            ParcelItemList.Location = new Point(621, 377);
            ParcelItemList.Name = "ParcelItemList";
            ParcelItemList.Size = new Size(156, 64);
            ParcelItemList.TabIndex = 14;
            ParcelItemList.SelectedIndexChanged += ParcelItemList_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(884, 636);
            Controls.Add(ParcelItemList);
            Controls.Add(MapGridPanel);
            Controls.Add(GetItemButton);
            Controls.Add(StatsAndInvButton);
            Controls.Add(TalkButton);
            Controls.Add(SearchButton);
            Controls.Add(SorceryButton);
            Controls.Add(DefendButton);
            Controls.Add(AttackButton);
            Controls.Add(UpButton);
            Controls.Add(DownButton);
            Controls.Add(LeftButton);
            Controls.Add(RightButton);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            Load += ViewForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}
