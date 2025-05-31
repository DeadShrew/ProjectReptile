namespace ProjectReptile
{
    partial class VictoryForm
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
            ReplayButton = new Button();
            NewGameButton = new Button();
            ExitButton = new Button();
            VictoryLabel = new Label();
            SuspendLayout();
            // 
            // ReplayButton
            // 
            ReplayButton.Cursor = Cursors.No;
            ReplayButton.Location = new Point(221, 234);
            ReplayButton.Name = "ReplayButton";
            ReplayButton.Size = new Size(75, 23);
            ReplayButton.TabIndex = 7;
            ReplayButton.Text = "REPLAY";
            ReplayButton.UseVisualStyleBackColor = true;
            ReplayButton.Click += ReplayButton_Click;
            // 
            // NewGameButton
            // 
            NewGameButton.Cursor = Cursors.No;
            NewGameButton.Location = new Point(111, 234);
            NewGameButton.Name = "NewGameButton";
            NewGameButton.Size = new Size(79, 23);
            NewGameButton.TabIndex = 6;
            NewGameButton.Text = "NEW GAME";
            NewGameButton.UseVisualStyleBackColor = true;
            NewGameButton.Click += NewGameButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Cursor = Cursors.No;
            ExitButton.Location = new Point(328, 234);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "EXIT";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // VictoryLabel
            // 
            VictoryLabel.AutoSize = true;
            VictoryLabel.Cursor = Cursors.No;
            VictoryLabel.Font = new Font("Segoe UI", 44F);
            VictoryLabel.Location = new Point(138, 69);
            VictoryLabel.Name = "VictoryLabel";
            VictoryLabel.Size = new Size(262, 78);
            VictoryLabel.TabIndex = 4;
            VictoryLabel.Text = "VICTORY";
            // 
            // VictoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 326);
            Controls.Add(ReplayButton);
            Controls.Add(NewGameButton);
            Controls.Add(ExitButton);
            Controls.Add(VictoryLabel);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VictoryForm";
            Text = "VictoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ReplayButton;
        private Button NewGameButton;
        private Button ExitButton;
        private Label VictoryLabel;
    }
}