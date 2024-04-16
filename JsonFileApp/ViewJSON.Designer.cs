namespace JsonFileApp
{
    partial class ViewJSON
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
            dgvJsonData = new DataGridView();
            button1 = new Button();
            FName = new DataGridViewTextBoxColumn();
            LName = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvJsonData).BeginInit();
            SuspendLayout();
            // 
            // dgvJsonData
            // 
            dgvJsonData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJsonData.Columns.AddRange(new DataGridViewColumn[] { FName, LName, Age });
            dgvJsonData.Location = new Point(-1, 1);
            dgvJsonData.Name = "dgvJsonData";
            dgvJsonData.Size = new Size(498, 364);
            dgvJsonData.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(107, 388);
            button1.Name = "button1";
            button1.Size = new Size(282, 47);
            button1.TabIndex = 1;
            button1.Text = "REFRESH";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FName
            // 
            FName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FName.HeaderText = "First Name";
            FName.Name = "FName";
            FName.ReadOnly = true;
            // 
            // LName
            // 
            LName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LName.HeaderText = "Last Name";
            LName.Name = "LName";
            LName.ReadOnly = true;
            // 
            // Age
            // 
            Age.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Age.HeaderText = "Age";
            Age.Name = "Age";
            Age.ReadOnly = true;
            // 
            // ViewJSON
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 450);
            Controls.Add(button1);
            Controls.Add(dgvJsonData);
            Name = "ViewJSON";
            Text = "ViewJSON";
            ((System.ComponentModel.ISupportInitialize)dgvJsonData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvJsonData;
        private Button button1;
        private DataGridViewTextBoxColumn FName;
        private DataGridViewTextBoxColumn LName;
        private DataGridViewTextBoxColumn Age;
    }
}