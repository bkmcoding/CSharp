namespace PhonebookManagerSQL
{
    partial class RemoveRecord
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
            txtID = new TextBox();
            lblID = new Label();
            btnExit = new Button();
            btnRemove = new Button();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(50, 63);
            txtID.Name = "txtID";
            txtID.Size = new Size(248, 23);
            txtID.TabIndex = 5;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(50, 37);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 23);
            lblID.TabIndex = 4;
            lblID.Text = "ID";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(81, 224);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(185, 47);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(81, 143);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(185, 47);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // RemoveRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 330);
            Controls.Add(btnExit);
            Controls.Add(btnRemove);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Name = "RemoveRecord";
            Text = "RemoveRecord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private Label lblID;
        private Button btnExit;
        private Button btnRemove;
    }
}