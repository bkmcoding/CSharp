namespace C_MoleShooterApp
{
    partial class Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            ShootTimeLabel = new Label();
            SaveButton = new Button();
            BackButton = new Button();
            label1 = new Label();
            TimeLimitLabel = new Label();
            ShootTime = new TextBox();
            MissLimit = new TextBox();
            TimeLimit = new TextBox();
            SuspendLayout();
            // 
            // ShootTimeLabel
            // 
            ShootTimeLabel.AutoSize = true;
            ShootTimeLabel.BackColor = Color.Transparent;
            ShootTimeLabel.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Bold);
            ShootTimeLabel.Location = new Point(35, 60);
            ShootTimeLabel.Name = "ShootTimeLabel";
            ShootTimeLabel.Size = new Size(129, 23);
            ShootTimeLabel.TabIndex = 0;
            ShootTimeLabel.Text = "Shoot Time (MS)";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.White;
            SaveButton.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(104, 276);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(172, 36);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.White;
            BackButton.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.Location = new Point(104, 331);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(172, 36);
            BackButton.TabIndex = 2;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Bold);
            label1.Location = new Point(35, 130);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 3;
            label1.Text = "Miss Limit";
            // 
            // TimeLimitLabel
            // 
            TimeLimitLabel.AutoSize = true;
            TimeLimitLabel.BackColor = Color.Transparent;
            TimeLimitLabel.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Bold);
            TimeLimitLabel.Location = new Point(35, 200);
            TimeLimitLabel.Name = "TimeLimitLabel";
            TimeLimitLabel.Size = new Size(110, 23);
            TimeLimitLabel.TabIndex = 4;
            TimeLimitLabel.Text = "Time Limit (S)";
            // 
            // ShootTime
            // 
            ShootTime.Location = new Point(200, 60);
            ShootTime.Name = "ShootTime";
            ShootTime.Size = new Size(148, 23);
            ShootTime.TabIndex = 5;
            // 
            // MissLimit
            // 
            MissLimit.Location = new Point(200, 130);
            MissLimit.Name = "MissLimit";
            MissLimit.Size = new Size(148, 23);
            MissLimit.TabIndex = 6;
            // 
            // TimeLimit
            // 
            TimeLimit.Location = new Point(200, 204);
            TimeLimit.Name = "TimeLimit";
            TimeLimit.Size = new Size(148, 23);
            TimeLimit.TabIndex = 7;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(TimeLimit);
            Controls.Add(MissLimit);
            Controls.Add(ShootTime);
            Controls.Add(TimeLimitLabel);
            Controls.Add(label1);
            Controls.Add(BackButton);
            Controls.Add(SaveButton);
            Controls.Add(ShootTimeLabel);
            Name = "Settings";
            Size = new Size(400, 400);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ShootTimeLabel;
        private Button SaveButton;
        private Button BackButton;
        private Label label1;
        private Label TimeLimitLabel;
        private TextBox ShootTime;
        private TextBox MissLimit;
        private TextBox TimeLimit;
    }
}
