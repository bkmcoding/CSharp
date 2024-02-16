using System.Windows.Forms;

namespace GradeBookApp
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
            this.title = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.grade1Label = new System.Windows.Forms.Label();
            this.grade2Label = new System.Windows.Forms.Label();
            this.grade3Label = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.fNameInput = new System.Windows.Forms.TextBox();
            this.lNameInput = new System.Windows.Forms.TextBox();
            this.grade1Input = new System.Windows.Forms.TextBox();
            this.grade2Input = new System.Windows.Forms.TextBox();
            this.grade3Input = new System.Windows.Forms.TextBox();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Letter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(57, 29);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(204, 42);
            this.title.TabIndex = 0;
            this.title.Text = "Gradebook";
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLabel.Location = new System.Drawing.Point(60, 105);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(111, 24);
            this.fNameLabel.TabIndex = 1;
            this.fNameLabel.Text = "First Name: ";
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameLabel.Location = new System.Drawing.Point(60, 151);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(109, 24);
            this.lNameLabel.TabIndex = 2;
            this.lNameLabel.Text = "Last Name: ";
            // 
            // grade1Label
            // 
            this.grade1Label.AutoSize = true;
            this.grade1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade1Label.Location = new System.Drawing.Point(60, 201);
            this.grade1Label.Name = "grade1Label";
            this.grade1Label.Size = new System.Drawing.Size(87, 24);
            this.grade1Label.TabIndex = 3;
            this.grade1Label.Text = "Grade 1: ";
            // 
            // grade2Label
            // 
            this.grade2Label.AutoSize = true;
            this.grade2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade2Label.Location = new System.Drawing.Point(60, 254);
            this.grade2Label.Name = "grade2Label";
            this.grade2Label.Size = new System.Drawing.Size(87, 24);
            this.grade2Label.TabIndex = 4;
            this.grade2Label.Text = "Grade 2: ";
            // 
            // grade3Label
            // 
            this.grade3Label.AutoSize = true;
            this.grade3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade3Label.Location = new System.Drawing.Point(60, 305);
            this.grade3Label.Name = "grade3Label";
            this.grade3Label.Size = new System.Drawing.Size(87, 24);
            this.grade3Label.TabIndex = 5;
            this.grade3Label.Text = "Grade 3: ";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(128, 361);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(250, 60);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.Location = new System.Drawing.Point(431, 361);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(250, 60);
            this.viewButton.TabIndex = 7;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // fNameInput
            // 
            this.fNameInput.Location = new System.Drawing.Point(178, 105);
            this.fNameInput.Multiline = true;
            this.fNameInput.Name = "fNameInput";
            this.fNameInput.Size = new System.Drawing.Size(200, 30);
            this.fNameInput.TabIndex = 8;
            // 
            // lNameInput
            // 
            this.lNameInput.Location = new System.Drawing.Point(178, 151);
            this.lNameInput.Multiline = true;
            this.lNameInput.Name = "lNameInput";
            this.lNameInput.Size = new System.Drawing.Size(200, 30);
            this.lNameInput.TabIndex = 9;
            // 
            // grade1Input
            // 
            this.grade1Input.Location = new System.Drawing.Point(153, 201);
            this.grade1Input.Multiline = true;
            this.grade1Input.Name = "grade1Input";
            this.grade1Input.Size = new System.Drawing.Size(225, 30);
            this.grade1Input.TabIndex = 10;
            // 
            // grade2Input
            // 
            this.grade2Input.Location = new System.Drawing.Point(153, 254);
            this.grade2Input.Multiline = true;
            this.grade2Input.Name = "grade2Input";
            this.grade2Input.Size = new System.Drawing.Size(225, 30);
            this.grade2Input.TabIndex = 11;
            // 
            // grade3Input
            // 
            this.grade3Input.Location = new System.Drawing.Point(153, 305);
            this.grade3Input.Multiline = true;
            this.grade3Input.Name = "grade3Input";
            this.grade3Input.Size = new System.Drawing.Size(225, 30);
            this.grade3Input.TabIndex = 12;
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToDeleteRows = false;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Firstname,
            this.Grade,
            this.Letter});
            this.dataTable.Location = new System.Drawing.Point(431, 105);
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.Size = new System.Drawing.Size(300, 230);
            this.dataTable.TabIndex = 13;
            this.dataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellContentClick);
            // 
            // Firstname
            // 
            this.Firstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Firstname.HeaderText = "Name";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            this.Firstname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Grade
            // 
            this.Grade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            this.Grade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Letter
            // 
            this.Letter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Letter.HeaderText = "Letter Grade";
            this.Letter.Name = "Letter";
            this.Letter.ReadOnly = true;
            this.Letter.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.grade3Input);
            this.Controls.Add(this.grade2Input);
            this.Controls.Add(this.grade1Input);
            this.Controls.Add(this.lNameInput);
            this.Controls.Add(this.fNameInput);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.grade3Label);
            this.Controls.Add(this.grade2Label);
            this.Controls.Add(this.grade1Label);
            this.Controls.Add(this.lNameLabel);
            this.Controls.Add(this.fNameLabel);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Gradebook Application";
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.Label grade1Label;
        private System.Windows.Forms.Label grade2Label;
        private System.Windows.Forms.Label grade3Label;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.TextBox fNameInput;
        private System.Windows.Forms.TextBox lNameInput;
        private System.Windows.Forms.TextBox grade1Input;
        private System.Windows.Forms.TextBox grade2Input;
        private System.Windows.Forms.TextBox grade3Input;
        private System.Windows.Forms.DataGridView dataTable;
        private DataGridViewTextBoxColumn Firstname;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn Letter;
    }
}

