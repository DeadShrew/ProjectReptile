namespace ProjectReptile
{
    partial class DefeatForm
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
            DefeatLabel = new Label();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // DefeatLabel
            // 
            DefeatLabel.AutoSize = true;
            DefeatLabel.Font = new Font("Segoe UI", 44F);
            DefeatLabel.Location = new Point(144, 60);
            DefeatLabel.Name = "DefeatLabel";
            DefeatLabel.Size = new Size(228, 78);
            DefeatLabel.TabIndex = 0;
            DefeatLabel.Text = "DEFEAT";
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(216, 201);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "EXIT";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DefeatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 326);
            Controls.Add(ExitButton);
            Controls.Add(DefeatLabel);
            Name = "DefeatForm";
            Text = "DefeatForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DefeatLabel;
        private Button ExitButton;
    }
}