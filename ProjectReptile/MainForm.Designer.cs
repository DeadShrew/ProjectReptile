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
            SuspendLayout();
            // 
            // UpButton
            // 
            UpButton.Location = new Point(381, 357);
            UpButton.Name = "UpButton";
            UpButton.Size = new Size(75, 23);
            UpButton.TabIndex = 0;
            UpButton.Text = "Up";
            UpButton.UseVisualStyleBackColor = true;
            UpButton.Click += UpButton_Click;
            // 
            // DownButton
            // 
            DownButton.Location = new Point(381, 415);
            DownButton.Name = "DownButton";
            DownButton.Size = new Size(75, 23);
            DownButton.TabIndex = 1;
            DownButton.Text = "Down";
            DownButton.UseVisualStyleBackColor = true;
            DownButton.Click += DownButton_Click;
            // 
            // LeftButton
            // 
            LeftButton.Location = new Point(331, 386);
            LeftButton.Name = "LeftButton";
            LeftButton.Size = new Size(75, 23);
            LeftButton.TabIndex = 2;
            LeftButton.Text = "Left";
            LeftButton.UseVisualStyleBackColor = true;
            LeftButton.Click += LeftButton_Click;
            // 
            // RightButton
            // 
            RightButton.Location = new Point(433, 386);
            RightButton.Name = "RightButton";
            RightButton.Size = new Size(75, 23);
            RightButton.TabIndex = 3;
            RightButton.Text = "Right";
            RightButton.UseVisualStyleBackColor = true;
            RightButton.Click += RightButton_Click;
            // 
            // AttackButton
            // 
            AttackButton.Location = new Point(540, 203);
            AttackButton.Name = "Attack_Button";
            AttackButton.Size = new Size(75, 23);
            AttackButton.TabIndex = 4;
            AttackButton.Text = "Attack";
            AttackButton.UseVisualStyleBackColor = true;
            AttackButton.Click += AttackButton_Click;
            // 
            // DefendButton
            // 
            DefendButton.Location = new Point(621, 203);
            DefendButton.Name = "DefendButton";
            DefendButton.Size = new Size(75, 23);
            DefendButton.TabIndex = 5;
            DefendButton.Text = "Defend";
            DefendButton.UseVisualStyleBackColor = true;
            DefendButton.Click += DefendButton_Click;
            // 
            // SorceryButton
            // 
            SorceryButton.Location = new Point(702, 203);
            SorceryButton.Name = "SorceryButton";
            SorceryButton.Size = new Size(75, 23);
            SorceryButton.TabIndex = 6;
            SorceryButton.Text = "Sorcery";
            SorceryButton.UseVisualStyleBackColor = true;
            SorceryButton.Click += SorceryButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(540, 232);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 7;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // TalkButton
            // 
            TalkButton.Location = new Point(621, 232);
            TalkButton.Name = "TalkButton";
            TalkButton.Size = new Size(75, 23);
            TalkButton.TabIndex = 8;
            TalkButton.Text = "Talk";
            TalkButton.UseVisualStyleBackColor = true;
            TalkButton.Click += TalkButton_Click;
            // 
            // StatsAndInvButton
            // 
            StatsAndInvButton.Location = new Point(540, 325);
            StatsAndInvButton.Name = "StatsAndInvButton";
            StatsAndInvButton.Size = new Size(237, 23);
            StatsAndInvButton.TabIndex = 10;
            StatsAndInvButton.Text = "Statistics and Inventory";
            StatsAndInvButton.UseVisualStyleBackColor = true;
            StatsAndInvButton.Click += StatsAndInvButton_Click;
            // 
            // GetItemButton
            // 
            GetItemButton.Location = new Point(702, 270);
            GetItemButton.Name = "GetItemButton";
            GetItemButton.Size = new Size(75, 23);
            GetItemButton.TabIndex = 11;
            GetItemButton.Text = "Get Item";
            GetItemButton.UseVisualStyleBackColor = true;
            GetItemButton.Click += GetItemButton_Click;
            // 
            // ViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(800, 450);
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
            DoubleBuffered = true;
            Name = "ViewForm";
            Text = "Form1";
            Load += ViewForm_Load;
            Paint += MapGrid;
            ResumeLayout(false);
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
    }
}
