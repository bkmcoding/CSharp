namespace JsonFileApp
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
            lblFName = new Label();
            txtFName = new TextBox();
            txtLName = new TextBox();
            lblLName = new Label();
            txtAge = new TextBox();
            lblAge = new Label();
            AddButton = new Button();
            ViewButton = new Button();
            SuspendLayout();
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFName.Location = new Point(97, 56);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(104, 23);
            lblFName.TabIndex = 0;
            lblFName.Text = "First Name";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(97, 84);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(324, 23);
            txtFName.TabIndex = 1;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(97, 194);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(324, 23);
            txtLName.TabIndex = 3;
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLName.Location = new Point(97, 166);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(101, 23);
            lblLName.TabIndex = 2;
            lblLName.Text = "Last Name";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(97, 322);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(324, 23);
            txtAge.TabIndex = 5;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(97, 294);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(42, 23);
            lblAge.TabIndex = 4;
            lblAge.Text = "Age";
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.Location = new Point(533, 84);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(181, 79);
            AddButton.TabIndex = 6;
            AddButton.Text = "ADD";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ViewButton
            // 
            ViewButton.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ViewButton.Location = new Point(533, 266);
            ViewButton.Name = "ViewButton";
            ViewButton.Size = new Size(181, 79);
            ViewButton.TabIndex = 7;
            ViewButton.Text = "VIEW";
            ViewButton.UseVisualStyleBackColor = true;
            ViewButton.Click += ViewButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ViewButton);
            Controls.Add(AddButton);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(txtLName);
            Controls.Add(lblLName);
            Controls.Add(txtFName);
            Controls.Add(lblFName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFName;
        private TextBox txtFName;
        private TextBox txtLName;
        private Label lblLName;
        private TextBox txtAge;
        private Label lblAge;
        private Button AddButton;
        private Button ViewButton;
    }
}
