namespace ProjectReptile
{
    partial class StatsAndInvForm
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
            CharacterNameLabel = new Label();
            PlayerInventoryListbox = new ListBox();
            DoneButton = new Button();
            ItemStatusLabel = new Label();
            UseItemButton = new Button();
            UnuseItemButton = new Button();
            DropItemButton = new Button();
            CharNameTextBoxLabel = new Label();
            MaxStrengthLabel = new Label();
            MaxDexterityLabel = new Label();
            IntLabel = new Label();
            CollectedGoldLabel = new Label();
            ReadyWeaponLabel = new Label();
            ReadyShieldLabel = new Label();
            ArmourWornLabel = new Label();
            CurrentStrengthLabel = new Label();
            ModifiedDexLabel = new Label();
            ModifiedIntLabel = new Label();
            WeaponLabel = new Label();
            ArmourLabel = new Label();
            GoldTextBoxLabel = new Label();
            GoldKeyLabel = new Label();
            MaxStrengthTextBoxLabel = new Label();
            MaxDexTextBoxLabel = new Label();
            IntelligenceTextBoxLabel = new Label();
            WeaponTextBoxLabel = new Label();
            ArmourTextBoxLabel = new Label();
            CurrentStrengthTextBoxLabel = new Label();
            ModifiedTextBoxLabel = new Label();
            ModifiedIntTextBoxLabel = new Label();
            SuspendLayout();
            // 
            // CharacterNameLabel
            // 
            CharacterNameLabel.AutoSize = true;
            CharacterNameLabel.Font = new Font("Segoe UI", 14F);
            CharacterNameLabel.Location = new Point(61, 15);
            CharacterNameLabel.Name = "CharacterNameLabel";
            CharacterNameLabel.Size = new Size(153, 25);
            CharacterNameLabel.TabIndex = 0;
            CharacterNameLabel.Text = "Character Name:";
            // 
            // PlayerInventoryListbox
            // 
            PlayerInventoryListbox.FormattingEnabled = true;
            PlayerInventoryListbox.ItemHeight = 15;
            PlayerInventoryListbox.Location = new Point(4, 260);
            PlayerInventoryListbox.Name = "PlayerInventoryListbox";
            PlayerInventoryListbox.ScrollAlwaysVisible = true;
            PlayerInventoryListbox.Size = new Size(344, 184);
            PlayerInventoryListbox.TabIndex = 1;
            PlayerInventoryListbox.SelectedIndexChanged += PlayerInventoryListbox_SelectedIndexChanged;
            // 
            // DoneButton
            // 
            DoneButton.Location = new Point(354, 260);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(106, 46);
            DoneButton.TabIndex = 2;
            DoneButton.Text = "Done";
            DoneButton.UseVisualStyleBackColor = true;
            DoneButton.Click += DoneButton_Click;
            // 
            // ItemStatusLabel
            // 
            ItemStatusLabel.BackColor = SystemColors.ActiveCaption;
            ItemStatusLabel.BorderStyle = BorderStyle.FixedSingle;
            ItemStatusLabel.Location = new Point(354, 309);
            ItemStatusLabel.Name = "ItemStatusLabel";
            ItemStatusLabel.Size = new Size(106, 23);
            ItemStatusLabel.TabIndex = 3;
            // 
            // UseItemButton
            // 
            UseItemButton.Location = new Point(355, 345);
            UseItemButton.Name = "UseItemButton";
            UseItemButton.Size = new Size(105, 23);
            UseItemButton.TabIndex = 4;
            UseItemButton.Text = "Use Item";
            UseItemButton.UseVisualStyleBackColor = true;
            UseItemButton.Click += UseItemButton_Click;
            // 
            // UnuseItemButton
            // 
            UnuseItemButton.Location = new Point(356, 374);
            UnuseItemButton.Name = "UnuseItemButton";
            UnuseItemButton.Size = new Size(104, 23);
            UnuseItemButton.TabIndex = 5;
            UnuseItemButton.Text = "Unuse Item";
            UnuseItemButton.UseVisualStyleBackColor = true;
            UnuseItemButton.Click += UnuseItemButton_Click;
            // 
            // DropItemButton
            // 
            DropItemButton.Location = new Point(357, 421);
            DropItemButton.Name = "DropItemButton";
            DropItemButton.Size = new Size(103, 23);
            DropItemButton.TabIndex = 6;
            DropItemButton.Text = "Drop Item";
            DropItemButton.UseVisualStyleBackColor = true;
            DropItemButton.Click += DropItemButton_Click;
            // 
            // CharNameTextBoxLabel
            // 
            CharNameTextBoxLabel.BorderStyle = BorderStyle.FixedSingle;
            CharNameTextBoxLabel.Font = new Font("Segoe UI", 14F);
            CharNameTextBoxLabel.Location = new Point(248, 17);
            CharNameTextBoxLabel.Name = "CharNameTextBoxLabel";
            CharNameTextBoxLabel.Size = new Size(100, 23);
            CharNameTextBoxLabel.TabIndex = 7;
            CharNameTextBoxLabel.Text = "Rolf";
            // 
            // MaxStrengthLabel
            // 
            MaxStrengthLabel.AutoSize = true;
            MaxStrengthLabel.Location = new Point(69, 61);
            MaxStrengthLabel.Name = "MaxStrengthLabel";
            MaxStrengthLabel.Size = new Size(81, 15);
            MaxStrengthLabel.TabIndex = 8;
            MaxStrengthLabel.Text = "Max Strength:";
            // 
            // MaxDexterityLabel
            // 
            MaxDexterityLabel.AutoSize = true;
            MaxDexterityLabel.Location = new Point(67, 85);
            MaxDexterityLabel.Name = "MaxDexterityLabel";
            MaxDexterityLabel.Size = new Size(83, 15);
            MaxDexterityLabel.TabIndex = 9;
            MaxDexterityLabel.Text = "Max Dexterity:";
            // 
            // IntLabel
            // 
            IntLabel.AutoSize = true;
            IntLabel.Location = new Point(79, 110);
            IntLabel.Name = "IntLabel";
            IntLabel.Size = new Size(71, 15);
            IntLabel.TabIndex = 10;
            IntLabel.Text = "Intelligence:";
            // 
            // CollectedGoldLabel
            // 
            CollectedGoldLabel.AutoSize = true;
            CollectedGoldLabel.Location = new Point(60, 145);
            CollectedGoldLabel.Name = "CollectedGoldLabel";
            CollectedGoldLabel.Size = new Size(88, 15);
            CollectedGoldLabel.TabIndex = 11;
            CollectedGoldLabel.Text = "Collected Gold:";
            // 
            // ReadyWeaponLabel
            // 
            ReadyWeaponLabel.AutoSize = true;
            ReadyWeaponLabel.Location = new Point(60, 180);
            ReadyWeaponLabel.Name = "ReadyWeaponLabel";
            ReadyWeaponLabel.Size = new Size(89, 15);
            ReadyWeaponLabel.TabIndex = 12;
            ReadyWeaponLabel.Text = "Ready Weapon:";
            // 
            // ReadyShieldLabel
            // 
            ReadyShieldLabel.AutoSize = true;
            ReadyShieldLabel.Location = new Point(69, 205);
            ReadyShieldLabel.Name = "ReadyShieldLabel";
            ReadyShieldLabel.Size = new Size(77, 15);
            ReadyShieldLabel.TabIndex = 13;
            ReadyShieldLabel.Text = "Ready Shield:";
            // 
            // ArmourWornLabel
            // 
            ArmourWornLabel.AutoSize = true;
            ArmourWornLabel.Location = new Point(60, 231);
            ArmourWornLabel.Name = "ArmourWornLabel";
            ArmourWornLabel.Size = new Size(83, 15);
            ArmourWornLabel.TabIndex = 14;
            ArmourWornLabel.Text = "Armour Worn:";
            // 
            // CurrentStrengthLabel
            // 
            CurrentStrengthLabel.AutoSize = true;
            CurrentStrengthLabel.Location = new Point(248, 61);
            CurrentStrengthLabel.Name = "CurrentStrengthLabel";
            CurrentStrengthLabel.Size = new Size(67, 15);
            CurrentStrengthLabel.TabIndex = 15;
            CurrentStrengthLabel.Text = "Current Str:";
            // 
            // ModifiedDexLabel
            // 
            ModifiedDexLabel.AutoSize = true;
            ModifiedDexLabel.Location = new Point(234, 85);
            ModifiedDexLabel.Name = "ModifiedDexLabel";
            ModifiedDexLabel.Size = new Size(81, 15);
            ModifiedDexLabel.TabIndex = 16;
            ModifiedDexLabel.Text = "Modified Dex:";
            // 
            // ModifiedIntLabel
            // 
            ModifiedIntLabel.AutoSize = true;
            ModifiedIntLabel.Location = new Point(240, 110);
            ModifiedIntLabel.Name = "ModifiedIntLabel";
            ModifiedIntLabel.Size = new Size(75, 15);
            ModifiedIntLabel.TabIndex = 17;
            ModifiedIntLabel.Text = "Modified Int:";
            // 
            // WeaponLabel
            // 
            WeaponLabel.AutoSize = true;
            WeaponLabel.Location = new Point(383, 164);
            WeaponLabel.Name = "WeaponLabel";
            WeaponLabel.Size = new Size(51, 15);
            WeaponLabel.TabIndex = 18;
            WeaponLabel.Text = "Weapon";
            // 
            // ArmourLabel
            // 
            ArmourLabel.AutoSize = true;
            ArmourLabel.Location = new Point(383, 205);
            ArmourLabel.Name = "ArmourLabel";
            ArmourLabel.Size = new Size(48, 15);
            ArmourLabel.TabIndex = 19;
            ArmourLabel.Text = "Armour";
            // 
            // GoldTextBoxLabel
            // 
            GoldTextBoxLabel.BorderStyle = BorderStyle.FixedSingle;
            GoldTextBoxLabel.Location = new Point(162, 145);
            GoldTextBoxLabel.Name = "GoldTextBoxLabel";
            GoldTextBoxLabel.Size = new Size(32, 23);
            GoldTextBoxLabel.TabIndex = 20;
            // 
            // GoldKeyLabel
            // 
            GoldKeyLabel.BorderStyle = BorderStyle.FixedSingle;
            GoldKeyLabel.Location = new Point(215, 144);
            GoldKeyLabel.Name = "GoldKeyLabel";
            GoldKeyLabel.Size = new Size(108, 23);
            GoldKeyLabel.TabIndex = 21;
            GoldKeyLabel.Text = "Gold Key needed.";
            // 
            // MaxStrengthTextBoxLabel
            // 
            MaxStrengthTextBoxLabel.BorderStyle = BorderStyle.FixedSingle;
            MaxStrengthTextBoxLabel.Location = new Point(162, 53);
            MaxStrengthTextBoxLabel.Name = "MaxStrengthTextBoxLabel";
            MaxStrengthTextBoxLabel.Size = new Size(29, 23);
            MaxStrengthTextBoxLabel.TabIndex = 22;
            // 
            // MaxDexTextBoxLabel
            // 
            MaxDexTextBoxLabel.BorderStyle = BorderStyle.FixedSingle;
            MaxDexTextBoxLabel.Location = new Point(162, 77);
            MaxDexTextBoxLabel.Name = "MaxDexTextBoxLabel";
            MaxDexTextBoxLabel.Size = new Size(29, 23);
            MaxDexTextBoxLabel.TabIndex = 23;
            // 
            // IntelligenceTextBoxLabel
            // 
            IntelligenceTextBoxLabel.BorderStyle = BorderStyle.FixedSingle;
            IntelligenceTextBoxLabel.Location = new Point(162, 102);
            IntelligenceTextBoxLabel.Name = "IntelligenceTextBoxLabel";
            IntelligenceTextBoxLabel.Size = new Size(29, 23);
            IntelligenceTextBoxLabel.TabIndex = 24;
            // 
            // WeaponTextBoxLabel
            // 
            WeaponTextBoxLabel.BorderStyle = BorderStyle.FixedSingle;
            WeaponTextBoxLabel.Location = new Point(395, 182);
            WeaponTextBoxLabel.Name = "WeaponTextBoxLabel";
            WeaponTextBoxLabel.Size = new Size(27, 23);
            WeaponTextBoxLabel.TabIndex = 25;
            // 
            // ArmourTextBoxLabel
            // 
            ArmourTextBoxLabel.BorderStyle = BorderStyle.FixedSingle;
            ArmourTextBoxLabel.Location = new Point(395, 222);
            ArmourTextBoxLabel.Name = "ArmourTextBoxLabel";
            ArmourTextBoxLabel.Size = new Size(27, 23);
            ArmourTextBoxLabel.TabIndex = 26;
            // 
            // CurrentStrengthTextBoxLabel
            // 
            CurrentStrengthTextBoxLabel.BorderStyle = BorderStyle.FixedSingle;
            CurrentStrengthTextBoxLabel.Location = new Point(321, 53);
            CurrentStrengthTextBoxLabel.Name = "CurrentStrengthTextBoxLabel";
            CurrentStrengthTextBoxLabel.Size = new Size(29, 23);
            CurrentStrengthTextBoxLabel.TabIndex = 27;
            // 
            // ModifiedTextBoxLabel
            // 
            ModifiedTextBoxLabel.BorderStyle = BorderStyle.FixedSingle;
            ModifiedTextBoxLabel.Location = new Point(321, 80);
            ModifiedTextBoxLabel.Name = "ModifiedTextBoxLabel";
            ModifiedTextBoxLabel.Size = new Size(29, 23);
            ModifiedTextBoxLabel.TabIndex = 28;
            // 
            // ModifiedIntTextBoxLabel
            // 
            ModifiedIntTextBoxLabel.BorderStyle = BorderStyle.FixedSingle;
            ModifiedIntTextBoxLabel.Location = new Point(321, 109);
            ModifiedIntTextBoxLabel.Name = "ModifiedIntTextBoxLabel";
            ModifiedIntTextBoxLabel.Size = new Size(29, 23);
            ModifiedIntTextBoxLabel.TabIndex = 29;
            // 
            // StatsAndInvForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(479, 456);
            ControlBox = false;
            Controls.Add(ModifiedIntTextBoxLabel);
            Controls.Add(ModifiedTextBoxLabel);
            Controls.Add(CurrentStrengthTextBoxLabel);
            Controls.Add(ArmourTextBoxLabel);
            Controls.Add(WeaponTextBoxLabel);
            Controls.Add(IntelligenceTextBoxLabel);
            Controls.Add(MaxDexTextBoxLabel);
            Controls.Add(MaxStrengthTextBoxLabel);
            Controls.Add(GoldKeyLabel);
            Controls.Add(GoldTextBoxLabel);
            Controls.Add(ArmourLabel);
            Controls.Add(WeaponLabel);
            Controls.Add(ModifiedIntLabel);
            Controls.Add(ModifiedDexLabel);
            Controls.Add(CurrentStrengthLabel);
            Controls.Add(ArmourWornLabel);
            Controls.Add(ReadyShieldLabel);
            Controls.Add(ReadyWeaponLabel);
            Controls.Add(CollectedGoldLabel);
            Controls.Add(IntLabel);
            Controls.Add(MaxDexterityLabel);
            Controls.Add(MaxStrengthLabel);
            Controls.Add(CharNameTextBoxLabel);
            Controls.Add(DropItemButton);
            Controls.Add(UnuseItemButton);
            Controls.Add(UseItemButton);
            Controls.Add(ItemStatusLabel);
            Controls.Add(DoneButton);
            Controls.Add(PlayerInventoryListbox);
            Controls.Add(CharacterNameLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Location = new Point(385, 97);
            MaximizeBox = false;
            Name = "StatsAndInvForm";
            StartPosition = FormStartPosition.Manual;
            Text = "StatsAndInvForm";
            Load += StatsAndInvForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CharacterNameLabel;
        private ListBox PlayerInventoryListbox;
        private Button DoneButton;
        private Label ItemStatusLabel;
        private Button UseItemButton;
        private Button UnuseItemButton;
        private Button DropItemButton;
        private Label CharNameTextBoxLabel;
        private Label MaxStrengthLabel;
        private Label MaxDexterityLabel;
        private Label IntLabel;
        private Label CollectedGoldLabel;
        private Label ReadyWeaponLabel;
        private Label ReadyShieldLabel;
        private Label ArmourWornLabel;
        private Label CurrentStrengthLabel;
        private Label ModifiedDexLabel;
        private Label ModifiedIntLabel;
        private Label WeaponLabel;
        private Label ArmourLabel;
        private Label GoldTextBoxLabel;
        private Label GoldKeyLabel;
        private Label MaxStrengthTextBoxLabel;
        private Label MaxDexTextBoxLabel;
        private Label IntelligenceTextBoxLabel;
        private Label WeaponTextBoxLabel;
        private Label ArmourTextBoxLabel;
        private Label CurrentStrengthTextBoxLabel;
        private Label ModifiedTextBoxLabel;
        private Label ModifiedIntTextBoxLabel;
    }
}