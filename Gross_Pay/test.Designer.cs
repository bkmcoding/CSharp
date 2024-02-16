namespace Gross_Pay
{
    partial class test
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
            this.components = new System.ComponentModel.Container();
            this.backButton = new System.Windows.Forms.Button();
            this.employeeDataLabel = new System.Windows.Forms.Label();
            this.addEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addEmployeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.addEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployeesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(15, 15);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(97, 47);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // employeeDataLabel
            // 
            this.employeeDataLabel.AutoSize = true;
            this.employeeDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeDataLabel.Location = new System.Drawing.Point(184, 38);
            this.employeeDataLabel.Name = "employeeDataLabel";
            this.employeeDataLabel.Size = new System.Drawing.Size(138, 24);
            this.employeeDataLabel.TabIndex = 16;
            this.employeeDataLabel.Text = "Employee Data";
            // 
            // addEmployeesBindingSource
            // 
            this.addEmployeesBindingSource.DataSource = typeof(Gross_Pay.addEmployees);
            // 
            // addEmployeesBindingSource1
            // 
            this.addEmployeesBindingSource1.DataSource = typeof(Gross_Pay.addEmployees);
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.employeeDataLabel);
            this.Controls.Add(this.backButton);
            this.Name = "test";
            this.Size = new System.Drawing.Size(1000, 500);
            this.Load += new System.EventHandler(this.viewEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployeesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label employeeDataLabel;
        private System.Windows.Forms.BindingSource addEmployeesBindingSource;
        private System.Windows.Forms.BindingSource addEmployeesBindingSource1;
    }
}
