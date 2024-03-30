namespace HornetShooter
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            MenuLabel = new Label();
            StartButton = new Button();
            ExitButton = new Button();
            SettingsButton = new Button();
            SettingsMenu = new SettingsMenu();
            SuspendLayout();
            // 
            // MenuLabel
            // 
            MenuLabel.AutoSize = true;
            MenuLabel.BackColor = Color.Transparent;
            MenuLabel.Font = new Font("Bahnschrift SemiBold Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuLabel.Location = new Point(67, 49);
            MenuLabel.Name = "MenuLabel";
            MenuLabel.Size = new Size(264, 58);
            MenuLabel.TabIndex = 0;
            MenuLabel.Text = "Hornet Shooter";
            // 
            // StartButton
            // 
            StartButton.AutoEllipsis = true;
            StartButton.BackColor = Color.White;
            StartButton.Font = new Font("Bahnschrift SemiBold Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartButton.Location = new Point(119, 155);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(151, 43);
            StartButton.TabIndex = 1;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.AutoEllipsis = true;
            ExitButton.BackColor = Color.White;
            ExitButton.Font = new Font("Bahnschrift SemiBold Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(119, 305);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(151, 43);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // SettingsButton
            // 
            SettingsButton.AutoEllipsis = true;
            SettingsButton.BackColor = Color.White;
            SettingsButton.Font = new Font("Bahnschrift SemiBold Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingsButton.Location = new Point(119, 229);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(151, 43);
            SettingsButton.TabIndex = 3;
            SettingsButton.Text = "Settings";
            SettingsButton.UseVisualStyleBackColor = false;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // SettingsMenu
            // 
            SettingsMenu.BackgroundImage = (Image)resources.GetObject("SettingsMenu.BackgroundImage");
            SettingsMenu.BackgroundImageLayout = ImageLayout.None;
            SettingsMenu.Location = new Point(3, 3);
            SettingsMenu.Name = "SettingsMenu";
            SettingsMenu.Size = new Size(400, 400);
            SettingsMenu.TabIndex = 4;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(SettingsMenu);
            Controls.Add(SettingsButton);
            Controls.Add(ExitButton);
            Controls.Add(StartButton);
            Controls.Add(MenuLabel);
            Name = "Menu";
            Size = new Size(384, 396);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion\

        private Label MenuLabel;
        private Button StartButton;
        private Button ExitButton;
        private Button SettingsButton;
        private SettingsMenu settings1;
        private SettingsMenu SettingsMenu;
    }
}
