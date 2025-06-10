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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VictoryForm));
            ReplayButton = new Button();
            NewGameButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // ReplayButton
            // 
            ReplayButton.Cursor = Cursors.No;
            ReplayButton.Location = new Point(213, 270);
            ReplayButton.Name = "ReplayButton";
            ReplayButton.Size = new Size(90, 34);
            ReplayButton.TabIndex = 7;
            ReplayButton.Text = "REPLAY";
            ReplayButton.UseVisualStyleBackColor = true;
            ReplayButton.Click += ReplayButton_Click;
            // 
            // NewGameButton
            // 
            NewGameButton.Cursor = Cursors.No;
            NewGameButton.Location = new Point(103, 270);
            NewGameButton.Name = "NewGameButton";
            NewGameButton.Size = new Size(90, 34);
            NewGameButton.TabIndex = 6;
            NewGameButton.Text = "NEW GAME";
            NewGameButton.UseVisualStyleBackColor = true;
            NewGameButton.Click += NewGameButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Cursor = Cursors.No;
            ExitButton.Location = new Point(323, 270);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(90, 34);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "EXIT";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // VictoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(514, 326);
            Controls.Add(ReplayButton);
            Controls.Add(NewGameButton);
            Controls.Add(ExitButton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VictoryForm";
            Text = "VictoryForm";
            ResumeLayout(false);
        }

        #endregion

        private Button ReplayButton;
        private Button NewGameButton;
        private Button ExitButton;
        private Label VictoryLabel;
    }
}