namespace PhonebookManagerSQL
{
    partial class PBManagerForm
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
            lblFormTitle = new Label();
            dgvRecordList = new DataGridView();
            btnAdd = new Button();
            btnRemove = new Button();
            btnRefresh = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRecordList).BeginInit();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Bahnschrift SemiBold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.Location = new Point(287, 19);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(361, 45);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Phonebook Manager";
            // 
            // dgvRecordList
            // 
            dgvRecordList.AllowUserToAddRows = false;
            dgvRecordList.AllowUserToDeleteRows = false;
            dgvRecordList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecordList.Location = new Point(26, 100);
            dgvRecordList.Name = "dgvRecordList";
            dgvRecordList.ReadOnly = true;
            dgvRecordList.Size = new Size(632, 401);
            dgvRecordList.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(699, 118);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(187, 63);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(699, 218);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(187, 63);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Delete";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(699, 320);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(187, 61);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(699, 416);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(187, 61);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // PBManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 540);
            Controls.Add(btnExit);
            Controls.Add(btnRefresh);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(dgvRecordList);
            Controls.Add(lblFormTitle);
            Name = "PBManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += PBManagerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecordList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private DataGridView dgvRecordList;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnRefresh;
        private Button btnExit;
    }
}
