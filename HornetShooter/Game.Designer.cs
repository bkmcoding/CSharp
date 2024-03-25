namespace HornetShooter
{
    partial class Game
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            Enemy = new PictureBox();
            ScoreLabel = new Label();
            MissShotLabel = new Label();
            TotalShotLabel = new Label();
            GameInterval = new System.Windows.Forms.Timer(components);
            ExitButton = new Button();
            RestartButton = new Button();
            GameOverLabel = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            CurrentTimeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)Enemy).BeginInit();
            SuspendLayout();
            // 
            // Enemy
            // 
            Enemy.BackColor = Color.Transparent;
            Enemy.BackgroundImageLayout = ImageLayout.None;
            Enemy.Image = (Image)resources.GetObject("Enemy.Image");
            Enemy.Location = new Point(682, 239);
            Enemy.Name = "Enemy";
            Enemy.Size = new Size(60, 60);
            Enemy.SizeMode = PictureBoxSizeMode.StretchImage;
            Enemy.TabIndex = 0;
            Enemy.TabStop = false;
            Enemy.MouseDown += Enemy_MouseDown;
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.BackColor = Color.Transparent;
            ScoreLabel.Font = new Font("Bahnschrift SemiBold SemiConden", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScoreLabel.Location = new Point(72, 9);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(99, 33);
            ScoreLabel.TabIndex = 1;
            ScoreLabel.Text = "Score=0";
            // 
            // MissShotLabel
            // 
            MissShotLabel.AutoSize = true;
            MissShotLabel.BackColor = Color.Transparent;
            MissShotLabel.Font = new Font("Bahnschrift SemiBold SemiConden", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MissShotLabel.Location = new Point(20, 38);
            MissShotLabel.Name = "MissShotLabel";
            MissShotLabel.Size = new Size(151, 33);
            MissShotLabel.TabIndex = 2;
            MissShotLabel.Text = "Miss Shots=0";
            // 
            // TotalShotLabel
            // 
            TotalShotLabel.AutoSize = true;
            TotalShotLabel.BackColor = Color.Transparent;
            TotalShotLabel.Font = new Font("Bahnschrift SemiBold SemiConden", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalShotLabel.Location = new Point(18, 71);
            TotalShotLabel.Name = "TotalShotLabel";
            TotalShotLabel.Size = new Size(153, 33);
            TotalShotLabel.TabIndex = 3;
            TotalShotLabel.Text = "Total Shots=0";
            // 
            // GameInterval
            // 
            GameInterval.Enabled = true;
            GameInterval.Interval = 500;
            GameInterval.Tick += Game_Interval_Tick;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.White;
            ExitButton.Font = new Font("Bahnschrift SemiBold Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(754, 8);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(93, 43);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // RestartButton
            // 
            RestartButton.BackColor = Color.White;
            RestartButton.Font = new Font("Bahnschrift SemiBold Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RestartButton.Location = new Point(754, 57);
            RestartButton.Name = "RestartButton";
            RestartButton.Size = new Size(93, 43);
            RestartButton.TabIndex = 7;
            RestartButton.Text = "Restart";
            RestartButton.UseVisualStyleBackColor = false;
            RestartButton.Click += RestartButton_Click;
            // 
            // GameOverLabel
            // 
            GameOverLabel.AutoSize = true;
            GameOverLabel.BackColor = Color.Transparent;
            GameOverLabel.Font = new Font("Bahnschrift SemiBold SemiConden", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GameOverLabel.Location = new Point(328, 13);
            GameOverLabel.Name = "GameOverLabel";
            GameOverLabel.Size = new Size(0, 58);
            GameOverLabel.TabIndex = 8;
            GameOverLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            // 
            // CurrentTimeLabel
            // 
            CurrentTimeLabel.AutoSize = true;
            CurrentTimeLabel.BackColor = Color.Transparent;
            CurrentTimeLabel.Font = new Font("Bahnschrift SemiBold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CurrentTimeLabel.Location = new Point(383, 9);
            CurrentTimeLabel.Name = "CurrentTimeLabel";
            CurrentTimeLabel.Size = new Size(104, 45);
            CurrentTimeLabel.TabIndex = 9;
            CurrentTimeLabel.Text = "00:00";
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(859, 461);
            Controls.Add(CurrentTimeLabel);
            Controls.Add(GameOverLabel);
            Controls.Add(RestartButton);
            Controls.Add(ExitButton);
            Controls.Add(TotalShotLabel);
            Controls.Add(MissShotLabel);
            Controls.Add(ScoreLabel);
            Controls.Add(Enemy);
            Cursor = Cursors.Cross;
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "Game";
            Text = "Form1";
            MouseDown += Game_MouseDown;
            ((System.ComponentModel.ISupportInitialize)Enemy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Enemy;
        private Label ScoreLabel;
        private Label MissShotLabel;
        private Label TotalShotLabel;
        private System.Windows.Forms.Timer GameInterval;
        private Button ExitButton;
        private Button RestartButton;
        private Label GameOverLabel;
        private System.Windows.Forms.Timer Timer;
        private Label CurrentTimeLabel;
    }
}
