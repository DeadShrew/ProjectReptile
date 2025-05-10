namespace ProjectReptile
{
    partial class NegotiationForm
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
            BribeAmountComboBox = new ComboBox();
            OkButton = new Button();
            CancelButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // BribeAmountComboBox
            // 
            BribeAmountComboBox.FormattingEnabled = true;
            BribeAmountComboBox.Location = new Point(261, 46);
            BribeAmountComboBox.Name = "BribeAmountComboBox";
            BribeAmountComboBox.Size = new Size(121, 23);
            BribeAmountComboBox.TabIndex = 0;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(106, 95);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(75, 23);
            OkButton.TabIndex = 1;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(249, 95);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 49);
            label1.Name = "label1";
            label1.Size = new Size(189, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter a bribe amount of 0 or more:";
            // 
            // NegotiationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 179);
            Controls.Add(label1);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Controls.Add(BribeAmountComboBox);
            Name = "NegotiationForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox BribeAmountComboBox;
        private Button OkButton;
        private Button CancelButton;
        private Label label1;
    }
}