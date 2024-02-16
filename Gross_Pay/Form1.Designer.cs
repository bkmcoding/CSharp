namespace Gross_Pay
{
    partial class Form1
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
            this.dataSet1 = new System.Data.DataSet();
            this.viewEmployees = new System.Windows.Forms.Button();
            this.addEmployees = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.addEmployees1 = new Gross_Pay.addEmployees();
            this.viewEmployees1 = new Gross_Pay.viewEmployees();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // viewEmployees
            // 
            this.viewEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.viewEmployees.Location = new System.Drawing.Point(550, 200);
            this.viewEmployees.Name = "viewEmployees";
            this.viewEmployees.Size = new System.Drawing.Size(282, 162);
            this.viewEmployees.TabIndex = 5;
            this.viewEmployees.Text = "View Employee Data";
            this.viewEmployees.UseVisualStyleBackColor = true;
            this.viewEmployees.Click += new System.EventHandler(this.viewEmployees_Click);
            // 
            // addEmployees
            // 
            this.addEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployees.Location = new System.Drawing.Point(150, 200);
            this.addEmployees.Name = "addEmployees";
            this.addEmployees.Size = new System.Drawing.Size(282, 162);
            this.addEmployees.TabIndex = 6;
            this.addEmployees.Text = "Add New Employees";
            this.addEmployees.UseVisualStyleBackColor = true;
            this.addEmployees.Click += new System.EventHandler(this.addEmployees_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(329, 72);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(331, 73);
            this.mainLabel.TabIndex = 7;
            this.mainLabel.Text = "Gross Pay";
            // 
            // addEmployees1
            // 
            this.addEmployees1.Location = new System.Drawing.Point(0, 0);
            this.addEmployees1.Name = "addEmployees1";
            this.addEmployees1.Size = new System.Drawing.Size(1000, 500);
            this.addEmployees1.TabIndex = 8;
            this.addEmployees1.Visible = false;
            // 
            // viewEmployees1
            // 
            this.viewEmployees1.Location = new System.Drawing.Point(0, 0);
            this.viewEmployees1.Name = "viewEmployees1";
            this.viewEmployees1.Size = new System.Drawing.Size(1000, 500);
            this.viewEmployees1.TabIndex = 10;
            this.viewEmployees1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.viewEmployees1);
            this.Controls.Add(this.addEmployees1);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.addEmployees);
            this.Controls.Add(this.viewEmployees);
            this.Name = "Form1";
            this.Text = "Gross Pay";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Button viewEmployees;
        private System.Windows.Forms.Button addEmployees;
        private System.Windows.Forms.Label mainLabel;
        private addEmployees addEmployees1;
        private viewEmployees viewEmployees1;
    }
}

