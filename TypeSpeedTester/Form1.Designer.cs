namespace TypeSpeedTester
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
            MenuStrip = new MenuStrip();
            FileMenuSelection = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            SettingsMenuSelection = new ToolStripMenuItem();
            AppearanceMenuSelection = new ToolStripMenuItem();
            label1 = new Label();
            textBox1 = new TextBox();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.GripStyle = ToolStripGripStyle.Visible;
            MenuStrip.Items.AddRange(new ToolStripItem[] { FileMenuSelection, SettingsMenuSelection, AppearanceMenuSelection });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(984, 24);
            MenuStrip.TabIndex = 0;
            MenuStrip.Text = "MenuStrip";
            // 
            // FileMenuSelection
            // 
            FileMenuSelection.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            FileMenuSelection.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FileMenuSelection.Name = "FileMenuSelection";
            FileMenuSelection.Size = new Size(37, 20);
            FileMenuSelection.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // SettingsMenuSelection
            // 
            SettingsMenuSelection.Alignment = ToolStripItemAlignment.Right;
            SettingsMenuSelection.Name = "SettingsMenuSelection";
            SettingsMenuSelection.Size = new Size(61, 20);
            SettingsMenuSelection.Text = "Settings";
            // 
            // AppearanceMenuSelection
            // 
            AppearanceMenuSelection.Alignment = ToolStripItemAlignment.Right;
            AppearanceMenuSelection.Name = "AppearanceMenuSelection";
            AppearanceMenuSelection.Size = new Size(82, 20);
            AppearanceMenuSelection.Text = "Appearance";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(450, 109);
            label1.Name = "label1";
            label1.Size = new Size(71, 29);
            label1.TabIndex = 1;
            label1.Text = "Start";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(120, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(896, 43);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(MenuStrip);
            MainMenuStrip = MenuStrip;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem FileMenuSelection;
        private ToolStripMenuItem SettingsMenuSelection;
        private ToolStripMenuItem AppearanceMenuSelection;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label label1;
        private TextBox textBox1;
    }
}
