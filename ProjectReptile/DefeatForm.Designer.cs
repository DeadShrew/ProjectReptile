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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefeatForm));
            ExitButton = new Button();
            NewGameButton = new Button();
            ReplayButton = new Button();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(322, 270);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(91, 32);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "EXIT";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // NewGameButton
            // 
            NewGameButton.Location = new Point(102, 270);
            NewGameButton.Name = "NewGameButton";
            NewGameButton.Size = new Size(91, 32);
            NewGameButton.TabIndex = 2;
            NewGameButton.Text = "NEW GAME";
            NewGameButton.UseVisualStyleBackColor = true;
            NewGameButton.Click += NewGameButton_Click;
            // 
            // ReplayButton
            // 
            ReplayButton.Location = new Point(212, 270);
            ReplayButton.Name = "ReplayButton";
            ReplayButton.Size = new Size(90, 32);
            ReplayButton.TabIndex = 3;
            ReplayButton.Text = "REPLAY";
            ReplayButton.UseVisualStyleBackColor = true;
            ReplayButton.Click += ReplayButton_Click;
            // 
            // DefeatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(514, 326);
            Controls.Add(ReplayButton);
            Controls.Add(NewGameButton);
            Controls.Add(ExitButton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "DefeatForm";
            Text = "DefeatForm";
            ResumeLayout(false);
        }

        #endregion
        private Button ExitButton;
        private Button NewGameButton;
        private Button ReplayButton;
    }
}