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
            PlayerInventoryListbox.Location = new Point(293, 279);
            PlayerInventoryListbox.Name = "PlayerInventoryListbox";
            PlayerInventoryListbox.Size = new Size(120, 94);
            PlayerInventoryListbox.TabIndex = 1;
            PlayerInventoryListbox.SelectedIndexChanged += PlayerInventoryListbox_SelectedIndexChanged;
            // 
            // StatsAndInvForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 450);
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
    }
}