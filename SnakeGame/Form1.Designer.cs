namespace SnakeGame
{
    partial class Form1
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
            pbCanvas = new PictureBox();
            ScoreLabel = new Label();
            panel1 = new Panel();
            gameTimer = new System.Windows.Forms.Timer(components);
            GameOverLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pbCanvas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbCanvas
            // 
            pbCanvas.BackColor = SystemColors.ControlDark;
            pbCanvas.BorderStyle = BorderStyle.FixedSingle;
            pbCanvas.Location = new Point(0, 0);
            pbCanvas.Name = "pbCanvas";
            pbCanvas.Size = new Size(720, 500);
            pbCanvas.TabIndex = 0;
            pbCanvas.TabStop = false;
            pbCanvas.Paint += pbCanvas_Paint;
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.Font = new Font("Bahnschrift", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ScoreLabel.Location = new Point(19, 19);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(97, 35);
            ScoreLabel.TabIndex = 1;
            ScoreLabel.Text = "Score:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ScoreLabel);
            panel1.Location = new Point(719, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 500);
            panel1.TabIndex = 2;
            // 
            // GameOverLabel
            // 
            GameOverLabel.AutoSize = true;
            GameOverLabel.Font = new Font("Bahnschrift", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GameOverLabel.Location = new Point(72, 51);
            GameOverLabel.Name = "GameOverLabel";
            GameOverLabel.Size = new Size(97, 39);
            GameOverLabel.TabIndex = 3;
            GameOverLabel.Text = "label1";
            GameOverLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
            Controls.Add(GameOverLabel);
            Controls.Add(panel1);
            Controls.Add(pbCanvas);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pbCanvas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private PictureBox pbCanvas;
        private Label ScoreLabel;
        private Panel panel1;
        private System.Windows.Forms.Timer gameTimer;
        private Label GameOverLabel;
    }
}
