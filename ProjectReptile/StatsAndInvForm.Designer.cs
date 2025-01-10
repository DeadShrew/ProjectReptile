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
            label1 = new Label();
            PlayerInventoryListbox = new ListBox();
            button1 = new Button();
            ItemStatusLabel = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 194);
            label1.Name = "label1";
            label1.Size = new Size(179, 15);
            label1.TabIndex = 0;
            label1.Text = "woooooooooooooooooooooow";
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
            // button1
            // 
            button1.Location = new Point(354, 260);
            button1.Name = "button1";
            button1.Size = new Size(106, 46);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
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
            // button2
            // 
            button2.Location = new Point(355, 345);
            button2.Name = "button2";
            button2.Size = new Size(105, 23);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(356, 374);
            button3.Name = "button3";
            button3.Size = new Size(104, 23);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(357, 421);
            button4.Name = "button4";
            button4.Size = new Size(103, 23);
            button4.TabIndex = 6;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // StatsAndInvForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(ItemStatusLabel);
            Controls.Add(button1);
            Controls.Add(PlayerInventoryListbox);
            Controls.Add(label1);
            Name = "StatsAndInvForm";
            Text = "StatsAndInvForm";
            Load += StatsAndInvForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox PlayerInventoryListbox;
        private Button button1;
        private Label ItemStatusLabel;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}