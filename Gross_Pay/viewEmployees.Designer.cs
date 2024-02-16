namespace Gross_Pay
{
    partial class viewEmployees
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
            this.backButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourlyWage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(15, 15);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(97, 47);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fname,
            this.lname,
            this.hourlyWage,
            this.hoursWorked,
            this.overtime,
            this.wage});
            this.dataGridView.Location = new System.Drawing.Point(137, 77);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(750, 350);
            this.dataGridView.TabIndex = 17;
            // 
            // fname
            // 
            this.fname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fname.HeaderText = "First Name";
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            // 
            // lname
            // 
            this.lname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lname.HeaderText = "Last Name";
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            // 
            // hourlyWage
            // 
            this.hourlyWage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hourlyWage.HeaderText = "Hourly Wage";
            this.hourlyWage.Name = "hourlyWage";
            this.hourlyWage.ReadOnly = true;
            // 
            // hoursWorked
            // 
            this.hoursWorked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoursWorked.HeaderText = "Hours Worked";
            this.hoursWorked.Name = "hoursWorked";
            this.hoursWorked.ReadOnly = true;
            // 
            // overtime
            // 
            this.overtime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.overtime.HeaderText = "Overtime";
            this.overtime.Name = "overtime";
            this.overtime.ReadOnly = true;
            // 
            // wage
            // 
            this.wage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wage.HeaderText = "Wage";
            this.wage.Name = "wage";
            this.wage.ReadOnly = true;
            // 
            // viewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.backButton);
            this.Name = "viewEmployees";
            this.Size = new System.Drawing.Size(1000, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourlyWage;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursWorked;
        private System.Windows.Forms.DataGridViewTextBoxColumn overtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn wage;
    }
}
